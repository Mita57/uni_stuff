import numpy as np
import pandas as pd
from numpy import log2 as log

eps = np.finfo(float).eps


def find_entropy(df):
    cls = df.keys()[-1]
    entropy = 0
    values = df[cls].unique()
    for value in values:
        fraction = df[cls].value_counts()[value] / len(df[cls])
        entropy += -fraction * np.log2(fraction)
    return entropy


def find_entropy_attribute(df, attribute):
    cls = df.keys()[-1]
    target_variables = df[cls].unique()
    variables = df[
        attribute].unique()
    entropy2 = 0
    for variable in variables:
        entropy = 0
        for target_variable in target_variables:
            num = len(df[attribute][df[attribute] == variable][df[cls] == target_variable])
            den = len(df[attribute][df[attribute] == variable])
            fraction = num / (den + eps)
            entropy += -fraction * log(fraction + eps)
        fraction2 = den / len(df)
        entropy2 += -fraction2 * entropy
    return abs(entropy2)


def find_winner(df):
    IG = []
    for key in df.keys()[:-1]:
        IG.append(find_entropy(df) - find_entropy_attribute(df, key))
    return df.keys()[:-1][np.argmax(IG)]


def get_subtable(df, node, value):
    return df[df[node] == value].reset_index(drop=True)


def build_tree(df, tree=None):
    cls = df.keys()[-1]
    node = find_winner(df)
    attr_value = np.unique(df[node])

    if tree is None:
        tree = {}
        tree[node] = {}

    for value in attr_value:
        subtable = get_subtable(df, node, value)
        cl_value, counts = np.unique(subtable[cls], return_counts=True)

        if len(counts) == 1:
            tree[node][value] = cl_value[0]
        else:
            tree[node][value] = build_tree(subtable)

    return tree


life_form = 'травянистое,травянистое,травянистое,луковичное,луковичное,луковичное,пальма,пальма'.split(',')
leaf_color = 'зеленая,зеленая,пестрая,зеленая,зеленая,пестрая,зеленая,пестрая'.split(',')
leaf_form = 'ремневидная,ремневидная,овальная,линейная,ланцетная,ланцетная,ланцетная,ланцетная'.split(',')
surface = 'обычная,обычная,опушенная,опушенная,складчатая,обычная,обычная,складчатая'.split(',')
leaf_size = '10-15 см,15-30 см,5-10 см,15-30 см,15-30 см,15-30 см,15-30 см,5-10 см'.split(',')
blossom_size = '1-5 см,1-5 см,1-5 см,5-10 см,5-10 см,5-10 см,0-1 см,0-1 см'.split(',')
name = 'Криптантус,Сансеверия,Марранта,Гемантус,Эухарис,Лахеналия,Хамеропс,Птерис'.split(',')

dataset = {'life_form': life_form, 'leaf_color': leaf_color, 'leaf_form': leaf_form, 'surface': surface,
           'leaf_size': leaf_size, 'blossom_size': blossom_size, 'name': name}
df = pd.DataFrame(dataset, columns=['life_form', 'leaf_color', 'leaf_form', 'surface', 'leaf_size',
                                    'blossom_size', 'name'])

tree = build_tree(df)

print(tree)


def wtf(tree):
    if type(tree) is str:
        print(tree)
        return

    for k in tree.keys():
        for j in tree[k]:
            res = True if input(k + ' = ' + j + '?').lower() == 'y' else False
            if res:
                wtf(tree[k][j])
                return


wtf(tree)
