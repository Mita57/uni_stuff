<!DOCTYPE html>
<html lang="ru">
<head>
    <title>PYHA1</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>
    <div id="heading">
        <h1>Введите размерность таблицы</h1>
    </div>
    <div id="fields">
        <form method="post" action="index.php">
        <input type="text" name="cols" placeholder="Колонки">
        <input type="text" name="rows" placeholder="Строки">
        <input type="submit" name="run" value="Погнали">
        </form>
    </div>


    <?php

    if(isset($_POST['run'])){
        $rows = $_POST['rows'];
        $cols = $_POST['cols'];
        echo (" <p><div id='tablediv'>
        <table> <tr>");
        for ($i = 0; $i <= $cols; $i++){
            if ($i == 0){
                echo ("<td class='yellow'>");
            }
            else{
                echo ("<td class='yellow'> $i");
            }
        }
        echo ("<tr>");
        //filling the rest of the table
        for ($i = 1; $i <= $rows; $i++){
            for ($j = 0;$j <= $cols; $j++){
                if ($j == 0){
                    echo ("<td class='yellow'>".$i);
                }
                else{
                    if($i*$j%2 == 0){
                    echo ("<td class='green'>".($i*$j));
                    }
                    else{
                        echo ("<td class='blue'>".($i*$j));
                    }
                }
            }
            echo ("<tr>");
        }
        if(i!==rows) {
            echo("<tr>");
        }
        echo ("</div>");
    }
    ?>
</body>
</html>