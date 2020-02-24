<?php
$header = $_GET['q'];

$page = new HTMLPage();
$page->write($header);


class HTMLPage {
    function _construct($title) {
        echo("<html id='sasd'><head> <title> $title </title> <link rel='stylesheet' href='style.css'> <script src='main.js'></script></head>
        ");
    }

    function header() {
        echo("<header> Топ сайт <br>");
        $this->logo();
        echo("</header>");
    }

    function footer() {
        echo("<footer>@2020 Cockpyright lawl</footer>");
    }

    function logo() {
        echo("<img src='Logo.jpg'>");
    }

    function menu() {
        echo("<ul id='menu'>");
        $db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
        $query = "SELECT * FROM news";
        $resource = pg_query($db_conn, $query);
        $result = pg_fetch_all($resource);
        for ($i = 0; $i < sizeof($result); $i++) {
            $arg = '"' . $result[$i]['header'] . '"';
            echo("<li onclick='loadPage($arg)'>");
            echo $result[$i]['header'] . ', ';
            echo "</li>";
        }
        echo "</ul>";

    }

    function content($title) {
        $db_conn = pg_connect('host=localhost dbname=news user=postgres password=MOORMOOR port=5432');
        $query = "SELECT * FROM news WHERE header = '$title'";
        $resource = pg_query($db_conn, $query);
        $result = pg_fetch_all($resource);
        $cols = ['header', 'kindaheader', 'text', 'topic'];
        echo ("<article>");
        for ($i = 0; $i < sizeof($result[0]); $i++) {
            echo $result[0][$cols[$i]] . '<p>';
        }
        echo ("</article>");
    }

    function write($title) {
        $this->_construct($title);
        $this->header();
        $this->menu();
        $this->content($title);
        $this->footer();
        echo("</body></html>");
    }
}

?>
