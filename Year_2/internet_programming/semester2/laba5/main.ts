function render(value:string): void {
    let divs: string[] = ['getByIdDiv', 'getByDateDiv', 'addNewsDiv', 'deleteByIdDiv', 'editByIdGetDiv', 'editByIdEditDiv'];
    let selected:string = value + 'Div';
    divs.forEach(e => document.getElementById(e).style.display = 'none');
    document.getElementById(selected).style.display = 'block';
}

function getById(): void {
    if(!(document.getElementById('getByIdField'))) {
        alert('Укажите ID');
    }
    else {
        let id:String = (document.getElementById('getByIdField') as HTMLInputElement).value;
        let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
        xmlHTTP.open('get', 'getById.php?id' + id);
        xmlHTTP.send();
        xmlHTTP.onreadystatechange = function () {
            if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {

            }
        }
    }
}


