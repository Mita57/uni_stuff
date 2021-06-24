import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
from string import punctuation
import re
import pymorphy2
from dostoevsky.tokenization import RegexTokenizer
from nltk.corpus import stopwords
from nltk.tokenize import word_tokenize
from sklearn.cluster import KMeans, MiniBatchKMeans
from sklearn.feature_extraction.text import CountVectorizer

patterns = "[A-Za-z0-9!#$%&'()*+,./:;<=>?@[\]^_`{|}~—\"\-]+"
tokenizer = RegexTokenizer()


def find_optimal_clusters(data, max_k):
    iters = range(2, max_k + 1, 2)

    sse = []
    for k in iters:
        sse.append(
            MiniBatchKMeans(n_clusters=k, init_size=1024, batch_size=2048, random_state=20).fit(data).inertia_)
        print('Fit {} clusters'.format(k))

    f, ax = plt.subplots(1, 1)
    ax.plot(iters, sse, marker='o')
    ax.set_xlabel('Cluster Centers')
    ax.set_xticks(iters)
    ax.set_xticklabels(iters)
    ax.set_ylabel('SSE')
    ax.set_title('SSE by Cluster Center Plot')
    plt.show()


def preprocessing_data(text):
    patterns = "[A-Za-z0-9!#$%&'()*+,./:;<=>?@[\]^_`{|}~—\"\-]+"
    stop_words = set(stopwords.words('russian') + list(punctuation) + list(["который", "это", "этот"]))
    morph = pymorphy2.MorphAnalyzer()
    text = text.lower()
    text = re.sub(patterns, ' ', text, flags=re.MULTILINE)
    tokens = word_tokenize(text)
    text = [word for word in tokens if word not in stop_words]
    text = [morph.normal_forms(word.strip())[0] for word in text]
    text = ' '.join(text)
    return text


def plot(count_vector):
    mtrx_dict = count_vector.todok()
    vals = np.array(list(mtrx_dict.values()))
    xy = np.array(list(mtrx_dict.keys()))


def get_top_keywords(data, clusters, labels, n_terms):
    df = pd.DataFrame(data.todense()).groupby(clusters).mean()

    for i, r in df.iterrows():
        print('\nКластер {}'.format(i))
        print(','.join([labels[t] for t in np.argsort(r)[-n_terms:]]))


def clustering(clean_docs):
    tf = CountVectorizer(lowercase=True, max_features=10, analyzer='word', preprocessor=preprocessing_data)
    tf.fit(clean_docs)
    X = tf.fit_transform(clean_docs)
    kmeans = KMeans(n_clusters=3)
    kmeans.fit(X)
    y_kmeans = kmeans.predict(X)
    print(kmeans.cluster_centers_)
    print("Les clusters des documents : ")
    get_top_keywords(X, y_kmeans, tf.get_feature_names(), 2)
    print(kmeans.labels_)
    s = [print("Document " + str((i + 1)) + " метка - " + str(kmeans.labels_[i])) for i in range(len(kmeans.labels_))]
    plot(X)


docs = re.split("Документ\s*№\s*\d{1,3}\*+", open('corpus.txt').read())
clean_docs = []
for doc in docs:
    clean_docs.append(preprocessing_data(doc))
clustering(clean_docs)




