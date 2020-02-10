<?php
$payload = (json_decode(file_get_contents('php://input')));
$rentor = $payload->rentor;
$object = $payload->object;
$period = $payload->period;
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "INSERT INTO rental(rentor_id, object_id, period) VALUE ('$rentor', '$object', '$period')";
$result = pg_query($db_conn, $query);
?>
