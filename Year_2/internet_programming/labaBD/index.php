<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>AVE POSTGRES</title>
    <link href="htmls/main.css" rel="stylesheet">
</head>
<body>
    <?php
    $dbconn = pg_connect('host=localhost dbname=staff user=postgres password=MOORMOOR port=5432')
    $query = pg_query($dbconn, 'SELECT * FROM staff')
    echo $query;
    ?>
</body>
</html>
