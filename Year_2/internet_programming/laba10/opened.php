<?php
$memes = fopen("sites.json", "r") or die("Unable to open file!");
$currFile = fread($memes, filesize("sites.json"));
$stuff = json_decode($currFile);
$payload = file_get_contents('php://input');
$q = explode(" ", $payload)[2];
$memes = fopen("sites.json", "r") or die("Unable to open file!");
$currFile = fread($memes, filesize("sites.json"));
$stuff = json_decode($currFile);
$jsonsite = "site".$q;
$stuff->$jsonsite->shown++;
$stuff = json_encode($stuff);
$cocks = fopen("sites.json", "w") or die("Unable to open file!");
$rewrite = serialize($stuff);
$rewrite = substr($rewrite, 7);
$rewrite = substr_replace($rewrite, "", -2);
fwrite($cocks, $rewrite);
fclose($cocks);
?>