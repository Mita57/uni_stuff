import math
import pandas as pd


def expert(brightness):
    category = input('Entrez votre opinion: dark, middle, language')
    df = pd.read_csv('results.csv', sep=',')
    df.iloc[brightness, df.columns.get_loc(category)] += 1
    df.iloc[brightness, df.columns.get_loc("number_ppl")] += 1
    df.to_csv('results.csv', index=False, header=True)


def analysis(brightness):
    dictionary = {get_dark(brightness): "Dark", get_middle(brightness): "Middle", get_light(brightness): "Light"}
    print(dictionary)


def get_light(x):
    df = pd.read_csv('results.csv', sep=',')
    a = get_a(df, 'light')
    k = get_k(df, 'light')
    return 1 / (1 + math.pow(math.e, (-k * (x - a))))


def get_dark(x):
    df = pd.read_csv('results.csv', sep=',')
    a = get_a(df, 'dark')
    k = get_k(df, 'dark')
    return 1 / (1 + math.pow(math.e, (-k * (x - a))))


def get_middle(x):
    df = pd.read_csv('results.csv', sep=',')
    a = get_a(df, 'middle')
    k = get_k(df, 'middle')
    return math.pow(math.e, (-k * abs(x - a)))


def get_a(df, column):
    a_min = 101
    a_max = -1
    i = 0
    for aVar in df[column]:
        count = df.iloc[i, df.columns.get_loc("dark")] + df.iloc[i, df.columns.get_loc("middle")] + df.iloc[
            i, df.columns.get_loc("light")]
        if round(aVar / count, 1) == 0.5:
            if i > a_max:
                a_max = i
            if i < a_min:
                a_min = i
        i += 1
    return round((a_max + a_min) / 2)


def get_k(df, column):
    a = get_a(df, column)
    var = get_var(df, column)
    count = df.iloc[var, df.columns.get_loc("dark")] + df.iloc[var, df.columns.get_loc("middle")] + \
            df.iloc[var, df.columns.get_loc("light")]
    v = df.iloc[var, df.columns.get_loc(column)]
    return ((-math.log(v / count, math.e)) / abs(var - a)) if column == 'middle' else \
        (-math.log(1 / (v / count) - 1, math.e)) / (var - a)


def get_var(df, column):
    i = 0
    a = get_a(df, column)
    for a_var in df[column]:
        if (a_var != 0 and a_var != 1 and i != a
                and a_var != df.iloc[i, df.columns.get_loc("dark")] + df.iloc[i, df.columns.get_loc("middle")] +
                df.iloc[i, df.columns.get_loc("light")]):
            return i
        i += 1


def get_brightness_from(r, g, b):
    r = int(r) / 2.55
    g = int(g) / 2.55
    b = int(b) / 2.55
    brightness = 0.2126 * r + 0.7152 * g + 0.0722 * b
    return round(brightness)


while True:
    mode = input('Choisisez le mode d\'application: 1. Le mode d\'expert. 2. Le mode d\'analyse')
    red = int(input('rouge'))
    green = int(input('vert'))
    blue = int(input('bleu'))
    brt = get_brightness_from(red, green, blue)
    expert(brt) if mode == '1' else analysis(brt)
