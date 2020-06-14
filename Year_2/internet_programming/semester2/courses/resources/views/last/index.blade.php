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
                <li style="font-size: 18pt; padding: 5px;">Языковая школа LINGVO</li>
            </ul>

             <a href="{{route('userCourses',['id'=>$userId])}}">
                 <img  class="round"  src="{{$userObj->avatar
                 ? asset('storage/'.$userObj->avatar):
                 asset('storage/avatars/default.png')}}">
             </a>
             <label  class="loginStyle">{{$user}}</label>

             <a class="buttonStyle" style="color:#222; font-size: 16px;" ref="{{ route('logout') }}"
                onclick="event.preventDefault();
                                                         document.getElementById('logout-form').submit();">
                 {{ strtoupper(__('Logout') )}}
             </a>
             <form id="logout-form" action="{{ route('logout') }}" method="POST">
                 @csrf
             </form>

          </div>
      </div>

</nav><!-- END main menu -->

<!-- ######################## Header (featured posts) ######################## -->

<header>


</header>

<!-- ######################## Section ######################## -->

<section>

  <div class="section_main">

      <div class="row">
          <section class="eight columns">

              @foreach($courses as $course)
                  <article class="blog_post">

                     <div class="three columns">
                         <a href="#" class="th"><img src="{{ asset('storage/'.$course->image) }}" alt="desc" /></a>
                     </div>

                     <div class="nine columns">
                         <a href="{{route('course',['id'=>$course->id])}}"><h4>{{$course->name}}</h4></a>
                         <p>{{$course->description}}</p>
                         @if(!in_array($course->id,$checkedCourses))
                             @if($course->number>0)
                                 @if($course->time >\Illuminate\Support\Carbon::now())
                                    <a href="{{ route('enroll',['courseId'=>$course->id,'courseName'=>$course->name]) }}">Записаться на курс</a>
                                    @else
                                     <p><strong>Первое занятие уже прошло. Запись на курс невозможна</strong></p>
                                    @endif
                                 @else
                                 <p><strong>Группа набрана. Запись на курс невозможна</strong></p>
                             @endif
                         @else
                             @if($course->time >\Illuminate\Support\Carbon::now())
                                 @if($course->time >\Illuminate\Support\Carbon::now()->addDay())
                                     <a href="{{route('resetEntry',['userId'=>$userId,'courseId'=>$course->id])}}">Отказаться от курса</a>
                                 @else
                                     <p><strong>До первого занятия осталось меньше одного дня. Отказ от курса невозможен</strong></p>
                                 @endif
                             @else
                                 <p><strong>Первое занятие уже прошло</strong></p>
                             @endif
                         @endif
                      </div>

                  </article>
              @endforeach
          </section>
      </div>

      <div class="filter">
          <form method="post" action="{{ route('filter') }}">
              <label> Отсортировать по:
                  <select name="select">
                      <option value="активен" selected>Активен</option>
                      <option value="прошел" >Прошел</option>
                      <option value="нет мест">Нет мест</option>
                  </select>
              </label>
              <button type="submit">Отсортировать</button>
              {{ csrf_field() }}
          </form>
          <form method="post" action="{{route('reset')}}">
              <button type="submit">Сбросить</button>
              {{ csrf_field() }}
          </form>
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
