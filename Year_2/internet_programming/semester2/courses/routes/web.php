<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return redirect('/menu');
});

Auth::routes();

Route::get('/menu', function () {
    return view('menu');
})->name('menu');

Route::get('/getCourse', function () {
    return view('get_course');
})->name('open_get');

Route::get('/createCourse', function () {
    return view('create_course');
})->name('open_create');

Route::get('/updateCourse', 'CourseController@getCourseForUpdate')->name('open_update');

Route::get('/deleteCourse', function () {
    return view('delete_course');
})->name('open_delete');

