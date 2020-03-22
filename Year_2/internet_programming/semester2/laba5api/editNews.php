<?php
header("Access-Control-Allow-Origin: *");
$header = $_POST['header'];
$kindaHeader = $_POST['kindaHeader'];
$text = $_POST['text'];
$topic = $_POST['topic'];
$date = $_POST['date'];

$id = $_POST['id'];

$db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
$query = "UPDATE news SET (header, kindaheader, text, topic, date ) = ('$header', '$kindaHeader', '$text', '$topic', '$date') WHERE id = $id";
$resource = pg_query($db_conn, $query);
if (!$resource) {
    echo 'bad';
} else {
    echo 'good';
}
?>
