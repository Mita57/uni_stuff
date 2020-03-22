function render(value: string): void {
    let divs: string[] = ['getByIdDiv', 'getByDateDiv', 'addNewsDiv', 'deleteByIdDiv', 'editByIdGetDiv', 'editByIdEditDiv'];
    let selected: string = value + 'Div';
    divs.forEach(e => document.getElementById(e).style.display = 'none');
    document.getElementById(selected).style.display = 'block';
}

function getById(): void {
    if (!(document.getElementById('getByIdField'))) {
        alert('Укажите ID');
    } else {
        let id: String = (document.getElementById('getByIdField') as HTMLInputElement).value;
        let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
        xmlHTTP.open('get', 'http://laba5API/getById.php?id=' + id);
        xmlHTTP.send();
        xmlHTTP.onreadystatechange = function () {
            if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
                console.log(xmlHTTP.responseText);
                if (xmlHTTP.responseText == 'bad') {
                    document.getElementById('getByIdDivTextArea').innerHTML = 'Нет записи с таким Id';
                } else {
                    var resp: object = JSON.parse(xmlHTTP.responseText);
                    let article: string = '';
                    article += "<h1>" + resp[0].header + "</h1>";
                    article += "<h3>" + resp[0].kindaheader + "</h3>";
                    article += "<p>" + resp[0].text + "</p>";
                    article += "<h3>" + resp[0].topic + "</h3>";
                    article += resp[0].date;
                    document.getElementById('getByIdDivTextArea').innerHTML = article;
                }
            }
        }
    }
}

function getByDate(): void {
    if (!(document.getElementById('dateStart')) && !(document.getElementById('dateEnd'))) {
        alert("Выберите даты");
    } else {
        let start: String = (document.getElementById('dateStart') as HTMLInputElement).value;
        let end: String = (document.getElementById('dateEnd') as HTMLInputElement).value;
        let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
        xmlHTTP.open('get', 'http://laba5API/getByDate.php?start=' + start + '&end=' + end);
        xmlHTTP.send();
        xmlHTTP.onreadystatechange = function () {
            if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
                if (xmlHTTP.responseText == 'bad') {
                    document.getElementById('getByDatesDivTextArea').innerText = 'Нет записей';
                } else {
                    var resp: object = JSON.parse(xmlHTTP.responseText);
                    let article: string = '';
                    for (let i = 0; i < resp.length; i++) {
                        article += "<h1>" + resp[i].header + "</h1>";
                        article += "<h3>" + resp[i].kindaheader + "</h3>";
                        article += "<p>" + resp[i].text + "</p>";
                        article += "<h3>" + resp[i].topic + "</h3>";
                        article += resp[i].date;
                        article += "<br>";
                    }
                    document.getElementById('getByDatesDivTextArea').innerHTML = article;
                }
            }
        }
    }
}

function validation(type: string): void {
    let flagHeader: string = (document.getElementById(type + 'NewsHeader') as HTMLInputElement).value;
    let flagKinaHeader: string = (document.getElementById(type + 'NewsKindaHeader') as HTMLInputElement).value;
    let flagNewsTopic: string = (document.getElementById(type + 'NewsTopic') as HTMLInputElement).value;
    let flagNewsDate: string = (document.getElementById(type + 'NewsDate') as HTMLInputElement).value;
    let flagNewsText: string = (document.getElementById(type + 'NewsText') as HTMLInputElement).value;
    if (flagHeader && flagKinaHeader && flagNewsTopic && flagNewsDate && flagNewsText) {
        (document.getElementById(type + 'NewsButton') as HTMLButtonElement).disabled = false;
    } else {
        (document.getElementById(type + 'NewsButton') as HTMLButtonElement).disabled = true;
    }
}

function submitNews(): void {
    let header: string = (document.getElementById('addNewsHeader') as HTMLInputElement).value;
    let kindaHeader: string = (document.getElementById('addNewsKindaHeader') as HTMLInputElement).value;
    let text: string = (document.getElementById('addNewsText') as HTMLTextAreaElement).value;
    let topic: string = (document.getElementById('addNewsTopic') as HTMLInputElement).value;
    let date: string = (document.getElementById('addNewsDate') as HTMLInputElement).value;

    let params: string = `header=${header}&kindaHeader=${kindaHeader}&text=${text}&topic=${topic}&date=${date}`;

    let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('POST', 'http://laba5API/addNews.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            if (xmlHTTP.responseText == 'good') {
                window.location.reload();
            }
        }
    }
}

function deleteById(): void {
    if (!(document.getElementById('deleteByIdField') as HTMLInputElement).value) {
        alert('Укажите ID')
    } else {
        let params: string = 'id=' + (document.getElementById('deleteByIdField') as HTMLInputElement).value;

        let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
        xmlHTTP.open('POST', 'http://laba5API/deleteById.php');
        xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlHTTP.send(params);
        xmlHTTP.onreadystatechange = function () {
            if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
                if(xmlHTTP.responseText == 'bad') {
                    alert('Такого ID не существует');
                }
                else {
                    alert ('Успешно!');
                    (document.getElementById('deleteByIdField') as HTMLInputElement).value = '';
                }
            }
        }
    }
}

function editByIdGet():void {
    if(!(document.getElementById('editByIdField') as HTMLInputElement).value) {
        alert("Укажите ID");
    }
    else {
        let id:String = (document.getElementById('editByIdField') as HTMLInputElement).value;

        let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();

        xmlHTTP.open('get', 'http://laba5API/getById.php?id=' + id);
        xmlHTTP.send();
        xmlHTTP.onreadystatechange = function () {
            if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
                if(xmlHTTP.responseText == 'bad') {
                    alert("Такого ID не сущетсвует");
                }
                else {
                    let resp = JSON.parse(xmlHTTP.responseText);

                    document.getElementById('editByIdGetDiv').style.display = 'none';
                    document.getElementById('editByIdEditDiv').style.display = 'block';

                    (document.getElementById('editNewsId') as HTMLInputElement).value = resp[0].id;
                    (document.getElementById('editNewsHeader')as HTMLInputElement).value = resp[0].header;
                    (document.getElementById('editNewsKindaHeader') as HTMLInputElement).value = resp[0].kindaheader;
                    (document.getElementById('editNewsTopic') as HTMLInputElement).value = resp[0].topic;
                    (document.getElementById('editNewsDate') as HTMLInputElement).value = resp[0].date;
                    (document.getElementById('editNewsText') as HTMLInputElement).value = resp[0].text;
                }
            }
        }
    }
}


function editNewsSubmit(): void {
    let id: string = (document.getElementById('editNewsId') as HTMLInputElement).value;
    let header: string = (document.getElementById('editNewsHeader') as HTMLInputElement).value;
    let kindaHeader: string = (document.getElementById('editNewsKindaHeader') as HTMLInputElement).value;
    let text: string = (document.getElementById('editNewsText') as HTMLTextAreaElement).value;
    let topic: string = (document.getElementById('editNewsTopic') as HTMLInputElement).value;
    let date: string = (document.getElementById('editNewsDate') as HTMLInputElement).value;

    let params: string = `id=${id}&header=${header}&kindaHeader=${kindaHeader}&text=${text}&topic=${topic}&date=${date}`;

    let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('POST', 'http://laba5API/editNews.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            if (xmlHTTP.responseText == 'good') {
                window.location.reload();
            }
        }
    }
}



