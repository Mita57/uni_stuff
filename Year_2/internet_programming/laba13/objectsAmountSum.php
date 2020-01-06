<?php
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "SELECT rentors.name, count(*), avg(rental.period) FROM rental INNER JOIN rentors ON rental.rentor_id = rentors.id GROUP BY rentors.name";
$sas = pg_query($db_conn, $query);
$result = pg_fetch_all($sas);
$cols = ['name', 'count', 'avg'];
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
