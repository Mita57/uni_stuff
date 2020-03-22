<?php
header("Access-Control-Allow-Origin: *");
$id = $_GET['id'];
error_reporting(0);
$db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
$query = "SELECT * FROM news WHERE id = '$id'";
$resource = pg_query($db_conn, $query);
if (!$resource) {
    echo 'bad';
} else {
    $result = pg_fetch_all($resource);
    if (!$result) {
        echo 'bad';
    } else {
        echo(json_encode($result, JSON_UNESCAPED_UNICODE));
    }
}
?>
