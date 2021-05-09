import requests
from bs4 import BeautifulSoup

BASE_URL = 'https://soccer365.ru/competitions/13/'

r = requests.get(BASE_URL + str(1))  #

# soap = BeautifulSoup(r.text)

soap = BeautifulSoup(r.text, "html.parser")  # html.parser lxml
print(soap.title)

cods = soap.select('[class*=responses__item__message]')

# print (len(cods))
# print (cods[0])


parsed_cods = []

for cod in cods:
    txt = cod.get_text()
    parsed_cods.append(txt)

print(len(parsed_cods))

print(parsed_cods[5])