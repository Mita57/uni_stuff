<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Person;
use Illuminate\Support\Facades\DB;

class IndexController extends Controller {
    function index() {
        $header = "Резюме и вакансии";
        $people = DB::table('person')->get();

        $staff = DB::select('SELECT * FROM staff');

        return view('page')->with(['header' => $header,
            'people' => $people,
            'staff' => $staff]);
    }

    function show($id) {
        $person = DB::select('SELECT * FRPM person WHERE id = ' . $id);
        $staff = DB::select('SELECT * FROM staff');
        $data = [$person, $staff];
        return view('resume')->with(['data' => $data]);
    }

    function stage() {
        $staff = person::select()->whereBetween('stage', [5, 15])->get();
        return view('expa')->with('staff', $staff);
    }

    function coders() {
        $staff = person::select()->where('staff', 1)->get();
        return view('coders')->with('staff', $staff);
    }

    function amount() {
        $staff = person::select()->get();
        return view('amount')->with('staff', $staff);
    }

    function professions() {
        $staff = DB::select('SELECT * FROM staff WHERE id IN (SELECT Staff FROM person)');
        return view('professions')->with('staff', $staff);
    }
}
