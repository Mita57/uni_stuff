<!DOCTYPE html>
<html>
<head>
    <title>МАГАЗ 228</title>
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
        $cols = ['Название', 'Фирма', 'Тип', 'Цена', 'Описание', 'Кол-во'];
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
            echo "</tr>";
        }
        echo("</table>");
        ?>
    </div>
    <div id="right">
        <div id="login">
            <input type="text" id="loginInput" placeholder="Логин" onchange="verifyInputs()">
            <input type="text" id="pwrdInput" placeholder="Пароль" onchange="verifyInputs()">
            <p></p>
            <button onclick="login()" disabled id="loginBtn">Войти</button>
            <button onclick="location.href='register.php'">Зарегаца</button>
        </div>

        <ul id="cart">
        </ul>
        Итого: <span id="result">0</span>
    </div>
</body>
</html>
