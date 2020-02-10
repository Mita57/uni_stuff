<?php
$payload = file_get_contents('php://input');
$q = explode(" ", $payload)[2];
$memes = fopen("../sites.json", "r") or die("Unable to open file!");
$currFile = fread($memes, filesize("../sites.json"));
$stuff = json_decode($currFile);
$jsonsite = "site".$q;
$beforePeopleCti = ($stuff->$jsonsite->cti) * ($stuff->$jsonsite->shown - 1);
$stuff->$jsonsite->cti = ($beforePeopleCti) / ($stuff->$jsonsite->shown);
$stuff = json_encode($stuff);
$cocks = fopen("../sites.json", "w") or die("Unable to open file!");
$rewrite = serialize($stuff);
$rewrite = substr($rewrite, 7);
$rewrite = substr_replace($rewrite, "", -2);
fwrite($cocks, $rewrite);
fclose($cocks);
?>