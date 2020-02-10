function selectChanged() {
    if (document.getElementById('query').value == 'typeAll' || document.getElementById('query').value == 'quartal') {
        document.getElementById('query').style.width = '200px';
        document.getElementById('input').style.display = 'inline';
    } else {
        document.getElementById('query').style.width = '370px'
        document.getElementById('input').style.display = 'none';
    }
}

function query() {
    let query = document.getElementById('query').value;
    switch (query) {
        case 'typeAll' : {
            typeAll();
            break;
        }
        case 'rentorsAm': {
            rentorsAm();
            break;
        }
        case 'neverRented': {
            neverRented();
            break;
        }
        case 'moreThanThree': {
            moreThanThree();
            break;
        }
        case 'twoTimesOneYear': {
            twoTimesOneYear();
            break;
        }
        case 'objectsAmountSum': {
            objectsAmountSum();
            break;
        }
        case 'rentorsAll': {
            rentorsAll();
            break;
        }
        case 'quartal': {
            quartal();
            break;
        }
        case 'rentorsObj': {
            rentorsObj();
            break;
        }
        case 'nalog': {
            nalog();
            break;
        }

    }
}

function typeAll() {
    let type = document.getElementById('input').value;
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'typeAll.php?q=' + type);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }

}

function rentorsAm() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'rentorsAm.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            console.log(xmlHTTP.responseText);
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function neverRented() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'neverRented.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }

}

function moreThanThree() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'moreThanThree.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function twoTimesOneYear() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'twoTimesOneYear.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function objectsAmountSum() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'objectsAmountSum.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function rentorsAll() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'rentorsAll.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function quartal() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'quartal.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function rentorsObj() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'rentorsObj.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = xmlHTTP.responseText;
        }
    }
}

function nalog() {
    let xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'nalog.php');
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById('result').innerHTML = 'Ura, nalog';
        }
    }
}

//updates

function closeOverlay() {
    document.getElementById('overlay').style.display = 'none';
}

function updateObject(id) {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('overlay').innerHTML = "<input type='text' name='type' id='type' placeholder='Тип'>" +
        "<input type='text' name='price' id='price' placeholder='Цена'> <input type='text' id='desc' name='desc' placeholder='Описание'>" +
        "<input type='button' onclick='checkObject(" + id + ")'  value='Готово'> <input type='button' onclick='closeOverlay()'  value='Отмена'>";
}

function checkObject(id) {
    let typeCheck = false;
    let priceCheck = false;
    let descCheck = false;
    if (document.getElementById('type').value) {
        typeCheck = true;
    }
    if (!isNaN(document.getElementById('price').value)) {
        priceCheck = true;
    }
    if (document.getElementById('desc').value) {
        descCheck = true;
    }
    if (typeCheck && priceCheck && descCheck) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'updateObject.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                type: document.getElementById('type').value,
                price: document.getElementById('price').value,
                desc: document.getElementById('desc').value,
                id: id,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    } else {
        alert('Nope');
    }

}


function updateRentor(id) {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('overlay').innerHTML = "<input type='text' name='name' id='name' placeholder='Имя'>" +
        "<input type='button' onclick='checkRentor(" + id + ")'  value='Готово'> <input type='button' onclick='checkObject(id)'  value='Готово'>";

}

function checkRentor(id) {
    let nameCheck = false;
    if (document.getElementById('name').value) {
        nameCheck = true;
    }
    if (nameCheck) {
        let xmlHTTP = new XMLHttpRequest(id);
        xmlHTTP.open('POST', 'updateRentor.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                name: document.getElementById('name').value,
                id: id,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    } else {
        alert('Nope');
    }
}


function updateRental(id) {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('overlay').innerHTML = "<input type='text' name='period' id='period' placeholder='Период'>" +
        "<input type='text' name='object' id='object' placeholder='Объект'> " +
        "<input type='text' name='rentor' id='rentor' placeholder='Арендатор'> <input type='text' name='start' id='start' placeholder='Дата начала'> <input type='button' onclick='checkRental(id)'" +
        "  value='Готово'> <input type='button' onclick='checkObject(" + id + ")'  value='Готово'>";
}

function checkRental(id) {
    let rentorCheck = false;
    let objectCheck = false;
    let periodCheck = false;
    let beginCheck = false;
    if (!isNaN(document.getElementById('period').value)) {
        periodCheck = true;
    }
    if (document.getElementById('object').value) {
        objectCheck = true;
    }
    if (document.getElementById('rentor').value) {
        rentorCheck = true;
    }
    if (document.getElementById('start').value) {
        beginCheck = true;
    }
    if (periodCheck && objectCheck && rentorCheck && beginCheck) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'updateRentor.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                rentor: document.getElementById('rentor').value,
                obejct: document.getElementById('object').value,
                period: document.getElementById('period').value,
                begin: document.getElementById('start').value,
                id: id,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    } else {
        alert('Nope');
    }

}

//remove kebabs
function deleteObject(id) {
    if (confirm('Удалить объект ' + id + '?')) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'deleteObject.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                id: id,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    }
}

function deleteRentor(id) {
    if (confirm('Удалить арендодателя ' + id + '?')) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'deleteRentor.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                id: id,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    }
}

function deleteRental(id) {
    if (confirm('Удалить сдачу ' + id + '?')) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'deleteRental.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                id: id,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    }

}

//insertions

function addObject() {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('overlay').innerHTML = "<input type='text' name='type' id='type' placeholder='Тип'>" +
        "<input type='text' name='price' id='price' placeholder='Цена'> <input type='text' id='desc' name='desc' placeholder='Описание'>" +
        "<input type='button' onclick='checkAddObject()'  value='Готово'> <input type='button' onclick='closeOverlay()'  value='Отмена'>";
}

function checkAddObject() {
    let typeCheck = false;
    let priceCheck = false;
    let descCheck = false;
    if (document.getElementById('type').value) {
        typeCheck = true;
    }
    if (!isNaN(document.getElementById('price').value)) {
        priceCheck = true;
    }
    if (document.getElementById('desc').value) {
        descCheck = true;
    }
    if (typeCheck && priceCheck && descCheck) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'addObject.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                type: document.getElementById('type').value,
                price: document.getElementById('price').value,
                desc: document.getElementById('desc').value,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    } else {
        alert('Nope');
    }

}

function addRent() {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('overlay').innerHTML = "<input type='text' name='period' id='period' placeholder='Период'>" +
        "<input type='text' name='object' id='object' placeholder='Объект'> " +
        "<input type='text' name='rentor' id='rentor' placeholder='Арендатор'> <input type='text' name='start' id='start' placeholder='Дата начала'> <input type='button' onclick='checkRental(id)'" +
        "  value='Готово'>  <input type='button' onclick='checkAddRent()'  value='Готово'>";
}

function checkAddRent() {
    let rentorCheck = false;
    let objectCheck = false;
    let periodCheck = false;
    let beginCheck = false;
    if (!isNaN(document.getElementById('period').value)) {
        periodCheck = true;
    }
    if (document.getElementById('object').value) {
        objectCheck = true;
    }
    if (document.getElementById('rentor').value) {
        rentorCheck = true;
    }
    if (document.getElementById('start').value) {
        beginCheck = true;
    }
    if (periodCheck && objectCheck && rentorCheck && beginCheck) {
        let xmlHTTP = new XMLHttpRequest();
        xmlHTTP.open('POST', 'addRentor.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                rentor: document.getElementById('rentor').value,
                obejct: document.getElementById('object').value,
                period: document.getElementById('period').value,
                begin: document.getElementById('start').value,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    } else {
        alert('Nope');
    }

}

function addRentor() {
    document.getElementById('overlay').style.display = 'block';
    document.getElementById('overlay').innerHTML = "<input type='text' name='name' id='name' placeholder='Имя'>" +
        "<input type='button' onclick='checkAddRentor()'  value='Готово'> <input type='button' onclick='checkObject(id)'  value='Готово'>";
}

function checkAddRentor() {
    let nameCheck = false;
    if (document.getElementById('name').value) {
        nameCheck = true;
    }
    if (nameCheck) {
        let xmlHTTP = new XMLHttpRequest(id);
        xmlHTTP.open('POST', 'AddRentor.php');
        xmlHTTP.setRequestHeader('Content-Type', 'application/json');
        xmlHTTP.send(JSON.stringify(
            {
                name: document.getElementById('name').value,
            }
        ));
        xmlHTTP.onreadystatechange = function () {
            location.reload();
        }
    } else {
        alert('Nope');
    }
}
