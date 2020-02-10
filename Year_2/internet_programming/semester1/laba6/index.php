<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>UR MOM JUNIOR PHP PROGRAMMER</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>

    <div class="inputs">
        <form action="index.php" method="post">
            <input type="text" placeholder="Имя каталога" name="dirName"><br>
            <input type="text" placeholder="Файл 1" name="file1"><br>
            <input type="text" placeholder="Файл 2" name="file2"><br>
            <input type="text" placeholder="Файл 3" name="file3"><br>
            <input type="submit" value="Погналити" name="run">
        </form>
    </div>


    <?php
    if(isset($_POST['run'])) {

        $dirName = $_POST['dirName'];
        $file1Name = $_POST['file1'];
        $file2Name = $_POST['file2'];
        $file3Name = $_POST['file3'];

        $resultingFile = '';

        //first file
        $fileAd = $dirName . '/' . $file1Name;
        $memes = fopen($fileAd, "r") or die("Unable to open file!");
        $resultingFile = $resultingFile . fread($memes, filesize($fileAd)) . "\n";
        //second file
        $fileAd = $dirName . '/' . $file2Name;
        $memes = fopen($fileAd, "r") or die("Unable to open file!");
        $resultingFile = $resultingFile . fread($memes, filesize($fileAd)) . "\n";
        //third file
        $fileAd = $dirName . '/' . $file3Name;
        $memes = fopen($fileAd, "r") or die("Unable to open file!");
        $resultingFile = $resultingFile . fread($memes, filesize($fileAd)) . "\n";
        //writing the final file
        $fp = fopen($dirName . '/output.txt', "w");
        fwrite($fp, $resultingFile);
        fclose($fp);
        echo(" <div class='outism'> Подкаталоги этого каталога: <br>");
        $workFFS = scandir($dirName);
        $workFFS = glob($dirName . '/*' , GLOB_ONLYDIR);
        for($i = 0; $i < sizeof($workFFS); $i++){
            echo(basename($workFFS[$i]) . " <br>");
        }
    }


    ?>
</body>
</html>