<?php
header("Access-Control-Allow-Origin: *");
$id = $_POST['id'];

$db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
$query = "DELETE FROM news WHERE id = $id";
$resource = pg_query($db_conn, $query);
if (pg_affected_rows($resource) == 0) {
    echo 'bad';
} else {
    echo 'good';
}
?>
<?php
