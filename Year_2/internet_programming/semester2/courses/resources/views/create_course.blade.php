<html>
    <head>
        <link rel="stylesheet" href="css/menu.css">
    </head>
    <body>
        <div class="all">
            <form method="post" action="{{route('create')}}" enctype="multipart/form-data">
                <p><label>Название курса:
                        <input type="text" name="name" required>
                    </label>
                </p>
                <p><label>Описание:
                        <textarea name="description" required></textarea>
                    </label>
                </p>
                <p><label>Дата начала:
                        <input type="datetime-local" name="time" value="2017-06-01T08:30" required>
                    </label>
                </p>
                <p><label>Число мест:
                        <input type="number" min="0" name="number" required>
                    </label>
                </p>
                <p><label>Изображение:
                        <input type="file" name="image">
                    </label>
                </p>
                <p><button type="submit">Добавить курс</button></p>
                {{ csrf_field() }}
            </form>
            <p><a href="{{route('menu')}}"><button type="submit">Вернуться в меню</button></a></p>
        </div>
    </body>
</html>
