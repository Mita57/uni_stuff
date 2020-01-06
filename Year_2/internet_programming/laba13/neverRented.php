<?php
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "SELECT * FROM objects WHERE id NOT IN (SELECT object_id FROM rental)";
$sas = pg_query($db_conn, $query);
$result = pg_fetch_all($sas);
$cols = ['id', 'type', 'month_paynment', 'info'];
echo('<table class="cock">');
for ($i = 0; $i < sizeof($result); $i++) {
    echo("<tr>");
    for ($j = 0; $j < sizeof($result[$i]); $j++) {
        echo("<td>" . $result[$i][$cols[$j]] . "</td>");
    }
    echo("</tr>");
}
echo('</table>');
?>
