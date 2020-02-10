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
        <input type="text" name="range" placeholder="Размерность"><br>
        <input type="text" name="min" placeholder="Минимум"><br>
        <input type="text" name="max" placeholder="Максимум"><br>
        <input type="submit" name="run" value="Let's go biach"><br>
    </form>
    </div>
    <?php

    if(isset($_POST['run'])) {
        $min = $_POST['min'];
        $max = $_POST['max'];
        $range = $_POST['range'];
        $ara = [];
        //generating an array
        for ($i = 0; $i < $range; $i++) {
            array_push($ara, rand($min, $max));
        }
        echo ("<div class='sas'>Массив: ");
        //having FUN with minimums
        $min = $ara[0];
        $minIndex = 0;
        for ($i = 0; $i < sizeof($ara); $i++){
            echo ($ara[$i].' ');
            if($ara[$i]<$min){
                $min = $ara[$i];
                $minIndex = $i;
            }

        }
        echo ("<br>Минимальный элемент массива: ".$min.", его индекс: ".$minIndex);

        //sum of elems in between last and first positive elems

        $firstPositive = null;
        $lastPositive = null;

        for ($i = 0; $i < sizeof($ara); $i++){
            if($ara[$i] > 0){
                if (is_null($firstPositive)){
                    $firstPositive = $ara[$i];
                }
                else{
                    $lastPositive = $ara[$i];
                }
            }

        }
        $sum = 0;
        for ($i = $firstPositive; $i<$lastPositive;$i++){
            $sum += $ara[$i];
        }
        echo (" <br>Сумма элементов между крайними положительными элементами: ".$sum);

        //fucking around with zeroZ

        $zeroCounter = 0;
        for ($i = 0; $i < sizeof($ara); $i++){
            if($ara[$i] == 0){
                $zeroCounter++;
                unset($ara[$i]);
            }
        }
        for ($i = 0; $i < $zeroCounter; $i++){
            array_unshift($ara, 0);
        }
        echo ("<br>". "Массив пiсля смещения элементов: ");
        for ($i = 0; $i < sizeof($ara); $i++){
            echo ($ara[$i]." ");
        }
        echo("</div>");
    }
    ?>
</body>
</html>