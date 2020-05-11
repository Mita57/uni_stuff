<?php

Route::get('/', 'IndexController@index');
Route::get('/resume{id}', 'IndexController@show');
