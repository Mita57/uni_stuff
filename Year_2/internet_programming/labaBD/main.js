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
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var outism = '';
            var meme = (JSON.parse(xmlHTTP.responseText));
            for (var i = 0; i < meme.length; i++) {
                outism += meme[i].fullname + ' ';
            }
            document.getElementById('outism').innerText = outism;
        }
    };
}
function prizeSum(pos) {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'prize' + '&st=' + pos);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var outism = '';
            console.log(xmlHTTP.responseText);
            var meme = (JSON.parse(xmlHTTP.responseText));
            for (var i = 0; i < meme.length; i++) {
                outism += meme[i].sum + ' ';
            }
            document.getElementById('outism').innerText = outism;
        }
    };
}
function MROT(span) {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('get', 'query.php?q=' + 'MROT' + '&span=' + span);
    xmlHTTP.send();
    xmlHTTP.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var outism = '';
            var meme = (JSON.parse(xmlHTTP.responseText));
            for (var i = 0; i < meme.length; i++) {
                outism += meme[i].fullname + ' ';
            }
            document.getElementById('outism').innerText = outism;
        }
    };
}
