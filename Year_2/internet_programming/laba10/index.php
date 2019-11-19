<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Electonic commerciaon</title>
    <link href="htmls/main.css" rel="stylesheet">
</head>
<body>
    <div class="sas">
        <?php
        $memes = fopen("sites.json", "r") or die("Unable to open file!");
        $currFile = fread($memes, filesize("sites.json"));
        $stuff = json_decode($currFile);
        $counter = 0;
        $tags = [];
        $size = [];
        $opcs = [];
        $indexes = [];
        $index = 0;
        for ($i = 1; $i < 11; $i++) {
            $number = 'site' . $i;
            $counter += $stuff->$number->shown;
            $elems = $stuff->$number->tags;
            foreach ($elems as $X) {
                array_push($tags, $X);
                array_push($indexes, $index);
                $index++;
            }
        }
        for ($i = 0; $i < 11; $i++) {
            $number = 'site' . $i;
            $elems = $stuff->$number->tags;
            foreach ((array)$elems as $X) {
                array_push($size, ((int)($stuff->$number->shown / $counter * 250.)));
                array_push($opcs, ((($stuff->$number->shown / $counter * 250.))/50));
            }
        }
        shuffle($indexes);
        for ($i = 0; $i < sizeof($indexes); $i++) {
            echo('<div style="font-size:' . $size[$indexes[$i]] . '; opacity: '. $opcs[$indexes[$i]].'">' . $tags[$indexes[$i]] . ' </div>');
        }
        echo("</div>");
        ?>
    </div>
</body>
