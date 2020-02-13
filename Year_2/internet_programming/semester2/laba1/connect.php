<?php
function connect_to_pg($host, $dbname, $user, $password, $port) {
    try {
        $db_conn = pg_connect("host=$host dbname=$dbname user=$user password=$password port=$password");
        return "Connection established";
    }
    catch (Exception $ex) {
        return "Kernel panic: not syncing";
    }
}

?>
