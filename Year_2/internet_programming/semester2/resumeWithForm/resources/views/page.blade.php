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
            <li><a href="/stage">Фамилии персон, имеющих стаж от 5 до 15 лет.</a></li>
            <li><a href="/coders">Фамилии и стаж людей с профессией Программист</a></li>
            <li><a href="/amount">Общее число резюме в базе</a></li>
            <li><a href="/professions">Профессии, представители которых имеются в резюме</a></li>
            <li><a href="/add">Форма</a></li>
        </ul>
    </div>
    <div class="footer">&copy; Copyright 2017</div>

</body>

</html>
