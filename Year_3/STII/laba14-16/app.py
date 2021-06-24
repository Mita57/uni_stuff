import math

from natasha import *


class Sentense:
    words = []
    question = None


class Question:
    word = None
    qType = None
    mainWords = []


class QAClass(object):

    def __init__(self):
        d = 0

    @staticmethod
    def pre_work_doc(text):
        segmenter = Segmenter()
        morph_vocab = MorphVocab()
        emb = NewsEmbedding()
        morph_tagger = NewsMorphTagger(emb)
        syntax_parser = NewsSyntaxParser(emb)
        doc = Doc(text)
        doc.segment(segmenter)
        doc.parse_syntax(syntax_parser)
        doc.tag_morph(morph_tagger)

        for token in doc.tokens:
            token.lemmatize(morph_vocab)
        return doc

    @staticmethod
    def find_question_node(tokens):
        res = Question()
        head = []
        has_verb = False

        for token in tokens:
            if token.rel == 'root':
                head.append(token)
            if token.pos == 'VERB':
                has_verb = True
            if token.pos == 'DET':
                res.qType = token
                for rel in tokens:
                    if rel.id == token.head_id and token.rel != 'case' and token.rel != 'det':
                        res.word = rel
        br = False

        if not has_verb and len(head) > 0 and res.word is None:
            for token in tokens:
                if br:
                    break
                if token.head_id == head[0].id and token.rel != 'case':
                    for tokenD in tokens:
                        if br:
                            break
                        if tokenD.head_id == token.id and tokenD.rel != 'case' and tokenD.rel != 'det' and tokenD.lemma != \
                                head[0].lemma:
                            res.word = tokenD
                            br = True

        for token in tokens:
            if token.rel == 'nsubj':
                head.append(token)

        if res.word is None and len(head) > 0:
            res.word = head[0]

        res.mainWords = head
        return res

    def find_cos_between(self, sent, question_doc):
        cos_in = 0
        left = []
        right = []
        word_dict = []

        for t in question_doc.sents[0].tokens:
            word_dict.append(t.lemma)
        word_dict = list(set(word_dict))

        for w in word_dict:
            left.append(0)
            right.append(0)

        for token in sent.tokens:
            if token.lemma in word_dict:
                left[word_dict.index(token.lemma)] += 1

        for token in question_doc.sents[0].tokens:
            if token.lemma in word_dict:
                right[word_dict.index(token.lemma)] += 1
        up = 0
        down_left = 0
        down_right = 0

        for index in range(0, len(left)):
            up += left[index] * right[index]
            down_left += left[index] * left[index]
            down_right += right[index] * right[index]

        try:
            cos_in = up / (math.sqrt(down_left) * math.sqrt(down_right))
        except:
            d = 0

        return cos_in

    def go_down(self, sent, parent, not_i=None):
        childs = []
        for token in sent.tokens:
            if token.head_id == parent.id and token.rel != 'case' and token.rel != 'punct':
                if not_i is not None and token.id != not_i.id or not_i is None:
                    childs.append(token)
                    childs += self.go_down(sent, token)
        childs.reverse()
        return childs

    def find_children(self, sent, question):
        for token in sent.tokens:
            if question.word.lemma == token.lemma:
                main_node = sent.tokens[0]
        end = False
        last = None
        while not end:
            for t in sent.tokens:
                if t.id == main_node.head_id:
                    if t.pos == 'NOUN':
                        last = main_node
                        main_node = t
                    else:
                        if t.pos == 'VERB':
                            last = main_node
                            main_node = t
                        end = True
        result = self.go_down(sent, main_node, last)
        if result is None:
            result = [question.word]
        return result

    def get_answer(self, question_doc):
        question = self.find_question_node(question_doc.sents[0].tokens)

        sents_str = open('texts/CodeIgniter.txt', 'r').read()
        sents_str = sents_str + open('texts/Laravel.txt', 'r').read()
        sents_str = sents_str + open('texts/mvc.txt', 'r').read()
        sents_str = sents_str + open('texts/Symfony.txt', 'r').read()
        sents_str = sents_str + open('texts/Yii.txt', 'r').read()
        sents_str = sents_str + open('texts/Zend.txt', 'r').read()

        sents = A.pre_work_doc(sents_str).sents

        sup_memory = []
        res = None

        for sent in sents:
            cs = self.find_cos_between(sent, question_doc)
            sup_memory.append({'sent': sent, 'cos': cs})
        filtered_memory = []

        for sM in sup_memory:
            if sM['cos'] > 0.5:
                filtered_memory.append(sM)

        br = False

        for fM in filtered_memory:
            if br:
                break
            for token in fM['sent'].tokens:
                if br:
                    break
                for word in question.mainWords:
                    if word.lemma == token.lemma:
                        res = fM['sent']
                        br = True
                        break

        if res is not None:
            answer = self.find_children(res, question)
            an = ''
            for ans in answer:
                an += ans.lemma + ' '
            return an
        return res


A = QAClass()
qstn = input('Entrez votre question')
doc_quests = A.pre_work_doc(qstn)

print('Ответ: ' + A.get_answer(doc_quests))
