<?php
$quartal_full = $_GET['q'];
$years = explode('; ', $quartal_full)[1];
$quartal = explode(';', $quartal_full)[0];
$months = '';
switch ($quartal) {
    case '1': {
        $months .= '1 AND 3';
        break;
    }
    case '2': {
        $months .= '4 AND 6';
        break;
    }
    case '3': {
        $months .= '7 AND 9';
        break;
    }
    case '4': {
        $months .= '10 AND 12';
        break;
    }
}
$db_conn = pg_connect('host=localhost dbname=rent user=postgres password=MOORMOOR port=5432');
$query = "SELECT objects.info, count(rental.rentor_id) FROM rental INNER JOIN objects ON rental.object_id = objects.id WHERE EXTRACT(MONTH FROM begin_date) BETWEEN $months AND EXTRACT(YEAR FROM begin_date) = $year GROUP BY objects.id, begin_date ORDER BY begin_date";
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
