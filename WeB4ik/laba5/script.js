var rub_dol=0.015; var eur_dol=1.14; var pnd_dol=1.32; var yen_dol=0.0089; var yun_dol=0.15; var hrivna_dol=0.037;
dol_dol=1; var course;


function czechoslovakia(){
    buba=document.getElementById("sum").value;
    if(isNaN(buba)==true) alert("Проверьте правильность ввода переводимой суммы"); else document.getElementById("knopka").disabled=false;
}



function courses(){
    var lil=document.transfer.from.value;
    switch (lil){
        case 'rub': course=rub_dol; break;
        case 'eur': course=eur_dol; break;
        case 'dol': course=dol_dol; break;
        case 'pnd': course=pnd_dol; break;
        case 'yen': course=yen_dol; break;
        case 'yun': course=yun_dol; break;
        case 'hrivna': course=hrivna_dol; break; //transferred to dollarZ
    }
    var lul = document.transfer.to.value;
    switch (lul){
        case 'rub': course/=rub_dol; break;
        case 'eur': course/=eur_dol; break;
        case 'dol': course/=dol_dol; break;
        case 'pnd': course/=pnd_dol; break;
        case 'yen': course/=yen_dol; break;
        case 'yun': course/=yun_dol; break;
        case 'hrivna': course/=hrivna_dol; break; //transferred to picked
    }
    course=Number((course).toFixed(2));
    document.transfer.lawl.value=course;
}


function count(){
    var sel = document.getElementById("shish");
    var text1= sel.options[sel.selectedIndex].text;
    var sal = document.getElementById("shush");
    var text2= sal.options[sal.selectedIndex].text;
    price = document.getElementById("sum").value;
    var final=price*course;
    document.getElementById("4eburek").innerHTML="Перевод " + text1 + (" - ") + text2 + " по курсу " + course + "\nК выдаче " + final; 
}