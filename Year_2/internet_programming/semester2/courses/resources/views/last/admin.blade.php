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

</header>

<!-- ######################## Section ######################## -->

<section>

    <div class="section_main">

        <div class="row">
            <section class="ten columns">

                @foreach($courses as $course)
                    <article class="blog_post">

                        <div class="three columns">
                            <a href="#" class="th"><img src="{{ asset('storage/'.$course->image) }}" alt="desc" /></a>
                        </div>

                        <div class="nine columns">
                            <a href="{{ route('course',['id'=>$course->id]) }}"><h4>{{ $course->name }}</h4></a>
                            <p>{{ $course->description }}</p>
                            @if($countMembers[$course->id] === 0)
                                <a href="{{ route('delete',['id'=>$course->id]) }}">Удалить</a>
                            @else
                                <p><strong>Есть записи на курс. Удаление невозможно</strong></p>
                                @endif
                        </div>
                    </article>
                @endforeach
            </section>
        </div>

        <div class="admin-panel">
            <h3>Админ-панель</h3>
            <button type="submit">
                <a href="{{route('add')}}">
                Добавить курс
                </a>
            </button>
        </div>
    </div>

</section>


<!-- ######################## Section ######################## -->

   <section>

      <div class="section_dark">
      <div class="row">

      <h2></h2>

          <div class="two columns">
          <img src="./images/thumb1.jpg" alt="desc" />
          </div>

          <div class="two columns">
          <img src="./images/thumb2.jpg" alt="desc" />
          </div>

          <div class="two columns">
          <img src="./images/thumb3.jpg" alt="desc" />
          </div>

          <div class="two columns">
          <img src="./images/thumb4.jpg" alt="desc" />
          </div>

          <div class="two columns">
          <img src="./images/thumb5.jpg" alt="desc" />
          </div>

          <div class="two columns">
          <img src="./images/thumb6.jpg" alt="desc" />
          </div>


      </div>
      </div>

    </section>


<!-- ######################## Footer ######################## -->

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
