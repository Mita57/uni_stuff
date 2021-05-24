import re
from pyprover import *


def prepare_sentence(sentence):
    return sentence.lower().replace(',', '')


def get_tokens(statements):
    elems = re.split('(если |то | и |или |либо |, |\.)', statements)
    elems = [s.strip() for s in elems]
    elems = list(filter(None, elems))
    return elems


def get_elem_statements(tokens):
    garbage = ['если', 'то', 'и', 'или', 'либо']
    key = 'A'
    dic = {}
    for tok in tokens:
        if tok not in garbage and tok.replace('не', '') not in dic.keys():
            dic[tok.replace('не', '')] = key
            key = chr((ord(key)+1 - 65) % 26 + 65)
    return dic


def get_formula(tokens, elem_statements):
    formula = ''
    operators = {
        'если': '',
        'то': '->',
        'и': '/\\',
        'или': '\\/',
        'либо': '|',
        '. ': ', ',
        '.': ', '
    }
    for tok in tokens:
        if tok in operators.keys():
            formula += operators[tok]
        else:
            if 'не' in tok:
                formula += '-'
            formula += elem_statements[tok.replace('не', '').strip()]
    if formula[0] == '|':
        formula = formula[1:]
    return formula.replace('->|', '->').strip()[:-1]


statements = input('Enter the statement')
conclusion = input('Enter the conclusion')

statements, conclusion = prepare_sentence(statements), prepare_sentence(conclusion)
tokens = get_tokens(statements)
elem_statements = get_elem_statements(tokens)
statements_formula = get_formula(tokens, elem_statements)

tokens = get_tokens(conclusion)
conclusion_formula = get_formula(tokens, elem_statements)

print(statements_formula)

statements_formula_parts = statements_formula.split(',')

cum = []

for fuck in statements_formula_parts:
    cum.append(expr(fuck))

print(conclusion_formula)

print(proves(cum, expr(conclusion_formula)))


