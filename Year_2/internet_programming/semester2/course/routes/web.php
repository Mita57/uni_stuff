<?php

Route::get('/', function () {
    return redirect('/home');
});

Auth::routes();

Route::get('/admin', 'IndexController@ShowAdminPage')->name('adminPage');

Route::get('/add', 'IndexController@ShowAddForm')->name('add');

Route::post('/add', 'IndexController@PostCourse')->name('post');

Route::get('/user', 'IndexController@ShowUserPage')->name('userPage');

Route::get('/enroll/{courseId}/{courseName}', 'IndexController@EnrollCourse')->name('enroll');

Route::post('/enroll/{courseId}/{courseName}', 'IndexController@EnrollOnCourse')->name('postEnroll');

Route::post('/user', 'IndexController@SortCourses')->name('filter');

Route::post('/reset', 'IndexController@ResetSorting')->name('reset');

Route::get('/user/{id}', 'IndexController@ShowUserCourses')->name('userCourses');

Route::get('/course/{id}', 'IndexController@ShowCourse')->name('course');

Route::get('/course/entries/{courseId}', 'IndexController@ShowCourseEntries')->name('courseEntries');

Route::get('/delete/{id}', 'IndexController@Delete')->name('delete');

Route::get('/delete/entries/{id}', 'IndexController@DeleteEntry')->name('deleteEntry');

Route::get('/reset/{courseId}/{userId}', 'IndexController@ResetEntry')->name('resetEntry');

Route::get('/home', 'HomeController@index')->name('home');

Auth::routes();

Route::get('/home', 'HomeController@index')->name('home');
