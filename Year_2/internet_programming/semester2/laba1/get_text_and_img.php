<?php
get_text_and_ing($_GET['q']);
function get_text_and_ing($id) {
    $db_conn = pg_connect("host='localhost' port='5432' user='postgres' dbname='news' password='MOORMOOR'");
    $query = "SELECT * FROM news WHERE id=$id";
    $result = pg_query($db_conn, $query);
    $exec = pg_fetch_all($result);
    $response = $exec[0]['kindaheader'] . "; \n" . $exec[0]['text'] . "; \n" . $exec[0]['topic'] . '^' . $exec[0]['img'];
    echo $response;
}
?>
