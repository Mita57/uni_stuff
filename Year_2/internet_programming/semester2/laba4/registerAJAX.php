<?
require "Auth.php";
$auth = new Auth();

$login = $_POST['login'];
$pwrd = $_POST['pwrd'];
$email = $_POST['email'];

$result = $auth->register($login, $email, $pwrd);

$db_conn = pg_connect('host=localhost dbname=tents user=postgres password=MOORMOOR port=5432');


?>
