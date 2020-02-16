function idSearch():void {
    let xmlHTTP:XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('get', 'get_text_and_img.php?q=' + (document.getElementById('idValue') as HTMLInputElement).value);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('idSearch').innerHTML = xmlHTTP.responseText;
        }
    }
}

function searchSearch():void {
    let xmlHTTP:XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('get', 'search.php?q=' + (document.getElementById('searchValue') as HTMLInputElement).value);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('searchSeach').innerHTML = xmlHTTP.responseText;
        }
    }
}
