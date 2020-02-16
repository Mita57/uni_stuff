function idSearch() {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'get_text_and_img.php?q=' + document.getElementById('idValue').value);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var resposne = xmlHTTP.responseText;
            var responseParts = resposne.split('^');
            document.getElementById('idSearch').innerHTML = '';
            document.getElementById('idSearch').innerHTML = responseParts[0];
            document.getElementById('idSearch').innerHTML += '<br> <img src="' + responseParts[1] + '">';
        }
    };
}
function searchSearch() {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'search.php?q=' + document.getElementById('searchValue').value);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('searchSeach').innerHTML = xmlHTTP.responseText;
        }
    };
}
