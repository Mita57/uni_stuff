<?php
function search($company) {
    $db_conn = pg_connect("host='localhost' port='5432' user='postgres' dbname='laba1' password='MOORMOOR'");
    $query = "SELECT * FROM news WHERE text LIKE(% $company %)";
    $result = pg_query($db_conn, $query);
    return $result;
}
?>
