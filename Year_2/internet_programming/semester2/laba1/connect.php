<?php
function connect_to_pg($host, $dbname, $user, $password, $port) {
        $db_conn = pg_connect("host=$host dbname=$dbname user=$user password=$password port=$port");
        if($db_conn) {
            return "Connection established";
        }
        return"Kernel panic:not syncing";
}

?>
