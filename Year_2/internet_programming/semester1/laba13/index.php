<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>AVE POSTGRES</title>
    <link href="main.css" rel="stylesheet">
    <script src="main.js"></script>
</head>
<body>
    <div id="overlay">
    </div>
    <div class="outism">
        <table class="objects">
            <?php
            $dbconn = pg_connect('host = localhost dbname = rent user=postgres password = MOORMOOR port=5432');
            $query = pg_query($dbconn, 'SELECT * FROM objects ORDER BY id');
            $result = pg_fetch_all($query);
            $cols = ['id', 'type', 'month_payment', 'info'];
            echo("<tr> <td></td><td> <button onclick='addObject()'>Добавить объект</button> </td> </tr>");
            echo('<tr>');
            $cols[2] = 'price';
            for ($i = 0; $i < sizeof($cols); $i++) {
                echo "<td>" . $cols[$i] . "</td>";
            }
            $cols[2] = 'month_payment';
            echo("<td> Edit </td> <td> Delete </td> </tr>");
            for ($i = 0; $i < sizeof($result); $i++) {
                echo("<tr>");
                for ($j = 0; $j < sizeof($result[$i]); $j++) {
                    echo("<td>" . $result[$i][$cols[$j]] . "</td>");
                }
                $number = $result[$i]['id'];
                echo("<td> <button onclick='updateObject($number)'> Edit</td>");
                echo("<td> <button onclick='deleteObject($number)'> Delete</td>");
                echo("</tr>");
            }
            ?>
        </table>

        <table class="rentals">
            <?php
            $dbconn = pg_connect('host = localhost dbname = rent user=postgres password = MOORMOOR port=5432');
            $query = pg_query($dbconn, 'SELECT * FROM rental ORDER BY id');
            $result = pg_fetch_all($query);
            $cols = ['id', 'begin_date', 'period', 'object_id', 'rentor_id'];
            echo("<tr> <td></td><td> <button onclick='addRent()'>Добавить сдачу</button> </td> </tr>");
            echo('<tr>');
            $cols[3] = 'obj';
            $cols[4] = 'rentor';
            for ($i = 0; $i < sizeof($cols); $i++) {
                echo "<td>" . $cols[$i] . "</td>";
            }
            $cols[3] = 'object_id';
            $cols[4] = 'rentor_id';
            echo("<td> Edit </td> <td> Delete </td> </tr>");
            for ($i = 0; $i < sizeof($result); $i++) {
                echo("<tr>");
                for ($j = 0; $j < sizeof($result[$i]); $j++) {
                    echo("<td>" . $result[$i][$cols[$j]] . "</td>");
                }
                $number = $result[$i]['id'];
                echo("<td> <button onclick='updateRental($number)'> Edit</td>");
                echo("<td> <button onclick='deleteRental($number)'> Delete</td>");
                echo("</tr>");
                echo("</tr>");
            }
            ?>
        </table>

        <table class="rentors">
            <?php
            $dbconn = pg_connect('host = localhost dbname = rent user=postgres password = MOORMOOR port=5432');
            $query = pg_query($dbconn, 'SELECT * FROM rentors ORDER BY id');
            $result = pg_fetch_all($query);
            $cols = ['id', 'name'];
            echo("<tr> <td></td><td> <button onclick='addRentor()'>Добавить арендатора</button> </td> </tr>");
            echo('<tr>');
            for ($i = 0; $i < sizeof($cols); $i++) {
                echo "<td>" . $cols[$i] . "</td>";
            }
            echo("<td> Edit </td> <td> Delete </td> </tr>");
            for ($i = 0; $i < sizeof($result); $i++) {
                echo("<tr>");
                for ($j = 0; $j < sizeof($result[$i]); $j++) {
                    echo("<td>" . $result[$i][$cols[$j]] . "</td>");
                }
                $number = $result[$i]['id'];
                echo("<td> <button onclick='updateRentor($number)'> Edit</td>");
                echo("<td> <button onclick='deleteRentor($number)'> Delete</td>");
                echo("</tr>");
                echo("</tr>");
            }
            ?>
        </table>
    </div>
    <div class="qrs">
        <select name="query" id="query" onchange="selectChanged()">
            <option value="typeAll">Список объектов указанного типа</option>
            <option value="rentorsAm">Список арендаторов и количество аренд</option>
            <option value="neverRented">Список объектов, которые не сдавались</option>
            <option value="moreThanThree">Список объектов, которые сдавались более 3 раз</option>
            <option value="twoTimesOneYear">Список объектов, которые сдавались в аренду больше 2 раз на срок более 1
                года
            </option>
            <option value="objectsAmountSum">Список объектов, количество их сдач и выплаченная общая сумма</option>
            <option value="rentorsAll">Арендаторы, количество их аренд и средний срок их аренды</option>
            <option value="quartal">Объекты, сданные в определенной квартал и определенный год</option>
            <option value="rentorsObj">Список арендаторов и количество их объектов</option>
            <option value="nalog">Увеличить на 12% все аренды</option>
        </select>
        <input type="text" id="input" name="arg">
        <button onclick="query()">Execute</button>
        <div id="result"></div>
    </div>
</body>
</html>
