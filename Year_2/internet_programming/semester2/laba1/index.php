<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>MEMEZ</title>
    <link rel="stylesheet" href="style.css">
    <script src="index.js"></script>
</head>
<body>
    <div class="inputs">
        <div id="id">
            <input type="text" placeholder="id" id="idValue"> <input type="button" value="Поиск по id" onclick="idSearch()"><br>
            <div id="idSearch"></div>
        </div>
        <div id="search">
            <input type="text" placeholder="Поиск" id="searchValue"> <input type="button" value="Поиск" onclick="searchSearch()"><br>
            <div id="searchSeach"></div>
        </div>
        <div id="conn">
            <?php
            include 'connect.php';
            echo connect_to_pg('localhost', 'news', 'postgres', 'MOORMOOR', '5432');
            ?>
        </div>
    </div>
</body>
</html>
