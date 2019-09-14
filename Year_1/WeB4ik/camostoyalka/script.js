var pts = 0;
var flag1 = false, flag2 = false, flag3 = false, flag4 = false;
function chck1() {
    if(!document.test.id.checked&&!document.test.conc.checked&&!document.test.form.checked&&!document.test.exec.checked) alert("Не выбран вариант ответа"); else{
    if (document.test.form.checked) {
        pts += 1;
        document.getElementById('lol1').style.backgroundColor='lightgreen';
    }
    else document.getElementById('lol1').style.backgroundColor='palevioletred';
    document.getElementById('num1').disabled = true;
    flag1 = true;
    unblock();
}
}

function chck2() {
    if (!document.test.neuro.checked && !document.test.cont.checked && !document.test.sema.checked && !document.test.gen.checked) alert('Не выбран вариант ответа');
    else {
        if (document.test.neuro.checked) pts += 2;
        if (document.test.cont.checked) pts -= 1;
        if (document.test.sema.checked) pts -= 1;
        if (document.test.gen.checked) pts += 2;
        document.getElementById('num2').disabled = true;
        flag2 = true;
        unblock();
    }
}

function chck3() {
    var matlog = document.getElementById('mathlog').value;
    if (isNaN(matlog) == false) alert("Некорректные данные!"); else {
        if (matlog == 'S' || matlog == 's') {pts += 1;
            document.getElementById('lol3').style.backgroundColor='lightgreen';
        } else document.getElementById('lol3').style.backgroundColor='palevioletred';
        document.getElementById('num3').disabled = true;
        flag3 = true;
    }
    unblock();
}
function chck4() {
    var last = document.test.prizn.value;
    if (last == "algo"){ pts += 1;
        document.getElementById('lol4').style.backgroundColor='lightgreen';
    }
    else {pts /= 2;document.getElementById('lol4').style.backgroundColor='palevioletred';}
    document.getElementById('num4').disabled = true;
    flag4 = true;
    unblock();
}

function check() {
    var mark;
    if (pts < 3) mark = "Неудовлетворительно";
    if (pts == 4 || pts == 5) mark = "Хорошо";
    if (pts == 6 || pts == 7) mark = "Отлично";
    document.getElementById('result').style.visibility = 'visible';
    if (mark == 'хорошо' || mark == 'Отлично') document.getElementById('result').style.backgroundColor = 'green';
    else document.getElementById('result').style.backgroundColor = 'red';
    document.getElementById('result').innerHTML = "Ваше количество баллов: " + pts + "<br> Ваша оценка: " + mark;
}

function unblock() {
    if (flag1 && flag2 && flag3 && flag4) document.getElementById('handin').disabled = false;
    var out = "Количество баллов: " + pts;
    document.getElementById('points').innerHTML = out;
}

