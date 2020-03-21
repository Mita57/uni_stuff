<?php

require "Auth.php";
$auth = new Auth();

$login = $_POST['login'];
$cart = $_POST['cart'];

echo $auth->getCart($login);


?>
