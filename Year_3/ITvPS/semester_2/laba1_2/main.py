import pandas as pd

data = pd.read_csv('prima-indians-diabetes.csv')
corrs =  data.corr()

max_corr = 0
max_corr_key_a = 0

max_corr_key_b = 0

asd = 0

for x in corrs.values:
    asd += 1
    i = 0
    for s in x:
        i += 1
        if max_corr < abs(s) < 1.0:
            max_corr_key_a = i
            max_corr_key_b = asd
            max_corr = abs(s)

# возраст
print('___________Возрасты__________')
print(data.loc[data['СД'] == 1.0]['возраст'].max())
print(data.loc[data['СД'] == 1.0]['возраст'].mean())

# ключ макс корреляции
print('___________Кореляция__________')
print(max_corr_key_a, max_corr_key_b)

# доля бездетных
print('___________Бездетные__________')
print(len(data.loc[(data['дети'] == 0) & (data['СД'] == 1)]) / len(data))

# max glyugoza
print('___________Глюкоза__________')
print(data.loc[data['возраст'] > 50]['глюкоза'].max())

# avg age des DA > 80
print('___________Возраст и АД > 80__________')
print(data.loc[data['АД'] > 80]['возраст'].mean())

# insulin higher than avg and more than 60 YO
insulin_avg = data['инсулин'].mean()
print('___________Список инсулин больше avg  старше 60__________')
print(data.loc[(data['возраст'] > 60) & (data['инсулин'] > insulin_avg)].sort_values(by='возраст'))

# with nulls
print('___________Нули__________')
print(data.isnull().any(axis=1))
