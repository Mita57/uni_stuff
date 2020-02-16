function idSearch():void {
    let xmlHTTP:XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('get', 'get_text_and_img.php?q=' + (document.getElementById('idValue') as HTMLInputElement).value);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            let resposne:string = xmlHTTP.responseText;
            let responseParts = resposne.split('^');
            document.getElementById('idSearch').innerHTML = '';
            document.getElementById('idSearch').innerHTML = responseParts[0];
            document.getElementById('idSearch').innerHTML += '<br> <img src="' + responseParts[1] + '">';
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
