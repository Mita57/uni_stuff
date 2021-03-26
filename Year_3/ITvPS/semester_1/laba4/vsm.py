import pymorphy2
import re
import csv
from collections import Counter
import math


def read_file(obj_file):
    string = ''
    result = []
    f = obj_file.read().decode('utf-8')
    all_docs = re.split(r'Документ\s+№\s*\d+[*]+', f)
    for doc in all_docs:
        result += [doc]
    return result


def clear_text(docs):
    my_docs = []
    my_dict = []
    for doc in docs:
        morph = pymorphy2.MorphAnalyzer()
        t = re.split(r'\W+', doc.lower())
        r = re.compile("[а-яА-Яa-zA-Z]+")
        token_list = [w for w in filter(r.match, t)]
        clear_token_list = []
        for token in token_list:
            clear_token_list.append(morph.parse(token)[0].normal_form)
        my_docs.append(clear_token_list)
        for token in clear_token_list:
            if token not in my_dict:
                my_dict.append(token)
    return my_docs, my_dict


def vsm(doc, dict):
    boolean = {}
    tf = {}
    tf_idf = {}
    tf2 = [[0] * len(dict) for i in range(len(doc))]

    for i in range(len(doc)):
        for j in range(len(dict)):
            if dict[j] in doc[i]:
                tf2[i][j] = doc[i].count(dict[j]) / len(doc[i])

    for i in range(len(dict)):
        a = []
        b = []
        c = []
        for j in range(len(doc)):
            if dict[i] in doc[j]:
                a.append(1)
                b.append(doc[j].count(dict[i]))
                c.append(tf2[j][i] * math.log2(len(doc[j]) / sum([1.0 for z in doc if dict[i] in z])))
            else:
                a.append(0)
                b.append(0)
                c.append(0)

        boolean[dict[i]] = a
        tf[dict[i]] = b
        tf_idf[dict[i]] = c
    return boolean, tf, tf_idf


def create_dict(dict, table):
    res_dict = {}
    for i in range(len(table)):
        tmp = {}
        for word in table[i]:
            tmp = dict(zip(dict, table[i]))
        res_dict[i] = tmp
    return res_dict


def write_csv(info):
    with open('vsm.csv', 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        for i, doc in info.items():
            str_r = [i]+doc
            a_pen.writerow(str_r)


def compute_tf(text):
    tf_text = Counter(text)
    return tf_text


def compute_tf_idf1(docs, dict):
    tf_idf = {}
    tf2 = [[0] * len(dict) for i in range(len(docs))]
    for i in range(len(docs)):
        for j in range(len(dict)):
            if dict[j] in docs[i]:
                tf2[i][j] = docs[i].count(dict[j]) / len(docs[i])

    for i in range(len(dict)):
        c = []
        for j in range(len(docs)):
            if dict[i] in docs[j]:
                c.append(tf2[j][i] * math.log2(len(docs[j]) / sum([1.0 for z in docs if dict[i] in z])))
            else:
                c.append(0)
        tf_idf[dict[i]] = c
    return tf_idf
