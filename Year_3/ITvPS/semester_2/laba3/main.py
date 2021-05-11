import requests
from bs4 import BeautifulSoup
import pandas as pd

BASE_URL = 'https://soccer365.ru/competitions/13/'

tables = pd.read_html(BASE_URL)

teams_df = tables[0]
penalties_df = tables[3]

teams_df = teams_df.rename(columns={"Unnamed: 1": "Команда", "З": "Голы"})
print('_________________MOST SCORES___________________')
print(teams_df.nlargest(3, 'Голы')[['Команда', 'Голы']])


r = requests.get(BASE_URL)  #
soap = BeautifulSoup(r.text, "html.parser")
penalties_table = soap.select('.comp_table_v2')[2].select('tr')[1:]
player_team = {}

for row in penalties_table:
    player_team[row.contents[1].contents[3].string] = row.contents[1].contents[1].attrs['title']

penalties_df.insert(0, 'Команда', player_team.values())

print('_________________MOST YELLOW CARDS___________________')
print(penalties_df.groupby('Команда')['Unnamed: 2'].sum().sort_values(ascending=False).head(3))

bombs_df = tables[1]

bombs_table = soap.select('.comp_table_v2')[0].select('tr')[1:]
player_team = {}

for row in bombs_table:
    player_team[row.contents[1].contents[3].string] = row.contents[1].contents[1].attrs['title']

bombs_df.insert(0, 'Команда', player_team.values())
bombs_df = bombs_df.rename(columns={"Unnamed: 3": "Игры"})

print('_________________DUDES THAT HAVEN\'T PLAYED IN ALL MATCHES___________________')
print(bombs_df.loc[bombs_df['Игры'] != 29]['Бомбардиры'])

print('_________________PENALTY PARTS IN ALL THE GOALS___________________')
print(bombs_df.groupby('Команда')['Unnamed: 2'].sum() / bombs_df.groupby('Команда')['Unnamed: 1'].sum())

print('_________________CORRELATION THINGY___________________')
print(teams_df['Голы'].corr(teams_df['О']))

