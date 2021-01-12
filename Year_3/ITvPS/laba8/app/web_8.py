import re
from string import punctuation
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
import pymorphy2


def read_doc(text_name):
    result = []
    path = 'C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba8/лаба_8/' + text_name + '.txt'
    string = ""
    f = open(path)
    for line in f.readlines():
        string += line
    all_docs = re.split(r'[\n]+', string)
    sentence = re.split(r'\.', string)
    for par in all_docs:
        if par != "":
            result.append(par)
    return result, sentence


def preprocessing_data(text):
    stop_words = set(stopwords.words('russian') + list(punctuation))
    morph = pymorphy2.MorphAnalyzer()
    text = text.lower()
    text = re.sub('[^а-яА-Я]', ' ', text, flags=re.MULTILINE)
    tokens = word_tokenize(text)
    text = [word for word in tokens if word not in stop_words]
    text = [morph.parse(word)[0].normal_form for word in text]
    text = ' '.join(text)
    return text


def create_dict(text):
    text_dict = {}
    join_text = ' '.join(text)
    for word in join_text.split():
        if word not in text_dict:
            text_dict[word] = join_text.count(word) * sum([1.0 for par in text if word in par]) / (
                        len(text) * len(join_text.split()))
    return text_dict, len(text), len(join_text.split())


def key_words(text_dict, text):
    result = []
    words = ' '.join(text).split()
    for i in range(len(words) - 1):
        if (text_dict[words[i]][1] == "ГОС" or text_dict[words[i]][1] == "ВОС") and text_dict[words[i + 1]][
            1] == "ГОС" or text_dict[words[i + 1]][1] == "ВОС":
            result.append(words[i] + " " + words[i + 1])
    for i in range(len(words) - 2):
        if (text_dict[words[i]][1] == "ГОС" or text_dict[words[i]][1] == "ВОС") and text_dict[words[i + 1]][
            1] == "ГОС" or text_dict[words[i + 1]][1] == "ВОС" and text_dict[words[i + 2]][1] == "ГОС" or \
                text_dict[words[i + 2]][1] == "ВОС":
            result.append(words[i] + " " + words[i + 1] + " " + words[i + 2])
    print(result)
    return result


def key_sentences(text_dict, sentences):
    result = {}
    for s in sentences:
        for ws in preprocessing_data(s).split():
            count = 0
            for i in text_dict.keys():
                if i == ws and i != "Н":
                    count += 1
            result[count / len(set(preprocessing_data(s).split()))] = s
    return result


for i in range(1, 6):
    text, sentences = read_doc("text_" + str(i))
    text = [preprocessing_data(i) for i in text]
    sentences = [preprocessing_data(i) for i in sentences]
    text_dict, n, N = create_dict(text)
    for word, val in text_dict.items():
        if 9 / (n * N) <= val < 1:
            text_dict[word] = [val, "ГОС"]
        elif ((1 + n / 4) ** 2) / (n * N) <= val < 9 / (n * N):
            text_dict[word] = [val, "ВОС"]
        else:
            text_dict[word] = [val, "Н"]

    print("===============================Текст " + str(i) + "========================================")
    print("______________________________")
    print("1. Ключевые слова + ГОС/ВОС/Н")
    for i, v in text_dict.items():
        print(i, v)

    print("______________________________")
    print("2. Ключевые понятия.")
    key_words(text_dict, text)

    print("______________________________")
    print("3. Реферат на 3 предложения + индекс релевантности. ")
    key_s = key_sentences(text_dict, sentences)
    list_keys = list(key_s.keys())
    list_keys.sort(reverse=True)
    for i in list_keys[:4]:
        print(i, ':', key_s[i])
