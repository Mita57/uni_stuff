import csv
import re
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
import pymorphy2
import math

morph = pymorphy2.MorphAnalyzer()

def read_docs_with_class(classes_name):
    result = []
    for class_name in classes_name:
        path = 'C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba7/stuff/news_yandex/' + class_name + '_all.txt'
        string = ""
        f = open(path)
        for line in f.readlines():
            string += line
        all_docs = re.split(r'[*]+', string)
        for doc in all_docs:
            result.append(doc)
    return result


def perform_text_test(file):
    path = 'C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba7/stuff/test/' + file + '.txt'
    string = ""
    f = open(path)
    for line in f.readlines():
        string += line
    return string


def clear_one_text(doc):
    my_dict = []
    tokens = word_tokenize(doc)
    r = re.compile("[а-яА-Яa-zA-Z]+")
    tokens = [w.lower() for w in filter(r.match, tokens)]
    tokens = [morph.parse(i)[0].normal_form for i in tokens]
    for i in tokens:
        if i not in my_dict:
            my_dict.append(i)

    return tokens, my_dict

def tokenize_ru(docs, delete_stop_words=False):
    class_tokens = []
    token_dict = []
    for text in docs:
        tokens = word_tokenize(text)
        r = re.compile("[а-яА-Яa-zA-Z]+")
        tokens = [w.lower() for w in filter(r.match, tokens)]
        if delete_stop_words:
            stop_words = stopwords.words('russian')
            tokens = [i for i in tokens if (i not in stop_words)]
        tokens = [morph.parse(i)[0].normal_form for i in tokens]
        class_tokens.append(tokens)
        for i in tokens:
            if i not in token_dict:
                token_dict.append(i)
    return class_tokens, token_dict


def vsm(my_docs, my_dict):
    tf = {}
    tf_idf = {}
    idf = {}
    tf2 = [[0] * len(my_dict) for i in range(len(my_docs))]

    for i in range(len(my_docs)):
        for j in range(len(my_dict)):
            if my_dict[j] in my_docs[i]:
                tf2[i][j] = my_docs[i].count(my_dict[j]) / len(my_docs[i])

    for i in range(len(my_dict)):
        b = []
        c = []
        d = []
        for j in range(len(my_docs)):
            if my_dict[i] in my_docs[j]:
                b.append(my_docs[j].count(my_dict[i]))
                c.append(tf2[j][i] * math.log2(len(my_docs[j]) / sum([1.0 for z in my_docs if my_dict[i] in z])))
                d.append(math.log2(len(my_docs) / sum([1.0 for z in my_docs if my_dict[i] in z])))
            else:
                b.append(0)
                c.append(0)
                d.append(0)

        tf[my_dict[i]] = b
        tf_idf[my_dict[i]] = c
        idf[my_dict[i]] = d
    return tf_idf


def compute_idf(my_docs, my_dict):
    result = {}
    for token in my_dict:
        result[token] = math.log2(len(my_docs)/sum([1.0 for i in my_docs if token in i]))
    with open("idf.csv", 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        columns = ['word', 'idf']
        a_pen.writerow(columns)
        for token, i in result.items():
            str_r = [token] + [i]
            a_pen.writerow(str_r)


def compute_centroids(token_dict, tf_idf):
    m = {}
    for token in token_dict:
        count_m1 = 0
        count_m2 = 0
        for i in tf_idf[token][1:21]:
            count_m1 += i
        for i in tf_idf[token][20:40]:
            count_m2 += i
        m[token] = [count_m1/20, count_m2/20]
    return m

def read_idf():
    res = {}
    with open("idf.csv") as f:
        reader = csv.DictReader(f, delimiter=',')
        for line in reader:
            res[line['word']] = line['idf']
    return res


def write_tf_idf(tfidf):
    with open("tf_idf.csv", 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        columns = ['word']
        for i in range(1, 41):
            columns.append(i)
        a_pen.writerow(columns)
        for token, i in tfidf.items():
            str_r = [token] + i
            a_pen.writerow(str_r)


def euclid_metric(text, centroids):
    idf = read_idf()
    my_doc, my_dict = clear_one_text(text)
    e1 = 0
    e2 = 0
    for token in my_dict:
        tf = 0
        if token in idf:
            tf = float(idf[token][0]) * (my_doc.count(token) / len(my_doc))
        if token in centroids:
            e1 += (centroids[token][0] - tf) ** 2
            e2 += (centroids[token][1] - tf) ** 2

    return [math.sqrt(e1), math.sqrt(e2)]

classes = ['sport', 'tech']
class_docs, token_dict = tokenize_ru(read_docs_with_class(classes))

tf_idf = vsm(class_docs, token_dict)
centroids = compute_centroids(token_dict, tf_idf)
texts = ['sport_1', 'sport_2', 'tech_1', 'tech_2', 'tech_3']
for text in texts:
    print("Текст: ", text)
    res = euclid_metric(perform_text_test(text), centroids)
    if res[0] > res[1]:
        print("Технологии: %r\nСпорт: %s" % (res[1], res[0]))
    else:
        print("Спорт: %r\nТехнологии: %s" % (res[0], res[1]))
    print()