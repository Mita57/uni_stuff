import csv
import os
import re

cols = ['Index', 'Title', 'Lid', 'Text', 'Ner', 'Language', 'URL', 'Date']
counter = 0
with open('result.csv', mode='w') as csv_file:
    writer = csv.writer(csv_file, delimiter='`')
    writer.writerow(cols)
    files = os.listdir('./news')
    for f in files:
        with open('./news/' + f) as file:
            lines = file.readlines()
            lines = [line for line in lines if line.strip()]
            index = counter
            counter += 1
            title = lines[0]
            lid = lines[1]

            text = ''
            for i in range(2, len(lines)):
                text += lines[i]

            ner = re.match(r'[.,?!] +[A-Z][А=Я]', text) or re.match(r'[.,?!] +[A-Z][А=Я]', title) or\
                  re.match(r'[.,?!] +[A-Z][А=Я]', lid) or False

            lang = 'ru' if bool(re.search('[а-яА-Я]', text)) else 'en'
            if lang == 'ru':
                if bool(re.search('[a-zA-Z]', text)):
                    lang = 'ru-en'
            regex = r"(?i)\b((?:https?://|www\d{0,3}[.]|[a-z0-9.\-]+[.][a-z]{2,4}/)(?:[^\s()<>]+|\(([^\s()<>]+|(\([^\s()<>]+\)))*\))+(?:\(([^\s()<>]+|(\([^\s()<>]+\)))*\)|[^\s`!()\[\]{};:'\".,<>?«»“”‘’]))"
            try:
                url = re.search(regex, text).group()
            except:
                url = None
            try:
                year = re.search(r'[1-3][0-9]{3}', text).group()
            except:
                year = 'None'

            result = [index, title, lid, text, ner, lang, url, year]
            writer.writerow(result)