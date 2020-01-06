<?php
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "SELECT objects.info, count(*) FROM rental INNER JOIN objects ON rental.object_id = objects.id GROUP BY objects.info HAVING count(*)>=3 AND count(period) >= 12";
$sas = pg_query($db_conn, $query);
$result = pg_fetch_all($sas);
$cols = ['info', 'count'];
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
