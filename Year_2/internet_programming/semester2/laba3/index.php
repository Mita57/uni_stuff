<!DOCTYPE html>
<html>
<head>
    <title>TUUUUUTUTU</title>
    <link rel="stylesheet" href="main.css">
    <script src="main.js"></script>
</head>
<body>
    <div id='left'>
        <?php
        $db_conn = pg_connect('host=localhost dbname=tents user=postgres password=MOORMOOR port=5432');
        $query = "SELECT * FROM tents";
        $resource = pg_query($db_conn, $query);
        $result = pg_fetch_all($resource);
        echo("<table><tr>");
        $cols = ['Название', 'Фирма', 'Тип', 'Цена', 'Описание', 'Кол-во', 'Действия'];
        for ($i = 0; $i < sizeof($cols); $i++) {
            echo("<td>" . $cols[$i] . "</td>");
        }
        echo("</tr>");
        $cols = ['name', 'brand', 'type', 'price', 'desc', 'amount'];
        for ($i = 0; $i < sizeof($result); $i++) {
            echo("<tr>");
            $id = $result[$i]['name'];
            for ($j = 0; $j < sizeof($result[$i]); $j++) {
                echo "<td id='$cols[$j]_$id'>" . $result[$i][$cols[$j]] . "</td>";
            }
            echo("<td><button id='add_$id' onclick='addToCart(\"$id\")'>+</button> <span  id='am_$id'>0</span><button id='remove_$id' onclick='removeFromCart(\"$id\")'>-</button></td>");
            echo "</tr>";
        }
        echo("</table>");
        ?>
    </div>
    <div id="right">
        <div id="cart">
            <ul id="cartUL">
            </ul>
        </div>
       Итого: <span id="price">0</span>
    </div>
</body>
</html>
