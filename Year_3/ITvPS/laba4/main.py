from flask import Flask, request, jsonify, render_template
from flask_cors import CORS
import vsm
import similarity_measure

app = Flask(__name__)
cors = CORS(app)

@app.route('/', methods=['POST', 'GET'])
def index():
    if request.method == 'POST':
        return get_res(request)
    else:
        return render_template('index.html')


def get_res(request):
    query = [request.form['query']]
    path = request.files['fileUpload']
    print(path)
    docs = vsm.read_file(path)
    q_docs, q_dict = vsm.clear_text(query)
    d_docs, d_dict = vsm.clear_text(docs)

    tf_idf_q = vsm.compute_tf_idf1(q_docs, q_dict)
    tf_idf_d = vsm.compute_tf_idf1(d_docs, d_dict)
    cosine = similarity_measure.cosine(tf_idf_q, tf_idf_d)
    jaccard = similarity_measure.jaccard(tf_idf_q, tf_idf_d)
    dice = similarity_measure.dice(tf_idf_q, tf_idf_d)
    result = []
    for i in range(len(cosine)):
        result.append({
            'doc': i + 1,
            'cosine': cosine[i],
            'jaccard': jaccard[i],
            'dice': dice[i]
        })
    return render_template('result.html', res=result)

if __name__ == '__main__':
    app.run()

