<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>GET MEMEZ</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="inputs">
        <form action="result.php" method="get">
            <input type="submit" name="run" value="Let's do dis sh!t">
            <select name="regions" id='regID'>
                <?php
                $handle = fopen("inputfile.txt", "r");
                if ($handle) {
                    while (($line = fgets($handle)) != false) {
                        $parts = explode(';', $line);
                        echo("<option value='>" . strtolower($parts[6]) . "'" . $parts[6] . "</option>");
                    }
                }
                fclose($handle);
                ?>
                <input type="submit" value="Отправить">
            </select>
        </form>
    </div>

</body>
</html>
