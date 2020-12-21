import pymorphy2
import re

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
