<?php
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "UPDATE objects set month_payment = month_payment * 1.12";
$result = pg_query($db_conn, $query);
echo json_encode(pg_fetch_all($result));
?>
