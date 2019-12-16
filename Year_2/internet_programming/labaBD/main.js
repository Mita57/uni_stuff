function shtuka() {
    var value = document.getElementById('querySelect').value;
    switch (value) {
        case 'avg_and_xp': {
            document.getElementById('queryInput').style.display = 'none';
            break;
        }
        case 'prize_sum': {
            document.getElementById('queryInput').style.display = 'inline-block';
            document.getElementById('queryInput').value = '';
            break;
        }
        case 'MROT': {
            document.getElementById('queryInput').style.display = 'inline-block';
            document.getElementById('queryInput').value = '';
            break;
        }
    }
}
function request() {
    var value = document.getElementById('querySelect').value;
    switch (value) {
        case 'avg_and_xp': {
            averageNoExp();
            break;
        }
        case 'prize_sum': {
            prizeSum(document.getElementById('queryInput').value);
            break;
        }
        case 'MROT': {
            MROT(document.getElementById('queryInput').value);
            break;
        }
    }
}
function averageNoExp() {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'noExp');
    xmlHTTP.send();
    document.getElementById('outism').innerText = xmlHTTP.responseText;
    console.log(xmlHTTP.responseText);
}
function prizeSum(pos) {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'prize' + '?st=' + pos);
    xmlHTTP.send();
    document.getElementById('outism').innerText = xmlHTTP.responseText;
    console.log(xmlHTTP.responseText);
}
function MROT(span) {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'MROT' + '?span=' + span);
    xmlHTTP.send();
    document.getElementById('outism').innerText = xmlHTTP.responseText;
    console.log(xmlHTTP.responseText);
}
