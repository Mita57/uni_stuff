<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>gimme memes mf</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>
    <div class="inputs">
        <form method="post" action="index.php">
            <input type="text" name="rows" placeholder="Строки"><br>
            <input type="text" name="cols" placeholder="Столбцы"><br>
            <input type="text" name="min" placeholder="Минимум"><br>
            <input type="text" name="max" placeholder="Максимум"><br>
            <input type="submit" name="run" value="Let's go biach"><br>
        </form>
    </div>
    <?php

    $rows =  $_POST['rows'];
    $cols = $_POST['cols'];
    $ara = [];
    if(isset($_POST['run'])){
        for ($i = 0; $i < $rows; $i++){
            for ($j = 0; $j < $cols; $j++){
                $ara[$i][$j] = rand($_POST['min'], $_POST['max']);
            }
        }
        $maxELemCol = 0;
        $maxElem = $ara[$i][$j];
        $minElemROw = 0;
        $minElem = 0;
        echo ("<div class='outism'> Голодний: <br> <table>");
        for ($i = 0; $i < $rows; $i++){
            for ($j = 0; $j < $cols; $j++){
                echo ('<td>'.$ara[$i][$j]);
                if($ara[$i][$j]> $maxElem ){
                    $maxElem = $ara[$i][$j];
                    $maxELemCol = $j;
                }
                if($ara[$i][$j] < $minElem){
                    $minElem = $ara[$i][$j];
                    $minElemRow = $i;
                }

            }
            echo ('<tr>');
        }
        echo ('</table> <br>');
        $araCock = $ara;
        for ($i = 0; $i < $rows; $i++) {
            $ara[$minElemROw][$i] = $araCock[$i][$maxELemCol];
            $ara[$i][$maxELemCol] = $araCock[$maxELemCol][$i];
        }
        echo ("Бахнув пельменiв: <br><table>");
        for ($i = 0; $i < $rows; $i++){
            for ($j = 0; $j < $cols; $j++){
                echo ('<td>'.$ara[$i][$j]);
            }
            echo ("<tr>");
        }
        echo ("<br> </table> </div>");



    }
    ?>
</body>
</html>