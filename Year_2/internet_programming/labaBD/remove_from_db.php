<?php
$smert = $_POST['smert'];
$db_conn = pg_connect('host=localhost dbname=staff user=postgres password=MOORMOOR port=5432');
$query = "DELETE FROM staff WHERE fullname = '" . $smert. "'";
pg_query($db_conn, $query);
header('Location: '.'/');
?>
