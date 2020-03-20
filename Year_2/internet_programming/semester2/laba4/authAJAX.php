<?php
require "Auth.php";
$auth = new Auth();

$login = $_POST['login'];
$pwrd = $_POST['pwrd'];

$result = $auth->login($login, $pwrd);
echo $result;


?>
