var chck_sur= false; var chck_login = false; var chck_pass = false; var chck_tel = false; var chck_inn =false; var chck_chck = false; var chck_bd = false;

function sur(){
    var sur = document.getElementById('surname').value;
    var patt = /{3-20}[^0-9]/;
    chck_sur=patt.test(sur);
}
function login(){
    var login = document.getElementById('login').value;
    var patt = /{3-10}[^а-я] [^А-Я]/;
    chck_login = patt.test(login);
}
function pass(){
    var password = document.getElementById('pass').value;
    var patt = /{8-99}[A-Z][a-z][0-9]/
    chck_pass = patt.test(password);
}
function chck(){
    var password = document.getElementById('pass').value;
    var passcheck = document.getElementById('chck').value;
    if (password==passcheck) chck_chck = true; else chck_chck = false;
}
function bd(){
    var bd = document.getElementById('bd').value;
    if (bd!=="") chck_bd = true;
    else chck_bd = false;
}
function tel(){
    var tel = document.getElementById('tel').value;
    if (tel!="") chck_tel = true; else chck_tel = false;
}
function inn(){
    var inn = document.getElementById('INN').value;
    
}