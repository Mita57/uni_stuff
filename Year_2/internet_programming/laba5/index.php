<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>autism</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>

    <?php

    $memes = fopen("input.txt", "r") or die("Unable to open file!");
    $cock = fread($memes,filesize("input.txt"));
    $syllables = ['b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'];
    for($i = 0; $i < strlen($cock); $i++){
        if(in_array($cock[$i], $syllables)){
            $cock[$i] = ucfirst($cock[$i]);
        }
    }
    $fp = fopen('output.txt', "w");
    fwrite($fp, $cock);
    fclose($fp)


    ?>
</body>
</html>