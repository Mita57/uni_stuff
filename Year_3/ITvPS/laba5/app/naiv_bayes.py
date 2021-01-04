import vsm
import math


def get_docs(path):
    docs = []
    for i in range(1, 4):
        doc = ""
        for j in range(1, 4):
            path_final = path+'C' + str(i) + "_" + str(j) + ".txt"
            doc += vsm.read_file(path_final)
        docs.append(doc)
    return docs


def probability(my_docs, V):
    count = [len(words) for words in my_docs]
    tf = vsm.compute_tf(my_docs, V)
    result = []
    pwc_dict = {}
    for token in V:
        p = []
        p.append(token)
        for i in tf[token]:
            p.append(i)
        for i in range(len(tf[token])):
            p.append((tf[token][i]+1)/(count[i]+len(V)))
        pwc_dict[token] = p[4:]
        result.append(p)
    return result, pwc_dict


def prob_doc(test_doc, p_w_c_dict, n1=1/3, n2=1/3, n3=1/3):
    cl1 = math.log2(n1)
    cl2 = math.log2(n2)
    cl3 = math.log2(n3)
    for i in test_doc:
        if i in p_w_c_dict:
            cl1 += math.log2(float(p_w_c_dict[i][0]))
            cl2 += math.log2(float(p_w_c_dict[i][1]))
            cl3 += math.log2(float(p_w_c_dict[i][2]))
    return cl1, cl2, cl3
