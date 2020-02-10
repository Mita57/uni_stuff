<?php
$payload = (json_decode(file_get_contents('php://input')));
$id = $payload->id;
$name = $payload->name;
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "INSERT INTO rentors VALUES '$name' ";
$result = pg_query($db_conn, $query);
?>
