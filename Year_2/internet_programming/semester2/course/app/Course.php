<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Http\Request;
use Illuminate\Support\Carbon;

class Course extends Model
{
    protected $table = 'courses';

    protected $fillable = ['name','description','time','image','number'];

    public static function getCourses() {
        return self::select()->get();
    }
    public static function getCourseById($id) {
        return self::select()->where('id',$id)->first();
    }
    public static function DeleteCourse($id)
    {
        self::select()->where('id', $id)->delete();
    }

    public static function GetSortingCourses(int $idSort)
    {
        switch ($idSort)
        {
            case 0:
                return self::select()->where('time','<=', Carbon::now())->get();
                break;
            case 1:
                return self::select()->where('time','>=', Carbon::now())->get();
                break;
            case 2:
                return self::select()->where('number',0)->get();
                break;
        }
    }
    public static function DicreaseCourseNumbers($id) {
        $number = self::select()->where('id',$id)->first()->number;
        self::where('id',$id)->update(['number'=> $number-1]);
    }

    public static function IncreaseCourseNumbers($courseId)
    {
        $number = self::select()->where('id',$courseId)->first()->number;
        self::where('id',$courseId)->update(['number'=> $number+1]);
    }

}
