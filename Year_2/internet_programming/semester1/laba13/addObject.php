<?php
$payload = (json_decode(file_get_contents('php://input')));
var_dump($payload);
$id = $payload->id;
$type = $payload->type;
$desc = $payload->desc;
$price = $payload->price;
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "INSERT into objects(type, month_payment, info) values ('$type', '$price', '$desc')";
$result = pg_query($db_conn, $query);
?>
