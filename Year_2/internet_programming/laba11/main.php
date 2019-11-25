<?php
$handle = fopen("inputfile.txt", "r");
if ($handle){
    while (($line = fgets($handle)) != false){
        process($line);
    }

    fclose($handle);
}



function process($string){
    $parts = explode(',', $string);
    $ID = updateID($parts[0]);
    $name = $parts[1];
    $init = $parts[2];
    $surname = $parts[3];
    $gender = verifyGender($parts[4]);



}

function verifyEmail($email){

}

function verifyGender($gender){

}

function verifyPhoneNumber($number){

}

function verifyAdress($adress){

}

function updateID($ID){

}

function updateGender($gender){

}

function updatePhoneNumber($number){

}

function updateBirthDay($day){

}

function updateWeight($weight){

}

function updateAdress($adress){

}

?>
