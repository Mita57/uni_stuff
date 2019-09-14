var chck1, chck2, chck3;
function chck_sum(){
    if(document.deposit.sum.value=="") alert("Введите сумму кредита"); else
    if (isNaN(document.deposit.sum.value)) alert("Проверьте правильность ввода суммы");else 
    chck1=true;
    if(chck1||chck2||chck3) document.deposit.knopka.disabled=false;
}
function chck_months(){
    if(document.deposit.months.value=="") alert("Введите количество месяцев"); else
    if(isNaN(document.deposit.months.value)) alert("Проверьте правильность количества месяцев"); else
    chck2=true
    if(chck1||chck2||chck3) document.deposit.knopka.disabled=false;
}
function chck_loan(){
    if(document.deposit.loan.value=="") alert ("Введите ставку"); else
    if(isNaN(document.deposit.loan.value)) alert("Проверьте правильность ввода ставки"); else
    chck3=true;
    if(chck1||chck2||chck3) document.deposit.knopka.disabled=false;
}
function count(){
    var sum=document.deposit.sum.value;
    var months=document.deposit.months.value;
    var loan=document.deposit.loan.value;
    var final_sum=sum*(loan/100/12)*months;
    document.deposit.final_sum.value=Math.round(final_sum);
}
