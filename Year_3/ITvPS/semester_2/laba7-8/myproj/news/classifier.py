import pandas as pd
import re
import numpy as np
from nltk.corpus import stopwords
from string import punctuation
from nltk.tokenize import word_tokenize
from sklearn.model_selection import train_test_split
from sklearn.feature_extraction.text import CountVectorizer
from sklearn.feature_extraction.text import TfidfTransformer
from sklearn.naive_bayes import BernoulliNB
from nltk.stem.snowball import SnowballStemmer
import pickle

def training_data(train_db):
    # train_db = pd.read_csv(input_data)  # получение датасета
    # train_db = train_db[:4000]

    train_db['text'] = train_db['text'].map(preprocessing_data)
    # подготовка данных к обработке
    # разделение на тренировочную и тестовую выборку
    X_train, X_test, y_train, y_test = train_test_split(train_db['text'], train_db['class'], test_size=0.3,
                                                        random_state=42)
    # формирование словаря
    count_vect = CountVectorizer()
    X_train_counts = count_vect.fit_transform(X_train)
    X_train_counts.shape
    write_pickle(count_vect, 'count_vect')

    # формирование TF-IDF
    tfidf_transformer = TfidfTransformer()
    X_train_tfidf = tfidf_transformer.fit_transform(X_train_counts)
    write_pickle(tfidf_transformer, 'tfidf_transformer')

    # тренировка классификтора
    model = BernoulliNB().fit(X_train_tfidf, y_train)
    write_pickle(model, 'model')

    # формирование тренировочной выборки
    count_vect2 = read_pickle('count_vect')
    X_new_counts = count_vect2.transform(X_test)
    tfidf_transformer2 = read_pickle('tfidf_transformer')
    X_new_tfidf = tfidf_transformer2.transform(X_new_counts)

    # оценка точности классификатора
    predicted = model.predict(X_new_tfidf)
    acc = np.mean(predicted == y_test)
    print("Точность: ", acc)  # 87%


def preprocessing_data(text):
    stop_words = set(stopwords.words('english') + list(punctuation))  # список стоп-слов
    stemmer = SnowballStemmer("english")
    text = text.lower()  # приведение слов к строчным
    text = re.sub('[^a-zA-Z]', ' ', text, flags=re.MULTILINE)  # удаляем знаки пунктуации
    tokens = word_tokenize(text)  # разделяем слова на отдельные токены
    text = [word for word in tokens if word not in stop_words]  # удаляем стоп-слова
    text = [stemmer.stem(word) for word in text]  # производим стемминг
    text = ' '.join(text)
    return text

def write_pickle(file, name):
    with open(name + '.pkl', 'wb') as f:
        pickle.dump(file, f)


def read_pickle(name):
    with open(name + '.pkl', 'rb') as f:
        return pickle.load(f)

def classifier(messages):
    clear_message = map(preprocessing_data, messages)
    count_vect = read_pickle('count_vect')
    X_new_counts = count_vect.transform(clear_message)
    tfidf_transformer = read_pickle('tfidf_transformer')
    X_new_tfidf = tfidf_transformer.transform(X_new_counts)

    model = read_pickle('model')
    predicted = model.predict(X_new_tfidf)
    return list(zip(messages, predicted))
