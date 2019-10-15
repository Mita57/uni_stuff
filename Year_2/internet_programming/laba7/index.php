<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>PI KRUTO</title>
    <link rel="stylesheet"  href="style.css">
</head>
<body>

    <div class="inputs">
        <form action="index.php" method="post">
            <input type="date" name="date"><br>
            <input type="text" name="stuff" placeholder="Write what u w0nt to find"><br>
            <input type="submit" name="run" value="Let's do dis sh!t">
        </form>
    </div>


    <?php
    if(isset($_POST['run'])) {
        echo ('<div class="outism">');
        $date = $_POST['date'];
        $whatToLook = $_POST['stuff'];
        $dirName = join(explode('-', $date));
        $dirContains = scandir($dirName);
        $foundAny = false;
        for($i = 2; $i < sizeof($dirContains); $i++){
            $fileAd = $dirName . '/' . $dirContains[$i];
            $memes = fopen($fileAd, "r") or die("Unable to open file!");
            $currFile = fread($memes, filesize($fileAd));
            $currFileWords = explode(' ', $currFile);
            if(in_array($whatToLook, $currFileWords)){
                echo ($currFile);
                $foundAny = true;
            }
        }
        if(!$foundAny){
            echo ("We've nothing to show you :c");
        }
        echo ('</div>');
    }



    ?>
</body>
</html>