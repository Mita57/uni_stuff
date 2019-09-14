var chck_sur = false; var chck_login = false; var chck_pass = false; var chck_tel = false; var chck_inn = false; var chck_chck = false; var chck_bd = false; var chck_gender = false;

function sur() {
    var sur = document.getElementById('surname').value;
    var patt = /[А-Я][а-я]{2,19}/;
    if (patt.test(sur)) {
        document.getElementById('famerr').style.visibility = "hidden";
        chck_sur = true;
    }
    else {
        document.getElementById('famerr').style.visibility = "visible";
        chck_sur = false;
    }
    unlock();
}

function log() {
    var login = document.getElementById('login').value;
    var patt = /[^а-я][^А-Я]{3,10}/;
    if (patt.test(login)) {
        document.getElementById('logerr').style.visibility = "hidden";
        chck_login = true;
    }
    else {
        document.getElementById('logerr').style.visibility = "visible";
        chck_login = false;
    }
    unlock();
}

function password() {
    var password = document.getElementById('pass').value;
    var patt = /[A-Za-z0-9]{8,99}/;
    if (patt.test(password)) {
        chck_pass = true;
        document.getElementById('paserr').style.visibility = "hidden";
    }
    else {
        document.getElementById('paserr').style.visibility = "visible";
        chck_pass = false;
    }
    unlock();
}

function chckc() {
    var password = document.getElementById('pass').value;
    var passcheck = document.getElementById('chck').value;
    if (password == passcheck) {
        chck_chck = true;
        document.getElementById('chckerr').style.visibility = "hidden";
    }
    else {
        chck_chck = false;
        document.getElementById('chckerr').style.visibility = "visible";
    }
    unlock();
}

function bd() {
    var bd = document.getElementById('bday').value;
    var patt = /(\d\d|\d)[-/.](\d\d|\d)[-/.](\d\d\d\d|\d\d)/;
    if (patt.test(bd)) {
        chck_bd = true;
        document.getElementById('bderr').style.visibility = "hidden";
    }
    else {
        chck_bd = false;
        document.getElementById('bderr').style.visibility = "visible";
    }
    unlock();
}

function tele() {
    var tel = document.getElementById('tel').value;
    var patt = /^(\(\d{3}\)?[\- ]?)?[\d\- ]{6,11}$/;
    if (patt.test(tel)) {
        chck_tel = true;
        document.getElementById('telerr').style.visibility = "hidden";
    }
    else {
        chcl_tel = false;
        document.getElementById('telerr').style.visibility = "visible";
    }
    unlock();
}

function inn() {
    var inns = document.getElementById('INN').value;
    if (isNaN(inns) &&(inns.length !== 10 || inns.length !== 12)) {
        chck_inn = false;
        document.getElementById('INNerr').style.visibility = "visible";
    }
    else
        if (inns.length = 10) {
            var sum = 0;
            var nums = inns.split('');
            sum += nums[0] * 2 + nums[1] * 4 + nums[2] * 10 + nums[3] * 3 + nums[4] * 5 + nums[5] * 9 + nums[6] * 4 + nums[7] * 6 + nums[8] * 8;
            if (sum % 11 == nums[9]) {
                chck_inn = true;
                document.getElementById('INNerr').style.visibility = "hidden";
            }
        }
        else {
            var sum1 = 0;
            var sum2 = 0;
            var nums = inns.split('');
            sum1 += nums[0] * 7 + nums[1] * 2 + nums[2] * 4 + nums[3] * 10 + nums[4] * 3 + nums[5] * 5 + nums[6] * 9 + nums[7] * 4 + nums[8] * 6 + nums[9] * 8;
            sum2 += nums[0] * 3 + nums[1] * 7 + nums[2] * 2 + nums[3] * 4 + nums[4] * 10 + nums[5] * 3 + nums[6] * 5 + nums[7] * 9 + nums[8] * 4 + nums[9] * 6 + nums[10] * 8;
            if (sum1 % 11 == nums[10] && sum2 % 11 == nums[11]) {
                chck_inn = true;
                document.getElementById('INNerr').style.visibility = "hidden";
            }
            else {
                document.getElementById('INNerr').visibility = "visibile";
                chck_inn = true;
            }
        }
        unlock();
    }

function gendera(){
    if(document.getElementById('male').checked||document.getElementById('female').checked) {
        chck_gender = true;
        document.getElementById('gendererr').style.visibility = "hidden";
    }
    else {chck_gender = false;
    document.getElementById('gendererr').style.visibility = "visible";
    }
    unlock();
}

function unlock(){
    if (chck_sur&&chck_login&&chck_pass&&chck_tel&&chck_inn&&chck_chck&&chck_bd&&chck_gender) document.getElementById('rega').disabled = false;
    else document.getElementById('rega').disabled = true;
}
function regged(){
    alert ("Hooray,u r regged!!");
}