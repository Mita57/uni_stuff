<?php
search($_GET['q']);
function search($company) {
    $db_conn = pg_connect("host='localhost' port='5432' user='postgres' dbname='news' password='MOORMOOR'");
    $query = "SELECT * FROM news WHERE text LIKE'%$company%' OR kindaheader LIKE'%$company%'";
    $result = pg_query($db_conn, $query);
    $exec = pg_fetch_all($result);
    $response = '';
    for($i = 0; $i < sizeof($exec); $i++) {
        $response .= $exec[$i]['header'] . '; ';
    }
    echo $response;
}
?>
