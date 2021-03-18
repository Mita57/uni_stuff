import vsm
import csv
import math


def get_docs(file_csv):
    text = {}
    with open(file_csv) as f:
        reader = csv.DictReader(f, delimiter=';')
        for line in reader:
            if line['class'] in text:
                text[line['class']].append([line["\ufefftitle"], line['keywords'], line['annotation']])
            else:
                text[line['class']] = [line["\ufefftitle"], line['keywords'], line['annotation']]
    docs = []
    for doc in text.values():
        str = ""
        for i in doc:
            str += ''.join(i)
        docs.append(str)
    return docs



def prob_doc(test_doc, p_w_c_dict):
    cl1 = math.log2(1 / 4)
    cl2 = math.log2(1 / 4)
    cl3 = math.log2(1 / 4)
    cl4 = math.log2(1 / 4)
    for i in test_doc:
        if i in p_w_c_dict:
            cl1 += math.log2(float(p_w_c_dict[i][0]))
            cl2 += math.log2(float(p_w_c_dict[i][1]))
            cl3 += math.log2(float(p_w_c_dict[i][2]))
            cl4 += math.log2(float(p_w_c_dict[i][3]))
    return {1: cl1, 2: cl2, 3: cl3, 4: cl4}


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
            p.append((tf[token][i] + 1) / (count[i] + len(V)))
        pwc_dict[token] = p[5:]
        result.append(p)
    return result, pwc_dict


docs = get_docs("train.csv")
my_docs, V = vsm.clear_text(docs)
p_w_c, p_w_c_dict = probability(my_docs, V)


def get_key(d, value):
    for k, v in d.items():
        if v == value:
            return k


def read_statistics():
    text = {}
    with open("statistics.csv") as f:
        reader = csv.DictReader(f, delimiter=',')
        for line in reader:
            text[line['number']] = [line["TP"], line['FP'], line['FN']]
    return text


def write_stats(stats):
    with open("statistics.csv", 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        columns = ['number', 'TP', 'FP', 'FN']
        a_pen.writerow(columns)
        for token, i in stats.items():
            str_r = [token] + i
            a_pen.writerow(str_r)


# LET THE FUN BEGIN
x = 1
text = open("test.csv", "r").readlines()
for star in text:
    print("Текст " + str(x) + "===============================================================")
    x = x + 1
    class_number = star[-2]
    print(class_number)
    star = star[:-1]
    clear_test_doc, test_dict = vsm.clear_one_text(star)
    cl = prob_doc(clear_test_doc, p_w_c_dict)
    sort = sorted(cl.values(), reverse=True)
    res = {}

    for i in sort:
        res[get_key(cl, i)] = i
    cl_number = get_key(cl, sort[0])
    stats = read_statistics()

    if int(cl_number) == int(class_number):
        stats[str(cl_number)][0] = int(stats[str(cl_number)][0]) + 1
    else:
        stats[str(cl_number)][1] = int(stats[str(cl_number)][1]) + 1
        stats[str(class_number)][2] = int(stats[str(class_number)][2]) + 1

    write_stats(stats)
    for i, j in res.items():
        if i == 1:
            print('Рубрика "Classification problems": ' + str(j) + '\n')
        elif i == 2:
            print('Рубрика "Pattern recognition": ' + str(j) + '\n')
        elif i == 3:
            print('Рубрика "Biometrics investigations": ' + str(j) + '\n')
        elif i == 4:
            print('Рубрика "Image processing": ' + str(j) + '\n')
        print("================================================================")

t = {}
with open("statistics.csv") as f:
    reader = csv.DictReader(f, delimiter=',')
    for line in reader:
        t[line['number']] = [line['TP'], line['FP'], line['FN']]
res = []
for n, i in t.items():
    if int(i[0]) != 0:
        p = int(i[0]) / (int(i[0]) * int(i[1]))
        r = int(i[0]) / (int(i[0]) * int(i[2]))
        f1 = 2 * p * r / (p + r)
        res.append({'№': n, 'P': p, 'R': r, 'F1': f1})
    else:
        res.append({'№': n, 'P': 0, 'R': 0, 'F1': 0})
print(res)