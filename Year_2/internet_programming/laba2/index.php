<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>RIP ZEUS</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>
    <div class="inputs">
    <form method="post" action="index.php">
        <input type="text" name="range" placeholder="Размерность">
        <input type="text" name="min" placeholder="Минимум">
        <input type="text" name="max" placeholder="Максимум">
        <input type="submit" name="run" value="Let's go biach">
    </form>
    </div>
    <?php

    if(isset($_POST['run'])) {
        $min = $_POST['min'];
        $max = $_POST['max'];
        $range = $_POST['range'];
        $array = [];
        for ($i = 0; $i < $range; $i++) {
            $randNum = rand($min, $max);
            array_push($array, $randNum);
        }
        //approaching minimums
        $minElem = $array[0];
        $amountOfZeros = 0;
        $minIndex = 0;
        for ($i = 1; i < count($array); $i++){
            if($array[$i] < $minElem){
                $minElem = $array[$i];
                $minIndex = $i;
            }

        }

        //sum of all the elements in between 2 positive elements
        $firstElem = NULL;
        $lastElem = NULL;
        $sum = 0;
        for ($i = 0; $i < count($array); $i++){
            if ($array[$i] > 0){
                if (empty($firstElem)){
                    $firstElem = $array[$i];
                }
                $lastElem[$i] = $array[$i];
            }
        }
        for ($i = $firstElem; $i < $lastElem; $i++){
            $sum += $array[$i];
        }
        for ($i = 0; $i < count($array);  $i++){
            echo ("Массив: ". $array);
        }

        //pushing zeros to the beginning
        for ($i = 0; $i < count($array);  $i++){
            if($array[$i] == 0){
                $amountOfZeros++;
                unset($array[$i]);
            }
        }
        for ($i = 0; $i < $amountOfZeros; $i++){
            array_unshift($array, 0);
        }
        echo("Минимальный элемент массива: " . $minElem . ", его индекс: " . $minIndex);
        echo ("Сумма элементв между элементами: ".$sum);
        echo ("Массив пiсля смещення нулэй: ". $array);


    }
    ?>
</body>
</html>