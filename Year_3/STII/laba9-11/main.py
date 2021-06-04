import re
from pymystem3 import Mystem


def create_tree(node_list_arg):
    memes = node_list_arg
    print(memes)
    nodes = list(node_list_arg[-1].values())
    keys = list(node_list_arg[-1].keys())
    flag = False
    s_we_can = True
    for i in range(len(nodes)):
        if nodes[i] == 'N':
            nodes[i] = 'NP'
            s_we_can = False
            flag = True
        if nodes[i] == 'PP':
            nodes[i] = 'NP'
            s_we_can = False
            flag = True
        if nodes[i] == 'NP':
            for j in range(i + 1, len(nodes)):
                if nodes[j] is not None:
                    if nodes[j] == 'NP':
                        nodes[j] = None
                        flag = True
                    if nodes[j] == 'VP':
                        nodes[j] = None
                        nodes[i] = 'S'
                        flag = True
                    break
        if nodes[i] == 'A':
            for j in range(i + 1, len(nodes)):
                if nodes[j] is not None:
                    if nodes[j] == 'NP':
                        nodes[i] = 'NP'
                        nodes[j] = None
                        flag = True
                    break
        if nodes[i] == 'P':
            for j in range(i + 1, len(nodes)):
                if nodes[j] is not None:
                    if nodes[j] == 'NP':
                        nodes[i] = 'PP'
                        nodes[j] = None
                        flag = True
                    break
        if nodes[i] == 'V':
            for j in range(i + 1, len(nodes)):
                if nodes[j] is not None:
                    if nodes[j] == 'V':
                        nodes[i] = 'VP'
                        nodes[j] = None
                        s_we_can = False
                        flag = True
                    if nodes[j] == 'NP':
                        nodes[i] = 'VP'
                        s_we_can = False
                        nodes[j] = None
                        flag = True
                    if nodes[j] == 'D':
                        nodes[i] = 'VP'
                        s_we_can = False
                        nodes[j] = None
                        flag = True
                    break
        if nodes[i] == 'D':
            for j in range(i + 1, len(nodes)):
                if nodes[j] is not None:
                    if nodes[j] == 'VP':
                        nodes[i] = 'VP'
                        s_we_can = False
                        nodes[j] = None
                        flag = True
                    if nodes[j] == 'V':
                        nodes[i] = 'VP'
                        s_we_can = False
                        nodes[j] = None
                        flag = True
                    break
        if nodes[i] == 'VP':
            for j in range(i + 1, len(nodes)):
                if nodes[j] is not None:
                    if nodes[j] == 'NP':
                        s_we_can = False
                        nodes[j] = None
                        flag = True
                break
            if s_we_can:
                nodes[i] = 'S'

    dic = {}
    for i in range(len(keys)):
        dic[keys[i]] = nodes[i]

    if flag:
        memes.append(dic)
        print(memes)
        create_tree(memes)
    else:
        return memes


m = Mystem()

text = input('Entrez le text s\'il vous plait')
senteces = text.split('? | . | ! ')

senteces_dic = {}
for i in range(0, len(senteces)):
    senteces_dic[i] = senteces[i]

for i in senteces_dic:
    word_part = {}
    analysis = m.analyze(senteces_dic[i])
    for a in analysis:
        try:
            word_part[a['text']] = a['analysis'][0]['gr'].replace('=', ',').split(',')[0].replace('S', 'N')\
                .replace('CONJ', 'P').replace('PR', 'P').replace('APO', 'A')
        except:
            pass

    print(create_tree([word_part]))