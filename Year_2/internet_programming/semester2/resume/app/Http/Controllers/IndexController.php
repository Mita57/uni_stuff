<?php
namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Person;
use Illuminate\Support\Facades\DB;

class IndexController extends Controller
{
    function index(){
        $header = "Резюме и вакансии";
        $people = DB::table('person')->get();

        $staff = DB::select('select * from staff');

        return view('page')->with(['header' => $header,
            'people' => $people,
            'staff' => $staff]);
    }

    function show($id){
        $person = DB::select('select * from person where id = '.$id);
        $staff = DB::select('select * from staff');
        $data = [$person, $staff];
        return view('resume')->with(['data'=>$data]);
    }
}
