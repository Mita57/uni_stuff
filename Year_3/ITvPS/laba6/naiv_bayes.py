import vsm
import math
import csv_do


def get_docs(short_path):
    docs = []
    for i in range(1, 4):
        doc = ""
        for j in range(1, 4):
            path = short_path+'C' + str(i) + "_" + str(j) + ".txt"
            doc += vsm.read_file(path)
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
        pwc_dict[token] = p[5:]
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


def add_prob(text, text_class):
    class_num = int(text_class)
    pwc = csv_do.read_pwc()
    my_doc, my_dict = vsm.clear_one_text(text)
    count = len(text)
    tf = vsm.compute_tf([my_doc], my_dict)
    for token, i in tf.items():
        if token in pwc:
            if class_num == 1:
                pwc[token][0] = int(pwc[token][0]) + int(tf[token][0])
                pwc[token][6] = int(pwc[token][6])+1
                pwc[token][9] = int(pwc[token][9])+count
                pwc[token][3] = (int(pwc[token][0])+1)/(int(pwc[token][9])+len(pwc))
            elif class_num == 2:
                pwc[token][1] = int(pwc[token][1]) + int(tf[token][0])
                pwc[token][7] = int(pwc[token][7])+1
                pwc[token][10] = int(pwc[token][10]) + count
                pwc[token][4] = (int(pwc[token][1]) + 1) / (int(pwc[token][10]) + len(pwc))
            elif class_num == 3:
                pwc[token][2] = int(pwc[token][2]) + int(tf[token][0])
                pwc[token][8] = int(pwc[token][8])+1
                pwc[token][11] = int(pwc[token][11]) + count
                pwc[token][5] = (int(pwc[token][2]) + 1) / (int(pwc[token][11]) + len(pwc))
        else:
            pwc[token] = [0 for i in range(12)]
            if class_num == 1:
                pwc[token][0] = tf[token][0]
                pwc[token][6] = 1
                pwc[token][9] = count

            elif class_num == 2:
                pwc[token][1] = tf[token][0]
                pwc[token][7] = 1
                pwc[token][10] = count

            elif class_num == 3:
                pwc[token][2] = tf[token][0]
                pwc[token][8] = 1
                pwc[token][11] = count

            pwc[token][3] = (int(pwc[token][0]) + 1) / (int(pwc[token][9]) + len(pwc))
            pwc[token][4] = (int(pwc[token][1]) + 1) / (int(pwc[token][10]) + len(pwc))
            pwc[token][5] = (int(pwc[token][2]) + 1) / (int(pwc[token][11]) + len(pwc))
    return pwc
