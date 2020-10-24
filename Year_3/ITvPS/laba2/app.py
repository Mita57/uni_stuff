from flask import Flask, request, render_template
from pymystem3 import Mystem
from collections import Counter

app = Flask(__name__)


class Thing:
    def __init__(self, lemma, pos, count):
        self.lemma = lemma
        self.pos = pos
        self.count = count


@app.route('/', methods=['POST', 'GET'])
def hello_world():
    if request.method == 'POST':
        return post_process(request)
    else:
        return render_template('Index.html')


def post_process(request):
    content = request.form['text']
    m = Mystem()
    counts = (dict(Counter(m.lemmatize(content))))
    result = m.analyze(content)
    stuff = []
    for res in result:
        try:
            stuff.append(Thing(res['analysis'][0]['lex'], res['analysis'][0]['gr'].split('=')[0].split(',')[0],
                               counts[res['analysis'][0]['lex']]))
        except Exception:
            pass
    if request.form['sort'] == 'len':
        stuff.sort(key=lambda x: len(x.lemma))
    else:
        stuff.sort(key=lambda x: x.lemma)
    return render_template('Result.html', stuff=stuff)


if __name__ == '__main__':
    app.run()
