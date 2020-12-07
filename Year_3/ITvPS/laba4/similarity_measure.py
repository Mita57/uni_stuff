import math
import operator

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


def jaccard(tf_idf_1, tf_idf_2):

    def sim_jaccard(v1, v2):
        res_min = 0
        res_max = 0
        for i in range(len(v1)):
            res_min += min(v1[i], v2[i])
            res_max += max(v1[i], v2[i])
        return res_min / res_max

    vec1 = [i[0] for i in tf_idf_1.values()]
    vec2 = [i for i in tf_idf_2.values()]
    res = []
    for vec in tf_idf_2.values():
        for i in range(len(vec)):
            cur = [z[i] for z in vec2]
            res.append(sim_jaccard(vec1, cur))
        break
    return res


def dice(tf_idf_1, tf_idf_2):
    def sim_dice(v1, v2):
        res_sum = sum(map(operator.add, v1, v2))
        res_min = 0
        for i in range(len(v1)):
            res_min += min(v1[i], v2[i])
        return 2 * res_min / res_sum

    vec1 = [i[0] for i in tf_idf_1.values()]
    vec2 = [i for i in tf_idf_2.values()]
    res = []
    for vec in tf_idf_2.values():
        for i in range(len(vec)):
            cur = [z[i] for z in vec2]
            res.append(sim_dice(vec1, cur))
        break
    return res

# query = ["Знаменитый ученый Стивен Хокинг рассказал в интервью ТАСС о будущем человечества на Марсе. По мнению физика-теоретика, колонизация Марса состоится в ближайшие 100 лет."]
# path = '/Applications/MAMP/htdocs/SEMESTR_5/ВЕБ/ВЕБ_3/лаба_3/dataset.txt'
# docs = vsm.read_file(path)
#
# my_docs_q, my_dict_q = vsm.clear_text(query)
# my_docs_d, my_dict_d = vsm.clear_text(docs)
#
# tf_idf_q = vsm.compute_tf_idf1(my_docs_q, my_dict_q)
# tf_idf_d = vsm.compute_tf_idf1(my_docs_d, my_dict_d)
#
# res1,re2,res3 = vsm.vsm(my_docs_d,my_dict_d)
#
# print(re2)
# print("-------------")
# print(tf_idf_d)
# cosine = cosine(tf_idf_q, tf_idf_d)
# jaccard = jaccard(tf_idf_q, tf_idf_d)
# dice = dice(tf_idf_q, tf_idf_d)
# print(cosine)
# print(jaccard)
# print(dice)