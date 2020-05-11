<html>
<head>
    <link rel=stylesheet href='style.css' type='text/css'>
    <title>Резюме и вакансии </title></head>
<body>

    <div class="header"><!--*****************Логотип и шапка********************-->
        Резюме и вакансии
        <div id="logo"></div>
    </div>
    <div class="leftcol"><!--**************Основное содержание страницы************-->
        Имя: {{$data[0][0]->FIO}}<br>
        @foreach ($data[1] as $s)
            @if ($data[0][0]->Staff == $s->id)
                Профессия: {{$s->staff}}<br>
            @endif
        @endforeach
        Номер телефона: {{$data[0][0]->Phone}}<br>
        <img src="images/{{$data[0][0]->Image}}" style="height: 200px; float: right">
    </div>

    <div class="rightcol"><!--*******************Навигационное меню*******************-->
        <ul class="menu">
            <li><a href="/">Вакансии</a></li>
            <li><a href="">Резюме по профессиям</a></li>
            <li><a href="">Избранное резюме</a></li>
        </ul>
    </div>
    <div class="footer">&copy; Copyright 2017</div>

</body>
</html>
