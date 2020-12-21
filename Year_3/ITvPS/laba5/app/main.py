import vsm
import csv_stuff
import naiv_bayes

docs = naiv_bayes.get_docs('C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba5/la-bas5/train/')
my_docs, V = vsm.clear_text(docs)
p_w_c, p_w_c_dict = naiv_bayes.probability(my_docs, V)

csv_stuff.write_str(p_w_c, "pwc.csv")

for i in range(1, 4):
    path = 'C:/Users/57thr/Documents/GitHub/uni_stuff/Year_3/ITvPS/laba5/la-bas5/test/unknown' + str(i) + ".txt"
    test_doc = vsm.read_file(path)
    clear_test_doc, test_dict = vsm.clear_one_text(test_doc)
    cl1, cl2, cl3 = naiv_bayes.prob_doc(clear_test_doc, p_w_c_dict)
    my_max = max(cl1, cl2, cl3)

    if my_max == cl1:
        res = 'Класс 1'
    elif my_max == cl2:
        res = 'Класс 2'
    else:
        res = 'Класс 3'

    print('Файл ' + str(i) + ': Класс 1: ' + str(cl1) + ' Класс 2:' + str(cl2) + ' Класс 3: ' + str(cl3) + ' Результат: ' + str(res))
