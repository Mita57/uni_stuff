<?php
$payload = (json_decode(file_get_contents('php://input')));
var_dump($payload);
$id = $payload->id;
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "DELETE FROM rentors WHERE id = $id";
$result = pg_query($db_conn, $query);
?>
