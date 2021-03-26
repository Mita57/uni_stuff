class Plant:
    def __init__(self, name, life_form, leaf_colour, leaf_shape, surface, leaf_size, blossom_size):
        self.name = name
        self.life_form = life_form
        self.leaf_colour = leaf_colour
        self.leaf_shape = leaf_shape
        self.surface = surface
        self.life_size = leaf_size
        self.blossom_size = blossom_size


plants = [Plant('Криптантус', 'Травянистое', 'Зеленая', 'Ремневидная', 'Обычная', '10-15 см', '1-5 см'),
          Plant('Сансеверия', 'Травянистое', 'Зеленая', 'Ремневидная', 'Обычная', '15-30 см', '	1-5 см'),
          Plant('Марранта', 'Травянистое', 'Пестрая', 'Овальная', 'Опушенная', '5-10 см', '1-5 см'),
          Plant('Гемантус', 'Луковичное', 'Зеленая', 'Линейная', 'Опушенная', '15-30 см', '5-10 см'),
          Plant('Эухарис', 'Луковичное', 'Зеленая', 'Ланцетная', 'Складчатая', '15-30 см', '5-10 см'),
          Plant('Лахеналия', 'Луковичное', 'Пестрая', 'Ланцетная', 'Обычная', '15-30 см', '5-10 см'),
          Plant('Хамеропс', 'Пальма', 'Зеленая', 'Ланцетная', 'Обычная', '15-30 см', '0-1 см'),
          Plant('Птерис', 'Пальма', 'Пестрая', 'Ланцетная', 'Складчатая', '5-10 см', '0-1 см')]

query_color = ['Зеленая'] if input('Окраска листа Зеленая?').upper() == 'Y' else ['Пестрая']
query_leaf_shape = ['Ланцентная'] if input('Ланцетная?').upper() == 'Y' else ['Овальная', 'Линейная', 'Ременвидная']
query_surface = ['Обычная'] if input('Поверхность обычная?').upper() == 'Y' else ['Складчатая', 'Опушенная']

for pl in plants:
    if pl.leaf_colour in query_color and pl.leaf_shape in query_leaf_shape and pl.surface in query_surface:
        print(pl.name)
        break
