<html>

<head>
    <link rel=stylesheet href='style.css' type='text/css'>
    <title>5 до 15</title>
</head>

<body>

    <div class="leftcol">
        <form method="POST" action="{{route('resumeStore')}}">
            <p>ФИО <input name="FIO" value="">
            <p>Телефон <input name="Phone" value="">
            <p>Фото <input name="Image" value="">
            <p>Профессия <input name="Staff" type="number" value="2">
            <p>Стаж <input name="Stage" type="">
            <p><button type="submit">Добавить резюме</button>
            {{csrf_field()}}
        </form>

    </div>

    <div class="rightcol">
        <!--*******************Навигационное меню*******************-->
        <ul class="menu">
            <li><a href="/stage">Фамилии персон, имеющих стаж от 5 до 15 лет.</a></li>
            <li><a href="/coders">Фамилии и стаж людей с профессией Программист</a></li>
            <li><a href="/amount">Общее число резюме в базе</a></li>
            <li><a href="/professions">Профессии, представители которых имеются в резюме</a></li>
            <li><a href="/add">Форма</a></li>
            <li><a href="/">Обратно</a></li>
        </ul>
    </div>
    <div class="footer">&copy; Copyright 2017</div>

</body>

</html>
