<?php

use Illuminate\Http\Request;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| is assigned the "api" middleware group. Enjoy building your API!
|
*/

Route::middleware('auth:api')->get('/user', function (Request $request) {
    return $request->user();
});

Route::post('course', 'CourseController@get_course')->name('get');

Route::post('add', 'CourseController@create')->name('create');

Route::delete('delete','CourseController@delete')->name('delete');

Route::put('update/{id}', 'CourseController@update')->name('update');
