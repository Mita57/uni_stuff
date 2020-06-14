<html>
    <head>
        <link rel="stylesheet" href="css/menu.css">
    </head>
    <body>
        <div class="all">
            <form method="post" action="{{route('get')}}">
                <label for="id">ID:</label>
                    <input id="courseId" type="text" name="id" required/>
                <p><button type="submit">Найти курс</button></p>
                {{ csrf_field() }}
            </form>
            <p><a href="{{route('menu')}}"><button type="submit">Вернуться в меню</button></a></p>
        </div>
    </body>
</html>
