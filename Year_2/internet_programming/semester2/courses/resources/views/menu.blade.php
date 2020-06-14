<html>
    <head>
        <link rel="stylesheet" href="css/menu.css">
    </head>
    <body>
        <div class="all">
            <div>
                <form method="get" action="{{route('open_get')}}" enctype="multipart/form-data">
                    <p><button type="submit">Искать курс</button></p>
                    {{ csrf_field() }}
                </form>
            </div>
            <div>
                <form method="get" action="{{route('open_create')}}" enctype="multipart/form-data">
                    <p><button type="submit">Добавить курс</button></p>
                    {{ csrf_field() }}
                </form>
            </div>
            <div>
                <form method="get" action="{{route('open_delete')}}" enctype="multipart/form-data">
                    <p><button type="submit">Удалить курс</button></p>
                    {{ csrf_field() }}
                </form>
            </div>
            <div>
                <div>
                    <form method="get" action="{{route('open_update')}}" enctype="multipart/form-data">
                        <p><label>ID: <input type="number" name="id" min="0"></label></p>
                        <p><button type="submit">Изменить курс</button></p>
                        {{ csrf_field() }}
                    </form>
                </div>
            </div>
        </div>
    </body>
</html>
