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
            return $i;
        }
        if($gender == 'male'){
            global $maleAmount;
            $maleAmount++;
        }
        if($gender == 'female'){
            global $femaleAmount;
            $femaleAmount++;
        }
    }
    $genderProblems++;
    return "";
}

$phoneProblems = 0;

function verifyPhoneNumber($number){
    global $phoneProblems;
    $chars = str_split($number);
    for($i = 0; $i < sizeof($chars); $i++){
        if(!(ctype_digit($chars[$i])) || $chars[$i] == '-'){
            unset($chars[$i]);
            $phoneProblems++;
        }
    }

    if(sizeof($chars) == 8){
        return $chars[0].'-'.$chars[1].$chars[2].$chars[3].'-'.$chars[4].$chars[5].$chars[6].$chars[7];
    }
    if(sizeof($chars) == 9){
        return $chars[0].$chars[1].'-'.$chars[2].$chars[3].$chars[4].'-'.$chars[5].$chars[6].$chars[7].$chars[8];
    }
    if(sizeof($chars) == 10){
        return $chars[0].$chars[1].$chars[2].'-'.$chars[3].$chars[4].$chars[5].'-'.$chars[6].$chars[7].$chars[8].$chars[9];
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

$allFemaleWeights = array();
$allFemaleHeights = array();
$allFemaleAges = array();

$allMaleAges = array();
$allMaleWeights = array();
$allMaleHeights = array();

$youngestPerson = "";
$leastAge = 9999;
$oldestPerson = "";
$biggestAge = 0;

$bornIn0101 = array();
$bornIn0701 = array();
$bornIn1402 = array();
$bornIn2302 = array();
$bornIn0803 = array();
$bornIn0105 = array();
$bornIn3112 = array();

$postProviders = array();
$postUsers = array();

function postProcess($parts){
    global $maleAge, $femaleAge, $maleHeight, $femaleHeight, $maleWeight, $femaleWeight,
        $allFemaleAges, $allFemaleHeights, $allFemaleWeights, $allMaleAges, $allMaleHeights, $allMaleWeights,
        $youngestPerson, $leastAge, $oldestPerson, $biggestAge, $bornIn0101, $bornIn0701, $bornIn1402, $bornIn2302,
        $bornIn0803, $bornIn0105, $bornIn3112, $postProviders, $postUsers;
    $gender = $parts[4];
    if($gender == 0){ //female
        $femaleHeight += $parts[13];
        $femaleWeight += $parts[12];
        $bdayParts = explode('.', $parts[9]);
        $femaleAge += 2019 - $bdayParts[2];
        $allFemaleHeights[] = $parts[13];
        $allFemaleWeights[] = $parts[12];
        $allFemaleAges[] = 2019 - $bdayParts[2];

        //if is the oldest person
        if(2019 - $bdayParts[2] > $biggestAge){
            $oldestPerson = 'Имя: '. $parts[1] . ' ' . parts[2] . ' ' . $parts[3] . '; Телефон:' . $parts[8] . '; адресс: ' . $parts[5] . ' ' . $parts[6] . ' ' . $parts[14];
            $biggestAge = 2019 - $bdayParts[2];
        }
        //if is the youngest person

        if(2019 - $bdayParts[2] < $leastAge){
            $youngestPerson = 'Имя: ' . $parts[1] . ' ' . parts[2] . ' ' . $parts[3] . '; Телефон:' . $parts[8] . '; адресс: ' . $parts[5] . ' ' . $parts[6] . ' ' . $parts[14];
            $leastAge = 2019 - $bdayParts[2];
        }

        //if the BD is any of the celebrations

        if($bdayParts[0] == "01" || $bdayParts[1] == "01"){
            $bornIn0101[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "07" || $bdayParts[1] == "01"){
            $bornIn0701[] =  $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "14" || $bdayParts[1] == "02"){
            $bornIn1402 = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "23" || $bdayParts[1] == "02"){
            $bornIn2302[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "08" || $bdayParts[1] == "03"){
            $bornIn0803[] =  $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "01" || $bdayParts[1] == "05"){
            $bornIn0105[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "31" || $bdayParts[1] == "12"){
            $bornIn3112[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }
    }
    else{ //male
        $maleHeight += $parts[13];
        $maleWeight += $parts[12];
        $bdayParts = explode('.', $parts[9]);
        $maleAge += 2019 - $bdayParts[2];
        $allMaleHeights = $parts[13];
        $allMaleWeights = $parts[12];
        $allMaleAges[] = 2019 - $bdayParts[2];
        if($bdayParts[0] == "01" || $bdayParts[1] == "01"){
            $bornIn0101[] =  $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "07" || $bdayParts[1] == "01"){
            $bornIn0701[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "14" || $bdayParts[1] == "02"){
            $bornIn1402[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "23" || $bdayParts[1] == "02"){
            $bornIn2302[] =  $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "08" || $bdayParts[1] == "03"){
            $bornIn0803[] = $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "01" || $bdayParts[1] == "05"){
            $bornIn0105[] =  $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }

        if($bdayParts[0] == "31" || $bdayParts[1] == "12"){
            $bornIn3112[] =  $parts[1] . ' ' . $parts[2] . ' ' . $parts[3];
        }
    }

    $domain = explode('@', $parts[7])[1];
    if(!in_array($domain, $postProviders)){
        $postProviders[] =  $domain;
        $postUsers[] = 0;
    }

    for($i = 0; $i < sizeof($postProviders); $i++){
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
        "; ср. вес хлопцев: ". $avgMaleWeight . "; ср. вес тянок: ". $avgFemaleWeight . "; ср. возраст хлопцев: " . $avgMaleAge . "; ср. возраст тянок: " / $avgFemaleAge . '\n';
    $outism = $outism . getDifferentThanAvgs($avgMaleHeight, $avgMaleAge, $avgMaleWeight, $avgFemaleAge, $avgFemaleWeight, $avgMaleHeight) . '/n';
    $outism = $outism . getMailProviders();
    file_put_contents('info.txt', $outism , FILE_APPEND | LOCK_EX);
}

function getMailProviders(){
    global $postUsers, $postProviders;
    $outism = "";
    for($i = 0; $i < sizeof($postProviders); $i++){
        $outism = $outism . "Пользователей почты " . $postProviders[$i] . " :" . $postUsers[i];
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
        if($allFemaleAges[$i] < $avgFemaleAge){
            $lowerAgeFemale++;
            break;
        }
        if($allFemaleAges[$i] == $avgFemaleAge){
            $sameAgeFemale++;
            break;
        }
        else{
            $higherAgeFemale++;
        }
    }

    $outism  = $outism . "Тянок меньше ср. возрасата" . $lowerAgeFemale . "; тянок ср. возраста: " . $sameAgeFemale . '; тянок выше ср. возраста: ' . $higherAgeFemale . "\n";

    //female heights

    for($i = 0; $i < sizeof($allFemaleHeights); $i++){
        if($allFemaleHeights[$i] < $avgFemaleHeight){
            $lowerHeightFemale++;
            break;
        }
        if($allFemaleHeights[$i] == $avgFemaleHeight){
            $sameHeightFemale++;
            break;
        }
        else{
            $higherHeightFemale++;
        }
    }

    $outism  = $outism . "Тянок меньше ср. роста" . $lowerHeightFemale . "; тянок ср. роста: " . $sameHeightFemale . '; тянок выше ср. роста: ' / $higherHeightFemale . "\n";

    //female weights

    for($i = 0; $i < sizeof($allFemaleWeights); $i++){
        if($allFemaleWeights[$i] < $avgFemaleWeight){
            $lowerWeightFemale++;
            break;
        }
        if($allFemaleWeights[$i] == $avgFemaleWeight){
            $sameWeightFemale++;
            break;
        }
        else{
            $higherWeightFemale++;
        }
    }

    $outism  = $outism . "Тянок меньше ср. веса" . $lowerWeightFemale . "; тянок ср. веса: " . $sameWeightFemale . '; тянок выше ср. веса: ' / $higherWeightFemale . "\n";

    //male ages

    for($i = 0; $i < sizeof($allMaleAges); $i++){
        if($allMaleAges[$i] < $avgMaleAge){
            $lowerAgeMale++;
            break;
        }
        if($allMaleAges[$i] == $avgMaleAge){
            $sameAgeMale++;
            break;
        }
        else{
            $higherAgeMale++;
        }
    }

    $outism  = $outism . "Хлопцев меньше ср. возраста" . $lowerAgeMale . "; лопцев ср. возраста: " . $sameAgeMale . '; хлопцев выше ср. возраста: ' / $higherAgeMale . "\n";

    //male heights

    for($i = 0; $i < sizeof($allMaleHeights); $i++){
        if($allMaleHeights[$i] < $avgMaleHeight){
            $lowerHeightMale++;
            break;
        }
        if($allMaleHeights[$i] == $avgMaleHeight){
            $sameHeightMale++;
            break;
        }
        else{
            $higherHeightMale++;
        }
    }

    $outism  = $outism . "Хлопцев меньше ср. роста" . $lowerHeightMale . "; лопцев ср. роста: " . $sameHeightMale . '; хлопцев выше ср. роста: ' / $higherHeightMale . "\n";

    //male weights

    for($i = 0; $i < sizeof($allMaleWeights); $i++){
        if($allMaleWeights[$i] < $avgMaleWeight){
            $lowerWeightMale++;
            break;
        }
        if($allMaleWeights[$i] == $allMaleWeights){
            $sameWeightMale++;
            break;
        }
        else{
            $higherWeightMale++;
        }
    }

    $outism  = $outism . "Хлопцев меньше ср. веса" . $lowerWeightMale . "; лопцев ср. веса: " . $sameWeightMale . '; хлопцев выше ср. веса: ' / $higherWeightFemale . "\n";
    $outism = $outism . printCelebrations();
    return $outism;
}

function printCelebrations(){
    global $bornIn1402, $bornIn0101, $bornIn2302, $bornIn0105, $bornIn0701, $bornIn0803, $bornIn3112, $youngestPerson, $oldestPerson;
    $outism = "Родившиеся 01.01: ";
    for($i = 0; $i < sizeof($bornIn0101); $i++){
        $outism = $outism . $bornIn0101[$i] . ' ';
    }

    $outism .= " \n Родившиеся 07.01: ";
    for($i = 0; $i < sizeof($bornIn0701); $i++){
        $outism = $outism . $bornIn0701[$i] . ' ';
    }

    $outism .= " \n Родившиеся 14.02: ";
    for($i = 0; $i < sizeof($bornIn1402); $i++){
        $outism = $outism . $bornIn1402[$i] . ' ';
    }

    $outism .= " \n Родившиеся 23.02: ";
    for($i = 0; $i < sizeof($bornIn2302); $i++){
        $outism = $outism . $bornIn2302[$i] . ' ';
    }

    $outism .= " \n Родившиеся 08.03: ";
    for($i = 0; $i < sizeof($bornIn0803); $i++){
        $outism = $outism . $bornIn0803[$i] . ' ';
    }

    $outism .= " \n Родившиеся 01.05: ";
    for($i = 0; $i < sizeof($bornIn0105); $i++){
        $outism = $outism . $bornIn0105[$i] . ' ';
    }

    $outism .= " \n Родившиеся 31.12: ";
    for($i = 0; $i < sizeof($bornIn3112); $i++){
        $outism = $outism . $bornIn3112[$i] . ' ';
    }
    $outism .= "Самый пожилой: " . $oldestPerson . '\n';
    $outism .= "Самый молодой: " . $youngestPerson;

    return $outism;
}

?>
