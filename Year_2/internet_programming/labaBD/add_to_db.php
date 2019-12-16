<?php
$name = $_POST['full_name'];
$pos = $_POST['pos'];
$bas_sal = $_POST['basic_salary'];
$beg_date = $_POST['begin_date'];
$pr_ratio = $_POST['prize_ratio'];
$db_conn = pg_connect('host=localhost dbname=staff user=postgres password=MOORMOOR port=5432');
$query = "INSERT into staff VALUES ('$name', '$pos', '$bas_sal', '$beg_date', '$pr_ratio', '20')";
pg_query($db_conn, $query);
header('Location: '.'/');
?>
