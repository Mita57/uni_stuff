<?php
header("Access-Control-Allow-Origin: *");
$start = $_GET['start'];
$end = $_GET['end'];
error_reporting(0);

$db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
$query = "SELECT * FROM news WHERE date BETWEEN '$start' AND '$end'";
$resource = pg_query($db_conn, $query);
$result = pg_fetch_all($resource);
if (!$result || !$resource) {
    echo 'bad';
} else {
    echo (json_encode($result, JSON_UNESCAPED_UNICODE ));
}
?>
