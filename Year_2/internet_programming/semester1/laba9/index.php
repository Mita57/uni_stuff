<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <title>UR MOM JUNIOR PHP PROGRAMMER</title>
    <link rel="stylesheet"  href="htmls/main.css">
</head>
<body>
    <div id= 'cock'>
        <a href="info.php">Statistics, lul</a>
    <?php
    $num = random_int(1, 5);
    $gifka = '../gifs/0'.$num.'.gif';
    $site = '../htmls/site'.$num.'.php';
echo ("<a href='$site'>");
echo ("<img src = '$gifka'>");
echo ("</a");

    echo ("</div>");
    $memes = fopen("sites.json", "r") or die("Unable to open file!");
    $currFile = fread($memes, filesize("sites.json"));
    $stuff = json_decode($currFile);
    $jsonsite = "site".$num;
    $stuff->$jsonsite->shown++;
    $stuff = json_encode($stuff);
    $cocks = fopen("sites.json", "w") or die("Unable to open file!");
    $rewrite = serialize($stuff);
    $rewrite = substr($rewrite, 7);
    $rewrite = substr_replace($rewrite, "", -2);
    fwrite($cocks, $rewrite);
    fclose($cocks);
    ?>
</body>
</html>