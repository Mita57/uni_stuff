function shtuka() {
    let value:String = (<HTMLSelectElement>document.getElementById('querySelect')).value;
    switch (value) {
        case 'avg_and_xp': {
            document.getElementById('queryInput').style.display = 'none';
            break;
        }
        case 'prize_sum': {
            document.getElementById('queryInput').style.display = 'inline-block';
            (document.getElementById('queryInput') as HTMLInputElement).value = '';
            break;
        }
        case 'MROT': {
            document.getElementById('queryInput').style.display = 'inline-block';
            (document.getElementById('queryInput') as HTMLInputElement).value = '';
            break;
        }
    }
}

function request(){
    let value:string = (<HTMLSelectElement>document.getElementById('querySelect')).value;
    switch (value) {
        case 'avg_and_xp': {
            averageNoExp();
            break;
        }
        case 'prize_sum': {
            prizeSum((document.getElementById('queryInput') as HTMLInputElement).value);
            break;
        }
        case 'MROT': {
            MROT((document.getElementById('queryInput') as HTMLInputElement).value);
            break;
        }
    }
}
function averageNoExp() {
    let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'noExp');
    xmlHTTP.send();
    (document.getElementById('outism') as HTMLInputElement).innerText = xmlHTTP.responseText;
    console.log(xmlHTTP.responseText);
}

function prizeSum(pos:String) {
    let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'prize' + '?st=' + pos);
    xmlHTTP.send();
    (document.getElementById('outism') as HTMLInputElement).innerText = xmlHTTP.responseText;
    console.log(xmlHTTP.responseText);
}

function MROT(span:String) {
    let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'MROT' + '?span=' + span);
    xmlHTTP.send();
    (document.getElementById('outism') as HTMLInputElement).innerText = xmlHTTP.responseText;
    console.log(xmlHTTP.responseText);
}
