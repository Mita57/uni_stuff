function load(number) {
    var xmlHttp = new XMLHttpRequest();
    var params = "q = "+ number;
    xmlHttp.open("POST", "opened.php", true);
    xmlHttp.send(params);
}