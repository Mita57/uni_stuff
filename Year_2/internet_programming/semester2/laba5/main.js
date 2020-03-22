function render(value) {
    var divs = ['getByIdDiv', 'getByDateDiv', 'addNewsDiv', 'deleteByIdDiv', 'editByIdGetDiv', 'editByIdEditDiv'];
    var selected = value + 'Div';
    divs.forEach(function (e) { return document.getElementById(e).style.display = 'none'; });
    document.getElementById(selected).style.display = 'block';
}
function getById() {
    if (!(document.getElementById('getByIdField'))) {
        alert('Укажите ID');
    }
    else {
        var id = document.getElementById('getByIdField').value;
        var xmlHTTP_1 = new XMLHttpRequest();
        xmlHTTP_1.open('get', 'http://laba5API/getById.php?id=' + id);
        xmlHTTP_1.send();
        xmlHTTP_1.onreadystatechange = function () {
            if (xmlHTTP_1.readyState == 4 && xmlHTTP_1.status == 200) {
                console.log(xmlHTTP_1.responseText);
                if (xmlHTTP_1.responseText == 'bad') {
                    document.getElementById('getByIdDivTextArea').innerHTML = 'Нет записи с таким Id';
                }
                else {
                    var resp = JSON.parse(xmlHTTP_1.responseText);
                    var article = '';
                    article += "<h1>" + resp[0].header + "</h1>";
                    article += "<h3>" + resp[0].kindaheader + "</h3>";
                    article += "<p>" + resp[0].text + "</p>";
                    article += "<h3>" + resp[0].topic + "</h3>";
                    article += resp[0].date;
                    document.getElementById('getByIdDivTextArea').innerHTML = article;
                }
            }
        };
    }
}
function getByDate() {
    if (!(document.getElementById('dateStart')) && !(document.getElementById('dateEnd'))) {
        alert("Выберите даты");
    }
    else {
        var start = document.getElementById('dateStart').value;
        var end = document.getElementById('dateEnd').value;
        var xmlHTTP_2 = new XMLHttpRequest();
        xmlHTTP_2.open('get', 'http://laba5API/getByDate.php?start=' + start + '&end=' + end);
        xmlHTTP_2.send();
        xmlHTTP_2.onreadystatechange = function () {
            if (xmlHTTP_2.readyState == 4 && xmlHTTP_2.status == 200) {
                if (xmlHTTP_2.responseText == 'bad') {
                    document.getElementById('getByDatesDivTextArea').innerText = 'Нет записей';
                }
                else {
                    var resp = JSON.parse(xmlHTTP_2.responseText);
                    var article = '';
                    for (var i = 0; i < resp.length; i++) {
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
        };
    }
}
function validation(type) {
    var flagHeader = document.getElementById(type + 'NewsHeader').value;
    var flagKinaHeader = document.getElementById(type + 'NewsKindaHeader').value;
    var flagNewsTopic = document.getElementById(type + 'NewsTopic').value;
    var flagNewsDate = document.getElementById(type + 'NewsDate').value;
    var flagNewsText = document.getElementById(type + 'NewsText').value;
    if (flagHeader && flagKinaHeader && flagNewsTopic && flagNewsDate && flagNewsText) {
        document.getElementById(type + 'NewsButton').disabled = false;
    }
    else {
        document.getElementById(type + 'NewsButton').disabled = true;
    }
}
function submitNews() {
    var header = document.getElementById('addNewsHeader').value;
    var kindaHeader = document.getElementById('addNewsKindaHeader').value;
    var text = document.getElementById('addNewsText').value;
    var topic = document.getElementById('addNewsTopic').value;
    var date = document.getElementById('addNewsDate').value;
    var params = "header=" + header + "&kindaHeader=" + kindaHeader + "&text=" + text + "&topic=" + topic + "&date=" + date;
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('POST', 'http://laba5API/addNews.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            if (xmlHTTP.responseText == 'good') {
                window.location.reload();
            }
        }
    };
}
function deleteById() {
    if (!document.getElementById('deleteByIdField').value) {
        alert('Укажите ID');
    }
    else {
        var params = 'id=' + document.getElementById('deleteByIdField').value;
        var xmlHTTP_3 = new XMLHttpRequest();
        xmlHTTP_3.open('POST', 'http://laba5API/deleteById.php');
        xmlHTTP_3.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
        xmlHTTP_3.send(params);
        xmlHTTP_3.onreadystatechange = function () {
            if (xmlHTTP_3.readyState == 4 && xmlHTTP_3.status == 200) {
                if (xmlHTTP_3.responseText == 'bad') {
                    alert('Такого ID не существует');
                }
                else {
                    alert('Успешно!');
                    document.getElementById('deleteByIdField').value = '';
                }
            }
        };
    }
}
function editByIdGet() {
    if (!document.getElementById('editByIdField').value) {
        alert("Укажите ID");
    }
    else {
        var id = document.getElementById('editByIdField').value;
        var xmlHTTP_4 = new XMLHttpRequest();
        xmlHTTP_4.open('get', 'http://laba5API/getById.php?id=' + id);
        xmlHTTP_4.send();
        xmlHTTP_4.onreadystatechange = function () {
            if (xmlHTTP_4.readyState == 4 && xmlHTTP_4.status == 200) {
                if (xmlHTTP_4.responseText == 'bad') {
                    alert("Такого ID не сущетсвует");
                }
                else {
                    var resp = JSON.parse(xmlHTTP_4.responseText);
                    document.getElementById('editByIdGetDiv').style.display = 'none';
                    document.getElementById('editByIdEditDiv').style.display = 'block';
                    document.getElementById('editNewsId').value = resp[0].id;
                    document.getElementById('editNewsHeader').value = resp[0].header;
                    document.getElementById('editNewsKindaHeader').value = resp[0].kindaheader;
                    document.getElementById('editNewsTopic').value = resp[0].topic;
                    document.getElementById('editNewsDate').value = resp[0].date;
                    document.getElementById('editNewsText').value = resp[0].text;
                }
            }
        };
    }
}
function editNewsSubmit() {
    var id = document.getElementById('editNewsId').value;
    var header = document.getElementById('editNewsHeader').value;
    var kindaHeader = document.getElementById('editNewsKindaHeader').value;
    var text = document.getElementById('editNewsText').value;
    var topic = document.getElementById('editNewsTopic').value;
    var date = document.getElementById('editNewsDate').value;
    var params = "id=" + id + "&header=" + header + "&kindaHeader=" + kindaHeader + "&text=" + text + "&topic=" + topic + "&date=" + date;
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('POST', 'http://laba5API/editNews.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            if (xmlHTTP.responseText == 'good') {
                window.location.reload();
            }
        }
    };
}
