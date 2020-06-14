<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Entry extends Model
{
    protected $table = 'entries';

    protected $fillable = ['user', 'town', 'phone', 'card_number', 'card_time_limit', 'card_code', 'course'];

    public static function GetUsersEntries($id) {
        $records = self::select(['course'])->where('user',$id)->get();
        $coursesId =array();
        foreach ($records as $record) {
            $coursesId[] = $record['course'];
        }
        return $coursesId;
    }

    public static function GetCourseMemebersCount($id)
    {
        return self::select()->where('course',$id)->get()->count();
    }

    public static function GetCourseEntriesById($courseId)
    {
        return self::select()->where('course',$courseId)->get();
    }

    public static function GetCourseByEntryId($id)
    {
        return self::select()->where('id',$id)->first()->course;
    }

    public static function DeleteEntryById($id)
    {
        self::select()->where('id',$id)->delete();
    }

    public static function GetEntryId($courseId, $userId)
    {
        return self::select()->where('user',$userId)->where('course',$courseId)->first()->id;
    }
}
