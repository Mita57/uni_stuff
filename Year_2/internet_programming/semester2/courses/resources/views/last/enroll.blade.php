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
        <div class="form-group row">
            <label for="town" class="col-md-4 col-form-label text-md-right">{{ __('Город') }}:</label>

            <div class="col-md-6">
                <input id="town" type="town" class="form-control @error('town') is-invalid @enderror" name="town" value="{{ old('town') }}" required autocomplete="town">

                @error('town')
                <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                @enderror
            </div>
        </div>

        <div class="form-group row">
            <label for="phone" class="col-md-4 col-form-label text-md-right">{{ __('Телефон') }}:</label>

            <div class="col-md-6">
                <input id="phone" type="text" class="form-control @error('phone') is-invalid @enderror" name="phone" value="{{ old('phone') }}" required autocomplete="phone">

                @error('phone')
                <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                @enderror
            </div>
        </div>
        <div class="form-group row">
            <label for="card_number" class="col-md-4 col-form-label text-md-right">{{ __('Номер карты') }}:</label>

            <div class="col-md-6">
                <input id="card_number" type="text" class="form-control @error('card_number') is-invalid @enderror" name="card_number" value="{{ old('card_number') }}" required autocomplete="card_number">

                @error('card_number')
                <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                @enderror
            </div>
        </div>
        <div class="form-group row">
            <label for="card_time_limit" class="col-md-4 col-form-label text-md-right">{{ __('Срок') }}:</label>

            <div class="col-md-6">
                <input id="card_time_limit_1" type="number" class="form-control @error('card_time_limit_1') is-invalid @enderror" name="card_time_limit_1" value="{{ old('card_time_limit_1') }}" required autocomplete="card_time_limit_1">

                @error('card_time_limit_1')
                <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                @enderror
                <label>/</label>
                <input id="card_time_limit_1" type="number" class="form-control @error('card_time_limit_2') is-invalid @enderror" name="card_time_limit_2" value="{{ old('card_time_limit_2') }}" required autocomplete="card_time_limit_2">

                @error('card_time_limit_2')
                <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                @enderror
            </div>
        </div>

        <div class="form-group row">
            <label for="ard_code" class="col-md-4 col-form-label text-md-right">{{ __('Код CVC/CVV') }}:</label>

            <div class="col-md-6">
                <input id="card_code" type="text" class="form-control @error('card_code') is-invalid @enderror" name="card_code" value="{{ old('card_code') }}" required autocomplete="card_code">

                @error('card_code')
                <span class="invalid-feedback" role="alert">
                                        <strong>{{ $message }}</strong>
                                    </span>
                @enderror
            </div>
        </div>
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

