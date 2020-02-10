<?php
$payload = (json_decode(file_get_contents('php://input')));
var_dump($payload);
$id = $payload->id;
$type = $payload->type;
$desc = $payload->desc;
$price = $payload->price;
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "UPDATE objects set (type, info, month_payment) = ('$type', '$desc', '$price') WHERE id = $id ";
$result = pg_query($db_conn, $query);
?>
