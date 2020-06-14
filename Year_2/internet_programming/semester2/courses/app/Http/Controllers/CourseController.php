<?php

namespace App\Http\Controllers;

use App\Course;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Input;

class CourseController extends Controller
{
    public $header = array('Content-Type' => 'application/json; charset=UTF-8');

    public function get_course(Request $request) {
        $validator = $this->validate($request, [
            'id'    =>  'required|exists:courses,id',
        ]);
        $course = Course::find($request->get('id'));
        $result = response()->json($course, 200, $this->header, JSON_UNESCAPED_UNICODE)->getContent();
        return view('result', compact('result'));
    }

    public function create(Request $request) {
        $this->validate($request, [
            'name'    =>  'required|unique:courses,name',
            'description'  =>'required|unique:courses,description',
            'time' => 'required',
            'number' => 'required|min:0'
        ]);
        $data = $request->all();
        if($request->file('image') !== null) {
            $path = $request->file('image')->store('avatars', 'public');
            $data['image'] = $path;
        }
        $course = Course::create($data);

        $result = response()->json($course, 201, $this->header,
            JSON_UNESCAPED_UNICODE)->getContent();
        return view('result', compact('result'));
    }

    public function delete(Request $request) {
        $this->validate($request, [
            'id'    =>  'required|exists:courses,id',
        ]);
        Course::where('id', $request->id)->delete();
        $code = response()->json(null, 204)->getStatusCode();
        $result = '';
        if($code === 204)
            $result = 'УДАЛЕНИЕ ПРОШЛО УСПЕШНО';
        return view('result', compact('result'));
    }

    public function getCourseForUpdate() {
        if(Input::get('id') === null) {
            return view('menu');
        }
        if(!Course::find(Input::get('id'))){
            return view('menu');
        }
        $id = Input::get('id');
        $course = Course::find($id);
        $course['time'] = implode('T', explode(' ',$course['time']));
        return view('update_course', compact('course'));
    }

    public function update(Request $request, $id) {
        $this->validate($request, [
            'name'    =>  'required',
            'description'     =>  'required',
            'time' => 'required',
            'number' => 'required|min:0'
        ]);
        $path = null;
        if($request->file('image') !== null) {
            $path = $request->file('image')->store('avatars', 'public');
            $data['image'] = $path;
        }
        Course::where('id', $id)->update([
            'name' => $request->get('name'),
            'description' => $request->get('description'),
            'time' => $request->get('time'),
            'number' => $request->get('number'),
            'image' => $path
        ]);
        $result = response()->json(Course::find($id), 201, $this->header,
            JSON_UNESCAPED_UNICODE);
        return view('result', compact('result'));
    }
}
