<!DOCTYPE html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js" lang="en"> <!--<![endif]-->

<head>

    <meta charset="utf-8" />
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width" />

    <title>ЛАНГУАГЕС</title>

    <!-- Included CSS Files (Compressed) -->
    <link rel="stylesheet" href="../../css/foundation.min.css">
    <link rel="stylesheet" href="../../css/main.css">
    <link rel="stylesheet" href="../../css/app.css">
    <script src="../../js/modernizr.foundation.js"></script>
    <link rel="stylesheet" href="../../fonts/ligature.css">

    <!-- Google fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans+Condensed:300|Playfair+Display:400italic' rel='stylesheet' type='text/css' />

    <!-- IE Fix for HTML5 Tags -->
    <!--[if lt IE 9]>
    <script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

</head>

<body>

<!-- ######################## Main Menu ######################## -->

<nav>

    <div class="twelve columns header_nav">
        <div class="row">
            <ul id="menu-header" class="nav-bar horizontal">
                <li></li>
            </ul>

            <a href="{{route('userCourses',['id'=>$userId])}}">
                <img  class="round"  src="{{$userObj->avatar ? asset('storage/'.$userObj->avatar):
                asset('storage/avatars/default.png')}}">
            </a>
            <a class="buttonStyle" style="color:#222; font-size: 16px;" ref="{{ route('logout') }}"
               onclick="event.preventDefault();
                                                         document.getElementById('logout-form').submit();">
                {{ strtoupper(__('Logout') )}}
            </a>

            <label class="loginStyle">{{$user}} (Администратор)</label>

            <form id="logout-form" action="{{ route('logout') }}" method="POST">
                @csrf
            </form>

            <script type="text/javascript">
                //<![CDATA[
                $('ul#menu-header').nav-bar();
                //]]>
            </script>

        </div>
    </div>

</nav><!-- END main menu -->

<!-- ######################## Header (featured posts) ######################## -->

<header>
    <div class="row">
        <h1>Запись на курс {{$courseName}}</h1>
    </div>
</header>

<!-- ######################## Section ######################## -->


<div class="add-form">
    <form method="post" action="{{route('postEnroll',['courseId'=>$courseId,'courseName'=>$courseName])}}">
        <p><label>Город:
                <input type="text" name="town">
            </label>
        </p>
        <p><label>Номер телефона:
                <input type="number" name="phone">
            </label>
        </p>
        <p><label>Номер карты:
                <input type="number" name="card_number">
            </label>
        </p>
        <p><label>Срок:
                <input type="number" min="1" max="12" name="card_time_limit_1">/<input type="number" name="card_time_limit_2">
            </label>
        </p>
        <p><label>Код CVC/CVV:
                <input type="number" name="card_code">
            </label>
        </p>
        <p><button type="submit">Записаться</button></p>
        {{ csrf_field() }}
    </form>
</div>



<!-- ######################## Scripts ######################## -->

<!-- Included JS Files (Compressed) -->
<script src="../../js/foundation.min.js" type="text/javascript"></script>
<!-- Initialize JS Plugins -->
<script src="../../js/app.js" type="text/javascript"></script>
</body>
</html>

