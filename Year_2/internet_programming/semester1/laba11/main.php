<?php
$handle = fopen("oldbase.txt", "r");
if ($handle){
    while (($line = fgets($handle)) != false){
        process($line);
    }

    fclose($handle);
    getAverages();
}

function process($string){
    $parts = explode(',', $string);
    $parts[0] = updateID($parts[0]); // Id
    $parts[1]; // name
    $parts[2]; // init
    $parts[3]; // surname
    $parts[4] = verifyGender($parts[4]); // gender
    $parts[5]; // city
    $parts[6]; // state
    $parts[7] = verifyEmail($parts[7]); //email
    $parts[8] = verifyPhoneNumber($parts[8]); // phone
    $parts[9] = updateBirthDay($parts[9]); // birthday
    $parts[10]; // occupation
    $parts[11]; // company
    $parts[12] = updateWeight($parts[12]); // weight
    $parts[13]; // height
    $parts[14] = verifyAddress($parts[14]); // post address
    $parts[15]; // post index
    $parts[16]; // county ID
    postProcess($parts); // sending the array to write, calculate  heights, weights and ages for men and women
}

$emailProblems = 0;

function verifyEmail($email){
    global $emailProblems;
    if(filter_var($email, FILTER_VALIDATE_EMAIL)) {
        return $email;
    }
    $emailProblems++;

    return "";
}

$maleAmount = 0;
$femaleAmount = 0;

$genderProblems = 0;

function verifyGender($gender){
    global $genderProblems;
    $vars = ['female', 'male'];
    for($i = 0; $i < sizeof($vars); $i++){
        if($gender == $vars[$i]){
            if($gender == 'male'){
                global $maleAmount;
                $maleAmount++;
            }
            else{
                global $femaleAmount;
                $femaleAmount++;
            }
            return $i;
        }
    }
    $genderProblems++;
    return "";
}

$phoneProblems = 0;

function verifyPhoneNumber($number){
    global $phoneProblems;
    $bad_number = false;
    $chars = str_split($number);
    for($i = 0; $i < sizeof($chars); $i++){
        if(!(ctype_digit($chars[$i])) && $chars[$i] !== '-'){
            unset($chars[$i]);
            $chars = array_values($chars);
            $bad_number = true;
        }
    }

    if($bad_number){
        $phoneProblems++;
    }

    if(sizeof($chars) == 10){
        return $chars[0].'-'.$chars[1].$chars[2].$chars[3].'-'.$chars[5].$chars[6].$chars[7].$chars[8];
    }
    if(sizeof($chars) == 11){
        return $chars[0].$chars[1].'-'.$chars[3].$chars[4].$chars[5].'-'.$chars[6].$chars[7].$chars[8].$chars[9];
    }
    if(sizeof($chars) == 12){
        return $chars[0].$chars[1].$chars[2].'-'.$chars[4].$chars[5].$chars[6].'-'.$chars[8].$chars[9].$chars[10].$chars[11];
    }
    return "";
}

$addressProblems = 0;

function verifyAddress($address){
    global $addressProblems;
    $parts = explode(' ', $address);
    if(!(ctype_digit($parts[0]))){
        $addressProblems++;
        return "";
    }
    else{
        $outism = "";
        for($i = 1; $i < sizeof($parts); $i++){
            $outism .= $parts[$i].' ';
        }
        return $outism.', '.$parts[0];
    }
}

function updateID($ID){
    while(strlen((string)$ID) < 6){
        $ID = "0".$ID;
    }
    return $ID;
}


function updateBirthDay($day){
    $parts = explode('/', $day);
    return ($parts[1].'.'.$parts[0].'.'.$parts[2]);
}


function updateWeight($weight){
    return round($weight);
}

$maleAge = 0;
$femaleAge = 0;

$maleHeight = 0;
$femaleHeight = 0;

$maleWeight = 0;
$femaleWeight = 0;

$allFemaleWeights = [];
$allFemaleHeights = [];
$allFemaleAges = [];

$allMaleAges = [];
$allMaleWeights = [];
$allMaleHeights = [];

$oldestPerson = "";
$biggestAge =  mktime(0,0,0,1,1,1);

$youngestPerson = "";
$leastAge = mktime(0,0,0,1,1,9999);

$bornIn0101[] = [];
$bornIn0701[] = [];
$bornIn1402[] = [];
$bornIn2302[] = [];
$bornIn0803[] = [];
$bornIn0105[] = [];
$bornIn3112[] = [];
$postProviders = [];
$postUsers = [];

function postProcess($parts){
    global $maleAge, $femaleAge, $maleHeight, $femaleHeight, $maleWeight, $femaleWeight,
        $allFemaleAges, $allFemaleHeights, $allFemaleWeights, $allMaleAges, $allMaleHeights, $allMaleWeights,
        $youngestPerson, $leastAge, $oldestPerson, $biggestAge, $bornIn0101, $bornIn0701, $bornIn1402, $bornIn2302,
        $bornIn0803, $bornIn0105, $bornIn3112, $postProviders, $postUsers;
    $gender = $parts[4];
    $flag = true;
    $bdayParts = explode('.', $parts[9]);
    //if is the youngest person
    if((int)mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]) > (int)$biggestAge){
        $youngestPerson = 'Имя: '. $parts[1] . ' ' . $parts[2] . ' ' . $parts[3] . '; Телефон:' . $parts[8] . '; адрес: ' . $parts[5] . ' ' . $parts[6] . ' ' . $parts[14];
        $biggestAge = mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]);
        $flag = false;
    }
    if((int)mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]) == (int)$biggestAge && $flag) {
        $youngestPerson .= ', Имя: ' . $parts[1] . ' ' . $parts[2] . ' ' . $parts[3] . '; Телефон:' . $parts[8] . '; адрес: ' . $parts[5] . ' ' . $parts[6] . ' ' . $parts[14];
        $biggestAge = mktime(0, 0, 0, $bdayParts[1], $bdayParts[0], $bdayParts[2]);
    }
    $flag = true;

    //if is the oldest person
    if((int)mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]) < (int)$leastAge){
        $oldestPerson = 'Имя: '. $parts[1] . ' ' . $parts[2] . ' ' . $parts[3] . '; Телефон:' . $parts[8] . '; адрес: ' . $parts[5] . ' ' . $parts[6] . ' ' . $parts[14];
        $leastAge = mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]);
        $flag = false;
    }

    if((int)mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]) == (int)$leastAge && $flag){
        $oldestPerson .= 'Имя: '. $parts[1] . ' ' . $parts[2] . ' ' . $parts[3] . '; Телефон:' . $parts[8] . '; адрес: ' . $parts[5] . ' ' . $parts[6] . ' ' . $parts[14];
        $leastAge = mktime(0,0,0, $bdayParts[1],$bdayParts[0],$bdayParts[2]);
    }

    //if the BD is any of the celebrations

    if($bdayParts[0] == "01" && $bdayParts[1] == "01"){
        $bornIn0101[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }

    if($bdayParts[0] == "07" && $bdayParts[1] == "01"){
        $bornIn0701[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }

    if($bdayParts[0] == "14" && $bdayParts[1] == "02"){
        $bornIn1402[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }

    if($bdayParts[0] == "23" && $bdayParts[1] == "02"){
        $bornIn2302[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }

    if($bdayParts[0] == "08" && $bdayParts[1] == "03"){
        $bornIn0803[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }

    if($bdayParts[0] == "01" && $bdayParts[1] == "05"){
        $bornIn0105[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }

    if($bdayParts[0] == "31" && $bdayParts[1] == "12"){
        $bornIn3112[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
    }


    if($gender == 0){ //female
        $femaleHeight += $parts[13];
        $femaleWeight += $parts[12];
        $femaleAge += 2019 - $bdayParts[2];
        $allFemaleHeights[] = $parts[13];
        $allFemaleWeights[] = $parts[12];
        $allFemaleAges[] = 2019 - $bdayParts[2];

    }
    else{ //male
        $maleHeight += $parts[13];
        $maleWeight += $parts[12];
        $maleAge += 2019 - $bdayParts[2];
        $allMaleHeights[] = $parts[13];
        $allMaleWeights[] = $parts[12];
        $allMaleAges[] = 2019 - $bdayParts[2];

    }

    $domain = explode('@', $parts[7])[1];
    if(!in_array($domain, (array)$postProviders) && $domain != ''){
        $postProviders[] = $domain;
        $postUsers[] = 0;
    }

    for($i = 0; $i < sizeof((array)$postProviders); $i++){
        if($domain == $postProviders[$i]){
            $postUsers[$i]++;
        }
    }

    writeFile($parts);
}

function writeFile($parts){
    $outism = '';
    for($i = 0; $i < sizeof($parts); $i++){
        $outism .= $parts[$i].';';
    }
    $outism = substr($outism, 0, -1);
    file_put_contents('output.txt', $outism , FILE_APPEND | LOCK_EX);
}

function getAverages(){
    global $maleWeight, $maleHeight, $maleAge, $maleAmount ,$femaleAge, $femaleAmount, $femaleHeight, $femaleWeight;
    $avgMaleHeight = $maleHeight / $maleAmount;
    $avgMaleAge = $maleAge / $maleAmount;
    $avgMaleWeight = $maleWeight / $maleAmount;
    $avgFemaleAge = $femaleAge / $femaleAmount;
    $avgFemaleWeight = $femaleWeight / $femaleAmount;
    $avgFemaleHeight = $femaleHeight / $femaleAmount;
    $outism = "Количество хлопцев: " . $maleAmount . "; количество тянок: " . $femaleAmount . "; ср. высота хлопцев: " . $avgMaleHeight . "; ср. высота тянок: " . $avgFemaleHeight .
        "; ср. вес хлопцев: ". $avgMaleWeight . "; ср. вес тянок: ". $avgFemaleWeight . "; ср. возраст хлопцев: " . $avgMaleAge . "; ср. возраст тянок: " . $avgFemaleAge . '\n';
    $outism = $outism . getDifferentThanAvgs($avgMaleHeight, $avgMaleAge, $avgMaleWeight, $avgFemaleAge, $avgMaleWeight, $avgFemaleHeight);
    $outism =  $outism . "\n" . getMailProviders();
    file_put_contents('info.txt', $outism , FILE_APPEND | LOCK_EX);
}

function getMailProviders(){
    global $postUsers, $postProviders;
    $outism = "Пользователей почты:";
    for($i = 0; $i < sizeof((array)$postProviders); $i++){
        $outism .= ($postProviders[$i] . " :" . $postUsers[$i]. ", ");
    }
    return $outism;
}

// I really regret everything in my life

function getDifferentThanAvgs($avgMaleHeight, $avgMaleAge, $avgMaleWeight, $avgFemaleAge, $avgFemaleWeight, $avgFemaleHeight){
    global $allFemaleAges, $allFemaleWeights, $allFemaleHeights, $allMaleAges, $allMaleWeights, $allMaleHeights;
    //females
    $lowerHeightFemale = 0;
    $lowerWeightFemale = 0;
    $lowerAgeFemale = 0;

    $sameHeightFemale = 0;
    $sameWeightFemale = 0;
    $sameAgeFemale = 0;

    $higherHeightFemale = 0;
    $higherWeightFemale = 0;
    $higherAgeFemale = 0;

    //males

    $lowerHeightMale = 0;
    $lowerWeightMale = 0;
    $lowerAgeMale = 0;

    $sameHeightMale = 0;
    $sameWeightMale = 0;
    $sameAgeMale = 0;

    $higherHeightMale = 0;
    $higherWeightMale = 0;
    $higherAgeMale = 0;

    $outism = "";

    //female ages

    for($i = 0; $i < sizeof($allFemaleAges); $i++){
        if(round($allFemaleAges[$i]) < round($avgFemaleAge)){
            $lowerAgeFemale++;
            continue;
        }
        if(round($allFemaleAges[$i]) == round($avgFemaleAge)){
            $sameAgeFemale++;
            continue;
        }
        else{
            $higherAgeFemale++;
        }
    }

    $outism  = $outism . "\nТянок меньше ср. возрасата: " . $lowerAgeFemale . "; тянок ср. возраста: " . $sameAgeFemale . '; тянок выше ср. возраста: ' . $higherAgeFemale . "\n";

    //female heights

    for($i = 0; $i < sizeof($allFemaleHeights); $i++){
        if(round($allFemaleHeights[$i]) < round($avgFemaleHeight)){
            $lowerHeightFemale++;
            continue;
        }
        if(round($allFemaleHeights[$i]) == round($avgFemaleHeight)){
            $sameHeightFemale++;
            continue;
        }
        else{
            $higherHeightFemale++;
        }
    }

    $outism  = $outism . "Тянок меньше ср. роста: " . $lowerHeightFemale . "; тянок ср. роста: " . $sameHeightFemale . '; тянок выше ср. роста: ' . $higherHeightFemale . "\n";

    //female weights

    for($i = 0; $i < sizeof($allFemaleWeights); $i++){
        if(round($allFemaleWeights[$i]) < round($avgFemaleWeight)){
            $lowerWeightFemale++;
            continue;
        }
        if(round($allFemaleWeights[$i]) == round($avgFemaleWeight)){
            $sameWeightFemale++;
            continue;
        }
        else{
            $higherWeightFemale++;
        }
    }

    $outism  = $outism . "Тянок меньше ср. веса: " . $lowerWeightFemale . "; тянок ср. веса: " . $sameWeightFemale . '; тянок выше ср. веса: ' . $higherWeightFemale . "\n";

    //male ages

    for($i = 0; $i < sizeof((array)$allMaleAges); $i++){
        if(round($allMaleAges[$i]) < round($avgMaleAge)){
            $lowerAgeMale++;
            continue;
        }
        if(round($allMaleAges[$i]) == round($avgMaleAge)){
            $sameAgeMale++;
            continue;
        }
        else{
            $higherAgeMale++;
        }
    }

    $outism  = $outism . "Хлопцев меньше ср. возраста: " . $lowerAgeMale . "; хлопцев ср. возраста: " . $sameAgeMale . '; хлопцев выше ср. возраста: ' . $higherAgeMale . "\n";

    //male heights

    for($i = 0; $i < sizeof((array)$allMaleHeights); $i++){
        if(round($allMaleHeights[$i]) < round($avgMaleHeight)){
            $lowerHeightMale++;
            continue;
        }
        if(round($allMaleHeights[$i]) == round($avgMaleHeight)){
            $sameHeightMale++;
            continue;
        }
        else{
            $higherHeightMale++;
        }
    }

    $outism  = $outism . "Хлопцев меньше ср. роста: " . $lowerHeightMale . "; лопцев ср. роста: " . $sameHeightMale . '; хлопцев выше ср. роста: ' . $higherHeightMale . "\n";

    //male weights

    for($i = 0; $i < sizeof((array)$allMaleWeights); $i++){
        if(round($allMaleWeights[$i]) < round($avgMaleWeight)){
            $lowerWeightMale++;
            continue;
        }
        if(round($allMaleWeights[$i]) == round($avgMaleWeight)){
            $sameWeightMale++;
            continue;
        }
        else{
            $higherWeightMale++;
        }
    }

    $outism  = $outism . "Хлопцев меньше ср. веса: " . $lowerWeightMale . "; хлопцев ср. веса: " . $sameWeightMale . '; хлопцев выше ср. веса: ' . $higherWeightMale . "\n";
    $outism = $outism . printCelebrations();
    return $outism;
}

function printCelebrations(){
    global $bornIn1402, $bornIn0101, $bornIn2302, $bornIn0105, $bornIn0701, $bornIn0803, $bornIn3112, $youngestPerson, $oldestPerson,
           $addressProblems, $phoneProblems, $emailProblems, $genderProblems;
    $outism = "Родившиеся 01.01: ";
    for($i = 0; $i < sizeof((array)$bornIn0101); $i++){
        $outism = $outism . $bornIn0101[$i] . ', ';
    }

    $outism .= " \nРодившиеся 07.01: ";
    for($i = 0; $i < sizeof((array)$bornIn0701); $i++){
        $outism = $outism . $bornIn0701[$i] . ', ';
    }

    $outism .= " \nРодившиеся 14.02: ";
    for($i = 0; $i < sizeof((array)$bornIn1402); $i++){
        $outism = $outism . $bornIn1402[$i] . ', ';
    }

    $outism .= " \nРодившиеся 23.02: ";
    for($i = 0; $i < sizeof((array)$bornIn2302); $i++){
        $outism = $outism . $bornIn2302[$i] . ', ';
    }

    $outism .= " \nРодившиеся 08.03: ";
    for($i = 0; $i < sizeof((array)$bornIn0803); $i++){
        $outism = $outism . $bornIn0803[$i] . ', ';
    }

    $outism .= " \nРодившиеся 01.05: ";
    for($i = 0; $i < sizeof((array)$bornIn0105); $i++){
        $outism = $outism . $bornIn0105[$i] . ', ';
    }

    $outism .= " \nРодившиеся 31.12: ";
    for($i = 0; $i < sizeof((array)$bornIn3112); $i++){
        $outism = $outism . $bornIn3112[$i] . ', ';
    }
    $outism .= "\nСамый пожилой: " . $oldestPerson . ', ';
    $outism .= "\nСамый молодой " . $youngestPerson . ', ';

    //errors in data

    $outism .= "\nКол-во ошибок, адрес:" . $addressProblems . ', телефон: ' . $phoneProblems . ', email: ' . $emailProblems . ', пол: ' . $genderProblems;

    return $outism;
}

?>
