<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>gimme memes mf</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>
    <div class="top">
        <form action="index.php" method="post">
            <input type="text" name="cock" placeholder="Input ur string here">
            <input type="submit" value="Ну шо народ погнали">
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