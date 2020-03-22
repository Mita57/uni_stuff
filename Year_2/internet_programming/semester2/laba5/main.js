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
        xmlHTTP_1.open('get', 'getById.php?id' + id);
        xmlHTTP_1.send();
        xmlHTTP_1.onreadystatechange = function () {
            if (xmlHTTP_1.readyState == 4 && xmlHTTP_1.status == 200) {
            }
        };
    }
}
