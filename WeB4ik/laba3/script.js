var format, paper;
var chck_am=false;

function count(){
var chck_form=true;
var chck_paper=true;
if (document.print.format.value=="ninex12") {format=8.5; chck_form=true} else
if (document.print.format.value=="tenx15") {format=10; chck_form=true} else 
if (document.print.format.value=="eighteenx24") {format=15.5; chck_form=true} else {alert("Выберите формат фотографий"); chck_form=false};
if (document.print.paper.value=="matt") {chck_paper=true}; if(document.print.paper.value=="gloss") {format+=1.5; chck_paper=true} else {alert("Выберите бумагу"); chck_paper=false};
if (chck_form|| chck_paper|| chck_am) 
    {
        var amount=document.print.amount.value;
        var sum=format*amount;
        document.getElementById("kek").innerHTML="Цена фотографии: "+format + "р. \nКоличество: " + amount + "шт. \nСумма заказа: " + sum +"р.";
    }
}

function chck_amount(){
    if (document.print.amount.value=="") alert("Введите количество фотографий"); else
    if (isNaN(document.print.amount.value)) alert("Проверьте правильность количества"); else chck_am=true;
}