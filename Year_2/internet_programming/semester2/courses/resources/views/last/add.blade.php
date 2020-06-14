<!DOCTYPE html>
<!--[if lt IE 7]> <html class="no-js lt-ie9 lt-ie8 lt-ie7" lang="en"> <![endif]-->
<!--[if IE 7]>    <html class="no-js lt-ie9 lt-ie8" lang="en"> <![endif]-->
<!--[if IE 8]>    <html class="no-js lt-ie9" lang="en"> <![endif]-->
<!--[if gt IE 8]><!--> <html class="no-js" lang="en"> <!--<![endif]-->

<head>

    <meta charset="utf-8" />
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width" />

    <title>Языковая школа LINGVO</title>

    <!-- Included CSS Files (Compressed) -->
    <link rel="stylesheet" href="./css/foundation.min.css">
    <link rel="stylesheet" href="./css/main.css">
    <link rel="stylesheet" href="./css/app.css">
    <script src="./js/modernizr.foundation.js"></script>
    <link rel="stylesheet" href="./fonts/ligature.css">

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

            <img  class="round"  src="{{$userObj->avatar ? asset('storage/'.$userObj->avatar): asset('storage/avatars/default.png')}}">

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
        <h1>Языковая школа LINGVO</h1>
    </div>
</header>

<!-- ######################## Section ######################## -->


<div class="add-form">
   <form method="post" action="{{route('post')}}" enctype="multipart/form-data">
       <p><label>Название курса:
               <input type="text" name="name">
           </label>
       </p>
       <p><label>Описание:
               <textarea name="description"></textarea>
           </label>
       </p>
       <p><label>Дата начала:
               <input type="datetime-local" name="time" value="2017-06-01T08:30">
           </label>
       </p>
       <p><label>Число мест:
               <input type="number" min="0" name="number">
           </label>
       </p>
       <p><label>Изображение:
               <input type="file" name="image">
           </label>
       </p>
       <p><button type="submit">Добавить курс</button></p>
       {{ csrf_field() }}
   </form>
</div>




<footer>

    <div class="row">

        <div class="twelve columns footer">
            <a href="" class="lsf-icon" style="font-size:16px; margin-right:15px" title="twitter">Twitter</a>
            <a href="" class="lsf-icon" style="font-size:16px; margin-right:15px" title="facebook">Facebook</a>
            <a href="" class="lsf-icon" style="font-size:16px; margin-right:15px" title="pinterest">Pinterest</a>
            <a href="" class="lsf-icon" style="font-size:16px" title="instagram">Instagram</a>
        </div>

    </div>

</footer>

<!-- ######################## Scripts ######################## -->

<!-- Included JS Files (Compressed) -->
<script src="./js/foundation.min.js" type="text/javascript"></script>
<!-- Initialize JS Plugins -->
<script src="./js/app.js" type="text/javascript"></script>
</body>
</html>

