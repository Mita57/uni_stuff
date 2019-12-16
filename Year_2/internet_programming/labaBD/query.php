<?php
$db_conn = pg_connect('host=localhost dbname=staff user=postgres password=MOORMOOR port=5432');
$request = $_GET['q'];
switch ($request) {
    case 'noExp': {
        $query = "SELECT (full_name) FROM staff WHERE exp = 0 AND (salary > (SELECT AVG(salary) from staff))";
        $result = pg_query($db_conn, $query);
        echo $result;
        break;
    }
    case 'prize': {
        $pos = $_GET['st'];
        $query = "SELECT sum(staff.salary * staff.prize_ratio) FROM staff WHERE position = " . "'$pos'";
        $result = pg_query($db_conn, $query);
        echo $result;
        break;
    }
    case 'MROT': {
        $dates_init = $_GET['span'];
        $two_dates = explode(';', $dates_init);
        $query = "SELECT count(
    SELECT full_name WHERE begin_date BETWEEN('$two_dates[0]', '$two_dates[1]') AND SALARY > (SELECT DISTINCT 10*min_salary from staff)
           ) from staff";
        $result = pg_query($db_conn, $query);
        echo $result;
        break;
    }
}

?>
