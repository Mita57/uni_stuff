<?php

namespace App\Http\Controllers;

use App\Entry;
use Illuminate\Http\Request;
use App\User;
use App\Course;
use Illuminate\Support\Facades\Auth;

class IndexController extends Controller
{
    public $userName;

    function ShowAdminPage() {
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        if($user !== 'admin') {
            return redirect('/user');
        }
        $userId = Auth::id();
        $courses = Course::getCourses();

        $countMembers = array();
        foreach ($courses as $course)
        {
            $countMembers+= [$course->id => Entry::GetCourseMemebersCount($course->id)];
        }
        return view('admin', compact('user', 'userId','courses','countMembers','userObj'));
    }

    function ShowUserPage() {
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        if($user === 'admin') {
            return redirect('/admin');
        }
        $userId = Auth::id();
        $checkedCourses=Entry::GetUsersEntries($userId);
        $courses = Course::getCourses();
        return view('index', compact('user', 'userId','courses','userObj', 'checkedCourses'));
    }

    function ShowUserCourses($id) {
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        $coursesId = Entry::GetUsersEntries($id);
        $courses = array();
        $userId = Auth::id();
        foreach ($coursesId as $courseId)
        {
            $courses[]= Course::getCourseById($courseId);
        }
        return view('courses', compact('user','courses','userObj','userId'));
    }

    function ShowCourseEntries($courseId)
    {
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        $course = Course::getCourseById($courseId)->name;
        $entries = Entry::GetCourseEntriesById($courseId);
        $users = array();
        foreach ($entries as $entry)
        {
            $users+= [$entry->user => User::GetUserLoginById($entry->user)];
        }
        return view('entries', compact('entries','users','user','course','userObj'));
    }
    function ShowCourse($id) {
        $userId=Auth::id();
        $checkedCourses=Entry::GetUsersEntries($userId);
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        $course = Course::getCourseById($id);
        return view('kurs', compact('user','course','userObj','userId','checkedCourses'));
    }

    function EnrollCourse($courseId, $courseName) {
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        $userId = Auth::id();
        return view('enroll', compact('user', 'userId','courseId','courseName','userObj'));
    }

    function EnrollOnCourse(Request $request, $courseId, $courseName) {
        $userId = Auth::id();

        $this->validate($request,['town' => 'required|string',
            'phone' => 'required|regex:/^(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?$/',
            'card_number' => 'required|regex:/\d{4}[\s\-]?\d{4}[\s\-]?\d{4}[\s\-]?\d{4}/',
            'card_time_limit_1' => 'required|min:1|max:12',
            'card_time_limit_2' => 'required|min:0',
            'card_code'=>'required|regex:/\d\d\d/']);
        $preData = $request->all();

        $preData += ['user'=>$userId];
        $limit = $preData['card_time_limit_1'].'/'.$preData['card_time_limit_2'];
        unset($preData['card_time_limit_1'], $preData['card_time_limit_2']);
        $preData += ['card_time_limit'=>$limit];
        $preData += ['course'=>$courseId];
        $data = $preData;

        $resume=new Entry();
        $resume->fill($data);
        $resume->save();

        Course::DicreaseCourseNumbers($courseId);
        return redirect('/course/'.$courseId);
    }

    public function Delete($id) {
        Course::DeleteCourse($id);
        return redirect('/admin');
    }

    public function DeleteEntry($id) {
        $courseId = Entry::GetCourseByEntryId($id);
        Entry::DeleteEntryById($id);
        Course::IncreaseCourseNumbers($courseId);
        return redirect('/course/entries/'.$courseId);
    }

    public function ResetEntry($courseId,$userId) {
        $entryId = Entry::GetEntryId($courseId,$userId);
        Entry::DeleteEntryById($entryId);
        Course::IncreaseCourseNumbers($courseId);
        return redirect('/user/'.$userId);
    }

    public function ShowAddForm() {
        $userObj = User::GetUserById(Auth::id());
        $user = User::getCurrentUserLogin();
        return view('add', compact('user','userObj'));
    }

    function SortCourses(Request $request){
        $userId = Auth::id();
        $checkedCourses=Entry::GetUsersEntries($userId);
        $userObj = User::GetUserById(Auth::id());
        $data=$request->all();
        $courses = null;
        switch ($data['select']) {
            case 'прошел':
                $courses = Course::GetSortingCourses(0);
                break;
            case 'активен':
                $courses = Course::GetSortingCourses(1);
                break;
            case 'нет мест':
                $courses = Course::GetSortingCourses(2);
                break;
        }
        $user = User::getCurrentUserLogin();
        $userId = Auth::id();
        return view('index', compact('user', 'userId','courses','userObj','userId','checkedCourses'));
    }

    function ResetSorting(Request $request) {
        return redirect('/user');
    }

    public function PostCourse(Request $request) {
        $this->validate($request,['name' => 'required|unique:courses,name', 'description' => 'required',
            'time' => 'required','number' => 'required|min:0']);
        $path =  $request->file('image')->store('avatars','public');
        $data = $request->all();

        $data['image'] = $path;
        $resume=new Course();
        $resume->fill($data);
        $resume->save();
        return redirect('/admin');
    }
}
