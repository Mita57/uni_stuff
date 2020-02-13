<?php
function get_text_and_ing($id) {
    $db_conn = pg_connect("host='localhost' port='5432' user='postgres' dbname='laba1' password='MOORMOOR'");
    $query = "SELECT * FROM news WHERE id=$id";
    $result = pg_query($db_conn, $query);
    return $result;
}
?>
