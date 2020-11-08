import re
from pymystem3 import Mystem
from collections import Counter
from flask import Flask, request, render_template
import docx2txt

app = Flask(__name__)


@app.route('/', methods=['POST', 'GET'])
def hello_world():
    if request.method == 'POST':
        return post_process(request)
    else:
        return render_template('Index.html')


def post_process(request):
    file = request.files['fileUpload']
    whole_text = docx2txt.process(file)
    texts = re.split('Документ №..+', whole_text)
    if request.form['type'] == 'boolean':
        return boolean(texts)
    if request.form['type'] == 'term_frequency':
        return term_frequency(texts)
    if request.form['type'] == 'tf-idf':
        return tf_idf(texts)


def boolean(texts):
    m = Mystem()
    lemmas_by_text = {}
    lemmas = []
    for i in range(0, len(texts)):
        lemmas_by_text[i] = m.lemmatize(texts[i])
        lemmas.extend(m.lemmatize(texts[i]))
    print('Lemmatizing finished')

    lemmas = list(dict.fromkeys(lemmas))
    matrix = [[False for x in range(len(lemmas_by_text) - 1)] for y in range(len(lemmas))]
    for i in range(0, len(lemmas)):
        print('Text ' + str(i))
        for j in range(0, len(lemmas_by_text) - 1):
            if lemmas[i] in lemmas_by_text[j]:
                matrix[i][j] = True
            else:
                pass
    return render_template('boolean.html', matrix=matrix, lemmas=lemmas, length=(len(lemmas_by_text) - 1), title='Boolean')


def term_frequency(texts):
    m = Mystem()
    lemmas_by_text = {}
    lemmas = []
    for i in range(0, len(texts)):
        lemmas_by_text[i] = m.lemmatize(texts[i])
        lemmas.extend(m.lemmatize(texts[i]))
    print('Lemmatazing finsished')

    lemmas = list(dict.fromkeys(lemmas))
    matrix = [[0 for x in range(len(lemmas_by_text) - 1)] for y in range(len(lemmas))]
    for i in range(0, len(lemmas)):
        for j in range(0, len(lemmas_by_text) - 1):
            matrix[i][j] = lemmas_by_text[j].count(lemmas[i])
    return render_template('boolean.html', matrix=matrix, lemmas=lemmas, length=(len(lemmas_by_text) - 1), title='Term frequency')


def tf_idf(texts):
    m = Mystem()
    lemmas_by_text = {}
    lemmas = []
    for i in range(0, len(texts)):
        lemmas_by_text[i] = m.lemmatize(texts[i])
        lemmas.extend(m.lemmatize(texts[i]))
    print('Lemmatazing finsished')

    lemmas = list(dict.fromkeys(lemmas))
    matrix = [[0 for x in range(len(lemmas_by_text) - 1)] for y in range(len(lemmas))]
    for i in range(0, len(lemmas)):
        for j in range(0, len(lemmas_by_text) - 1):
            try:
                matrix[i][j] = lemmas_by_text[j].count(lemmas[i]) / len(lemmas_by_text[j])
            except:
                matrix[i][j] = lemmas_by_text[j].count(lemmas[i]) / 1
    return render_template('boolean.html', matrix=matrix, lemmas=lemmas, length=(len(lemmas_by_text) - 1), title='tf_idf')


if __name__ == '__main__':
    app.run()
