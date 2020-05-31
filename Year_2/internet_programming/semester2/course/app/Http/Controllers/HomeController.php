<?php

namespace App\Http\Controllers;

use Illuminate\Support\Facades\Auth;
use App\User;
use Illuminate\Http\Request;

class HomeController extends Controller
{
    /**
     * Create a new controller instance.
     *
     * @return void
     */
    public function __construct()
    {
        $this->middleware('auth');
    }

    /**
     * Show the application dashboard.
     *
     */
    public function index()
    {
        if( User::getCurrentUserLogin() === 'admin') {
            return redirect('/admin');
        }
        else {
            $userId = Auth::id();
           return redirect('/user/'.$userId);
        }
    }
}
