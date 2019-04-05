var diff=0;
function days(){
    var begin = new Date(document.getElementById('start').value);
    var end = new Date(document.getElementById('end').value);
    diff = end-begin;
    diff = diff/1000/60/60/24;
    document.cock.res.value = diff;
}   
var count_w=0;
function weekends(){
    var begin = new Date(document.getElementById('start').value);
    var end = new Date(document.getElementById('end').value);
    while (begin.getTime()<end.getTime()){
        var day = begin.getDay();
        if(day==0||day==6) count_w++;
        begin.setTime(begin.getTime()+1000 * 60 * 60 * 24);    
    }   
    document.cock.res.value = count_w;
    
}
function working(){
    var begin = new Date(document.getElementById('start').value);
    var end = new Date(document.getElementById('end').value);
    diff = end-begin;
    while (begin.getTime()<end.getTime()){
        var day = begin.getDay();
        if(day==0||day==6) count_w++;
        begin.setTime(begin.getTime()+1000 * 60 * 60 * 24);    
    }  
    diff=diff/1000/60/60/24;
    var work = diff-count_w;
    document.cock.res.value=work;
}
function weekz(){    
    var begin = new Date(document.getElementById('start').value);
    var end = new Date(document.getElementById('end').value);
    diff = end-begin;
    diff = diff/1000/60/60/24;
    var weeks = diff/7;
    document.cock.res.value = Math.floor(weeks);
}
function monthz(){
    var begin = new Date(document.getElementById('start').value);
    var end = new Date(document.getElementById('end').value);
    var diff =(begin.getTime() - end.getTime()) / 1000;
    diff /= (60 * 60 * 24 * 7 * 4);
    document.cock.res.value = Math.floor(Math.abs(diff));
}
function duhast(){
    if (document.getElementById('days').checked) days();
    if (document.getElementById('weekends').checked) weekends();
    if (document.getElementById('working').checked) working();
    if (document.getElementById('weeks').checked) weekz();
    if (document.getElementById('months').checked) monthz();
}