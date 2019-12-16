<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>AVE POSTGRES</title>
    <link href="main.css" rel="stylesheet">
    <script src="main.js"></script>
</head>
<body>
    <div class="outism">
        <table>
            <tr>
                <th>Full name</th>
                <th>Position</th>
                <th>Basic salary</th>
                <th>Begin date</th>
                <th>Prize ratio</th>
                <th>Min salary</th>
            </tr>
            <?php
            $dbconn = pg_connect('host=localhost dbname=staff user=postgres password=MOORMOOR port=5432');
            $query = pg_query($dbconn, 'SELECT * FROM staff');
            $result = pg_fetch_all($query);
            $cols = ['fullname', 'position', 'basic_salary', 'begin_date', 'prize_ratio', 'min_salary'];
            for ($i = 0; $i < sizeof($result); $i++) {
                echo("<tr>");
                for ($j = 0; $j < sizeof($result[$i]); $j++) {
                    echo("<td>" . $result[$i][$cols[$j]] . "</td>");
                }
                echo("</tr>");
            }
            echo("</table>");
            echo ("</div>");

            //remove kebab
            echo("<form method='post' action='remove_from_db.php' class='remove'>");
            echo ("<select name='smert'>");
            for ($i = 0; $i < sizeof($result); $i++) {
                echo ("<option value='" . $result[$i]['fullname'] . "'>" . $result[$i]['fullname']);
            }
            echo ("</select>");
            echo ("<input type=\"submit\" value=\"Remove row\" style=\"margin-top: 6px; margin-left: 10px\">");
            echo ("</form>");
            ?>
    <form class="add" method="post" action="add_to_db.php">
        <div>
            <input type="text" name="full_name" placeholder="Name">
            <input type="text" name="pos" placeholder="Position">
            <input type="text" name="basic_salary" placeholder="Basic salary"> <br>
            <input type="text" name="begin_date" placeholder="Begin date">
            <input type="text" name="prize_ratio" placeholder="Prize ratio">
        </div>
        <input type="submit" value="Add row" style="margin-top: 6px">
    </form>
    <div class="query">
        <select name="queries" id="querySelect" onchange="shtuka()">
            <option value="avg_and_xp">People that have higher salary than avg and no xp</option>
            <option value="prize_sum">Prize sum for certain position </option>
            <option value="MROT">Amount of people that got work within the certain period with salary > 10MROT</option>
        </select>
        <input type="text" id="queryInput">
        <input type="button" value="Send bass" onclick = 'request()'>
        <div id="outism"> </div>
    </div>
</body>
</html>
