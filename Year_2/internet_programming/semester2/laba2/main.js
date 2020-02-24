function loadPage(header) {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'html.php?q=' + header);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('sasd').innerHTML = xmlHTTP.responseText;
        }
    }
}
