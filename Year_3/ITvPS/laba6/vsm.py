import pymorphy2
import re
import math

morph = pymorphy2.MorphAnalyzer()


def read_file(obj_file):
    string = ''
    f = open(obj_file)
    for line in f.readlines():
        string += line
    return string


def clear_text(docs):
    my_docs = []
    my_dict = []
    for doc in docs:
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


def clear_one_text(doc):
    my_dict = []
    t = re.split(r'\W+', doc.lower())
    r = re.compile("[а-яА-Яa-zA-Z]+")
    token_list = [w for w in filter(r.match, t)]
    clear_token_list = []
    for token in token_list:
        clear_token_list.append(morph.parse(token)[0].normal_form)
    for token in clear_token_list:
        if token not in my_dict:
            my_dict.append(token)

    return clear_token_list, my_dict


def vsm(my_docs, my_dict):
    boolean = {}
    tf = {}
    tf_idf = {}
    tf2 = [[0] * len(my_dict) for i in range(len(my_docs))]

    for i in range(len(my_docs)):
        for j in range(len(my_dict)):
            if my_dict[j] in my_docs[i]:
                tf2[i][j] = my_docs[i].count(my_dict[j]) / len(my_docs[i])

    for i in range(len(my_dict)):
        a = []
        b = []
        c = []
        for j in range(len(my_docs)):
            if my_dict[i] in my_docs[j]:
                a.append(1)
                b.append(my_docs[j].count(my_dict[i]))
                c.append(tf2[j][i] * math.log2(len(my_docs[j]) / sum([1.0 for z in my_docs if my_dict[i] in z])))
            else:
                a.append(0)
                b.append(0)
                c.append(0)

        boolean[my_dict[i]] = a
        tf[my_dict[i]] = b
        tf_idf[my_dict[i]] = c
    return boolean, tf, tf_idf


def create_dict(my_dict, table):
    res_dict = {}
    for i in range(len(table)):
        tmp = {}
        for word in table[i]:
            tmp = dict(zip(my_dict, table[i]))
        res_dict[i] = tmp
    return res_dict


def compute_tf(my_docs, my_dict):
    tf = {}
    for i in range(len(my_dict)):
        b = []
        for j in range(len(my_docs)):
            if my_dict[i] in my_docs[j]:
                b.append(my_docs[j].count(my_dict[i]))
            else:
                b.append(0)
        tf[my_dict[i]] = b
    return tf


def compute_tf_idf1(my_docs, my_dict):
    tf_idf = {}
    tf2 = [[0] * len(my_dict) for i in range(len(my_docs))]
    for i in range(len(my_docs)):
        for j in range(len(my_dict)):
            if my_dict[j] in my_docs[i]:
                tf2[i][j] = my_docs[i].count(my_dict[j]) / len(my_docs[i])

    for i in range(len(my_dict)):
        c = []
        for j in range(len(my_docs)):
            if my_dict[i] in my_docs[j]:
                c.append(tf2[j][i] * math.log2(len(my_docs[j]) / sum([1.0 for z in my_docs if my_dict[i] in z])))
            else:
                c.append(0)
        tf_idf[my_dict[i]] = c
    return tf_idf
