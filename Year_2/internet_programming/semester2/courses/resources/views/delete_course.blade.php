<html>
    <head>
        <link rel="stylesheet" href="css/menu.css">
    </head>
    <body>
        <div class="all">
            <form method="post" action="{{route('delete')}}" enctype="multipart/form-data">
                <p><label>ID: <input type="number" name="id" min="0" required></label></p>
                <p><button type="submit">Удалить курс</button></p>
                {{method_field('DELETE')}}
                {{ csrf_field() }}
            </form>
            <p><a href="{{route('menu')}}"><button type="submit">Вернуться в меню</button></a></p>
        </div>
    </body>
</html>
