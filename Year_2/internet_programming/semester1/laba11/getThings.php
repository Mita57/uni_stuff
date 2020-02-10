<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>GET MEMEZ</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="inputs">
        <form action="getThings.php" method="get">
            <select name="regions" id='regID'>
                <?php
                $handle = fopen("output.txt", "r");
                if ($handle) {
                    $states = [];
                    while (($line = fgets($handle)) != false) {
                        $parts = explode(';', $line);
                        if(!(in_array($parts[6], $states))) {
                            echo("<option value='" . $parts[6] . "'>" . $parts[6] . "</option>");
                            $states[] = $parts[6];
                        }
                    }
                }
                fclose($handle);
                ?>
                <input type="submit" name="run" value="Отправить">
            </select>
        </form>
        <?php
        if(isset($_GET['run'])){
            $handle = fopen("output.txt", "r");
            $names [] = [];
            if ($handle) {
                while (($line = fgets($handle)) != false) {
                    $parts = explode(';', $line);
                    if($parts[6] == $_GET['regions']){
                        $outism = $parts[1] . ' '. $parts[2] . ' ' . $parts[3];

                        if($parts[4] == 0){
                            $outism .= "1";
                        }
                        else{
                            $outism .= "0";
                        }
                        $names[] = $outism;
                        $outism = '';
                    }
                }
            }
            sort($names);
            for($i = 0; $i < sizeof($names) - 1; $i++){
                $gender = substr((string)$names[$i], -1);
                $names[$i] = substr((string)$names[$i],0,-1);
                if($gender == '0'){
                    echo ("<span class='tyan'>" . $names[$i] . '</span><br>');
                }
                else{
                    echo ("<span class='kun'>" . $names[$i] . '</span><br>');
                }
            }
        }
        ?>
    </div>

</body>
</html>
