<?php
$payload = (json_decode(file_get_contents('php://input')));
$rentor = $payload->rentor;
$object = $payload->object;
$period = $payload->period;
$begin = $payload->start;
$id = $payload->id;
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "UPDATE rental set (rentor, object, period, begin_date) = ('$rentor', '$object', '$period', '$begin') WHERE id = $id ";
$result = pg_query($db_conn, $query);
?>
