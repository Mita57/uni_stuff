<html>

<head>
    <link rel=stylesheet href='style.css' type='text/css'>
    <title>Резюме и вакансии </title>
</head>

<body>

    <div class="header">
        <!--*****************Логотип и шапка********************-->
        {{$header}}
        <div id="logo"></div>
    </div>

    <div class="leftcol">
        @foreach ($people as $p)
            <div class="entry">
                <a href="/resume{{$p->id}}">
                    <img src="images/{{$p->Image}}" height="80px" style="float: right">
                    Фамилия: {{$p->FIO}}<br>
                    @foreach ($staff as $s)
                        @if ($p->Staff == $s->id)
                            Профессия: {{$s->staff}}<br>
                        @endif
                    @endforeach
                    Номер телефона: {{$p->Phone}}<br>
                    Стаж: {{$p->Stage}} лет<br>
                </a>
            </div>
        @endforeach

    </div>

    <div class="rightcol">
        <!--*******************Навигационное меню*******************-->
        <ul class="menu">
            <li><a href="">Вакансии</a></li>
            <li><a href="">Резюме по профессиям</a></li>
            <li><a href="">Резюме по возрасту</a></li>
            <li><a href="">Избранное резюме</a></li>
        </ul>
    </div>
    <div class="footer">&copy; Copyright 2017</div>

</body>

</html>
