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
    $SS = explode(" ",$_POST['cock']); //finally I've a var named SS in my project
    for ($i = 0; $i < sizeof($SS); $i++){
        if(!is_numeric($SS[$i])){
            unset($SS[$i]);
            continue;
        }
        else {
            for ($j = 0; $j < strlen($SS[$i])-1; $i++) {
                if(!($SS[$i][$j] <= $SS[$i][$j+1])){
                    unset($SS[$i]);
                    break;
                }
            }
        }
    }

    echo ("<div class='outism'>") ;
    for ($i = 0; $i < sizeof($SS); $i++){
        echo ($SS[$i]." ");
    }
    echo ("</div>");
    ?>
</body>
</html>