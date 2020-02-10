<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>UR MOM JUNIOR PHP PROGRAMMER</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>
   <?php
$memes = fopen("Лаб_Парсер.htm", "r") or die("Unable to open file!");
$currFile = fread($memes, filesize("Лаб_Парсер.htm"));
$currFile = mb_convert_encoding($currFile, 'UTF-8', 'windows-1251');
preg_match_all('/<span class="navText2">.+<\/span>/', $currFile, $matches);
$output = "";
$PHPCounter = 0;
for ($i = 0; $i < count($matches[0]); $i++) {
    $matches[0][$i] = strip_tags($matches[0][$i]);
    echo $matches[2][$i];
    $allah = explode(' ', ''.$matches[0][$i]);
    if (in_array('PHP', $allah)) {
        $PHPCounter++;
    }
    $output .= $matches[0][$i] . "\n";
}
$output .= "Times PHP has been referred: " . $PHPCounter;
   $fp = fopen('output.txt', "w");
   fwrite($fp, $output);
   fclose($fp);
    ?>
</body>
</html>