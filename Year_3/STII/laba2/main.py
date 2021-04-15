class Symptom:
    def __init__(self, name, number, positive_flu, negative_flu, positive_poisoning, negative_poisoning):
        self.name = name
        self.number = number
        self.positive_poisoning = positive_poisoning
        self.negative_poisoning = negative_poisoning
        self.positive_flu = positive_flu
        self.negative_flu = negative_flu


symptoms = [Symptom('Высокая температура', 1, 0.9, 0.05, 0.05, 0.9),
            Symptom('Кашель', 3, 0.9, 0.1, 0.1, 0.9),
            Symptom('Боль в животе', 2, 0.01, 0.8, 0.8, 0.01),
            Symptom('Тошнота', 4, 0.05, 0.8, 0.8, 0.05),
            Symptom('Головная боль', 5, 0.8, 0.1, 0.1, 0.8)]

answers = []

p_poisoning = 0.01
p_flu = 0.01

for symptom in symptoms:
    answer = input(symptom.name)
    if answer.lower() == 'y':
        p_poisoning = symptom.positive_poisoning * p_poisoning\
                      / ((symptom.positive_poisoning * p_poisoning) + symptom.negative_poisoning * (1 - p_poisoning))
        p_flu = symptom.positive_flu * p_flu\
                      / ((symptom.positive_flu * p_flu) + symptom.negative_flu * (1 - p_flu))
    else:
        p_poisoning = symptom.negative_poisoning * p_poisoning \
                      / ((symptom.negative_poisoning * p_poisoning) + symptom.positive_poisoning * (1 - p_poisoning))
        p_flu = symptom.negative_flu * p_flu \
                / ((symptom.negative_flu * p_flu) + symptom.positive_flu * (1 - p_flu))
    answers.append(symptom.name + ' ' + str(p_flu) + ' ' + str(p_poisoning))

for answer in answers:
    print(answer)