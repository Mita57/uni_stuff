<?php
header("Access-Control-Allow-Origin: *");
$header = $_POST['header'];
$kindaHeader = $_POST['kindaHeader'];
$text = $_POST['text'];
$topic = $_POST['topic'];
$date = $_POST['date'];

$db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
$query = "INSERT INTO news(header, kindaheader, text, topic, date ) VALUES ('$header', '$kindaHeader', '$text', '$topic', '$date')";
$resource = pg_query($db_conn, $query);
if (!$resource) {
    echo 'bad';
} else {
    echo 'good';
}
?>
