def get_ending(amount):
    if int(amount[-1]) == 0 or int(amount[-1]) > 4:
        return number + ' рублей'
    if int(amount[-1]) == 1:
        return number + ' рубль'456
    return number + ' рубля'


while True:
    number = input('Entrez votre numéro')
    print(get_ending(number))
