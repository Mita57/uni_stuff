import csv
import re
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
import pymorphy2
import math
import operator

morph = pymorphy2.MorphAnalyzer()


def read_docs_with_class(classes_name):
    result = []
    for class_name in classes_name:
        path = 'C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba9/лаба_9/news_yandex/' + class_name + '_all.txt'
        string = ""
        f = open(path)
        for line in f.readlines():
            string += line
        all_docs = re.split(r'[*]+', string)
        for doc in all_docs:
            result.append(doc)
    return result


def tokenize_ru(docs, delete_stop_words=True):
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


def tokenize_ru_one(doc):
    my_dict = []
    tokens = word_tokenize(doc)
    r = re.compile("[а-яА-Яa-zA-Z]+")
    tokens = [w.lower() for w in filter(r.match, tokens)]
    stop_words = stopwords.words('russian')
    tokens = [i for i in tokens if (i not in stop_words)]
    tokens = [morph.parse(i)[0].normal_form for i in tokens]
    for i in tokens:
        if i not in my_dict:
            my_dict.append(i)

    return tokens, my_dict


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
        result[token] = math.log2(len(my_docs) / sum([1.0 for i in my_docs if token in i]))
    with open("idf.csv", 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        columns = ['word', 'idf']
        a_pen.writerow(columns)
        for token, i in result.items():
            str_r = [token] + [i]
            a_pen.writerow(str_r)


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


def compute_PMI(class_docs, token_dict):
    pmi = {}
    all_rub = ' '.join([' '.join(i) for i in class_docs]).split()
    sport = ' '.join([' '.join(i) for i in class_docs[:21]]).split()
    tech = ' '.join([' '.join(i) for i in class_docs[20:40]]).split()
    N = len(all_rub)
    for token in token_dict:
        count_w = all_rub.count(token)
        sport_tmp = sport.count(token) * N / (count_w * len(sport))
        tech_tmp = tech.count(token) * N / (count_w * len(tech))
        pmi_tech = pmi_sport = 0
        if sport_tmp != 0:
            pmi_sport = math.log2(sport_tmp)
        if tech_tmp != 0:
            pmi_tech = math.log2(tech_tmp)
        w = pmi_sport - pmi_tech
        if abs(w) > 0.5:
            pmi[token] = w
    return pmi


def absolute_frequency(pmi, class_docs):
    freq = {}
    idf = read_idf()
    sport = ' '.join([' '.join(i) for i in class_docs[:21]]).split()
    tech = ' '.join([' '.join(i) for i in class_docs[20:40]]).split()
    for token, val in pmi.items():
        try:
            if val > 0:
                freq[token] = [float(idf[token]) * sport.count(token), 0]
            else:
                freq[token] = [0, float(idf[token]) * tech.count(token)]
        except:
            pass
    return freq


def read_idf():
    res = {}
    with open("idf.csv") as f:
        reader = csv.DictReader(f, delimiter=',')
        for line in reader:
            res[line['word']] = line['idf']
    return res


def read_tf_idf():
    res = {}
    with open("tf_idf.csv") as f:
        reader = csv.DictReader(f, delimiter=',')
        for line in reader:
            res[line['word']] = [line['1'], line['2']]
    return res


def tf_idf_test(file, pmi):
    idf = read_idf()
    path = 'C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba9/лаба_9/test/' + file + '.txt'
    string = ""
    f = open(path)
    for line in f.readlines():
        string += line
    test_doc, test_dict = tokenize_ru_one(string)
    freq = {}
    for token in pmi:
        if token in idf:
            freq[token] = [float(idf[token]) * test_doc.count(token)]
    return freq


def cosine(tf_idf_1, tf_idf_2):
    def multiple(v1, v2):
        return sum(map(operator.mul, v1, v2))

    def cos(v1, v2):
        num = multiple(v1, v2)
        den = math.sqrt(multiple(v1, v1)) * math.sqrt(multiple(v2, v2))
        return num / den

    vec1 = [i[0] for i in tf_idf_1.values()]
    vec2 = [i for i in tf_idf_2.values()]
    res = []
    for vec in tf_idf_2.values():
        for i in range(len(vec)):
            cur = [z[i] for z in vec2]
            res.append(cos(vec1, cur))
        break
    return res


classes = ['sport', 'tech']
class_docs, token_dict = tokenize_ru(read_docs_with_class(classes))
pmi = compute_PMI(class_docs, token_dict)
tf_idf = absolute_frequency(pmi, class_docs)
texts = ['sport_1', 'sport_2', 'sport_3', 'tech_1', 'tech_2', 'tech_4']
for text in texts:
    print(text)
    tf_idf_tst = tf_idf_test(text, pmi)
    print("Спорт | Технологии")
    print("Мера сходства", cosine(tf_idf_tst, tf_idf))
    print("===============================================================================")
