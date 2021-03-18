from flask import Flask, request, jsonify, render_template
from flask_cors import CORS
import vsm
import similarity_measure

def get_res():
    q_docs, q_dict = vsm.clear_text('Сколько волка ни корми – он ест и ест')
    d_docs, d_dict = vsm.clear_text('Сколько волка ни корми – в лес смотрит')

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
    print(result)

get_res()
