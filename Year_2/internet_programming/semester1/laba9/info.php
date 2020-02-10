<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>Information</title>
    <link rel="stylesheet"  href="htmls/main.css">
</head>
<body>
    <div id= 'cock'>
    <?php
    $memes = fopen("sites.json", "r") or die("Unable to open file!");
    $currFile = fread($memes, filesize("sites.json"));
    $stuff = json_decode($currFile);
    for($i = 1; $i < 6; $i++){
        $number = 'site'.$i;
        echo ('<h3>'.$number.'</h3>');
        echo (serialize($stuff->$number->shown)).('<br>');
        echo (serialize($stuff->$number->ctr)).('<br>');
        echo (serialize($stuff->$number->cti)).('<br>');
        echo (serialize($stuff->$number->ctb)).('<br>');
        echo("______________________________").('<br>');
    }
    echo ("</div>");
    ?>
</body>
</html>
