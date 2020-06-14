<html>
    <head>
        <link rel="stylesheet" href="css/menu.css">
    </head>
    <body>
        <div class="all">
            <form method="post" action="{{route('update',['id'=>$course['id']])}}" enctype="multipart/form-data">
                <p><label>Id Курса: {{$course['id']}}</label></p>
                <p><label>Название курса:
                        <input type="text" name="name" value="{{$course['name']}}" required>
                    </label>
                </p>

                <p><label>Описание:
                        <textarea name="description" required>{{$course['description']}}</textarea>
                    </label>
                </p>
                <p><label>Дата начала:
                        <input type="datetime-local" name="time" value="{{$course['time']}}" required>
                    </label>
                </p>
                <p><label>Число мест:
                        <input type="number" min="0" name="number" value="{{$course['number']}}" required>
                    </label>
                </p>
                <p><label>Изображение:
                        <input type="file" name="image">
                    </label>
                </p>
                <p><button type="submit">ИЗМЕНИТЬ КУРС</button></p>
                {{method_field('PUT')}}
                {{ csrf_field() }}
            </form>
            <p><a href="{{route('menu')}}"><button type="submit">Вернуться в меню</button></a></p>
        </div>
    </body>
</html>
