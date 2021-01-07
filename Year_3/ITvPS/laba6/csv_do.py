import csv


def write_dict(info, f):
    with open(f, 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        for i, doc in info.items():
            str_r = [i] + doc
            a_pen.writerow(str_r)


def write_str(info, f):
    with open(f, 'w', encoding='utf-8') as file:
        for i in info:
            a_pen = csv.writer(file)
            a_pen.writerow(i)


def read_pwc():
    pwc = {}
    with open("pwc_2.csv") as f:
        reader = csv.DictReader(f, delimiter=',')
        for line in reader:
            pwc[line['word']] = [line["c1"], line['c2'], line['c3'], line['pwc1'], line['pwc2'], line['pwc3'], line['count_doc_cl1'], line['count_doc_cl2'], line['count_doc_cl3'], line['count_doc_len1'], line['count_doc_len2'], line['count_doc_len3']]
    return pwc

def write_pwc(pwc):
    with open("pwc_2.csv", 'w', encoding='utf-8') as file:
        a_pen = csv.writer(file)
        columns = ['word','c1','c2','c3','pwc1','pwc2','pwc3','count_doc_cl1','count_doc_cl2','count_doc_cl3','count_doc_len1','count_doc_len2','count_doc_len3']
        a_pen.writerow(columns)
        for token, i in pwc.items():
            str_r = [token] + i
            a_pen.writerow(str_r)

