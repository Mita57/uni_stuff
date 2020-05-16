<?php

Route::get('/', 'IndexController@index');
Route::get('/resume{id}', 'IndexController@show');
Route::get('/stage', 'IndexController@stage');
Route::get('/coders', 'IndexController@coders');
Route::get('/amount', 'IndexController@amount');
Route::get('/professions', 'IndexController@professions');
Route::get('/professions', 'IndexController@professions');
Route::get('/add', 'IndexController@add');
Route::post('/add', 'IndexController@store')->name('resumeStore');
