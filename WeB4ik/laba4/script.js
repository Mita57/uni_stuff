var chck_forel=false, chck_telyatina=false, chck_soup=false, chck_roulet=false, chck_pizza=false, chck_cocktail=false, chck_grapefr=false;


function forel(){
 document.getElementById("imgus").innerHTML='<img src="forel.jpg">';
 if(document.getElementById("forel").checked) chck_forel=true; else chck_forel=false;
}

function telyatina(){
 document.getElementById("imgus").innerHTML='<img src="tel.jpg">';
 if (document.getElementById("telyatina").checked) chck_telyatina=true; else chck_telyatina=false;
  }

function soup(){
 document.getElementById("imgus").innerHTML='<img src="grib.jpg">';
 if (document.getElementById("soup").checked) chck_soup=true; else chck_soup=false;
  }

function roulet(){
 document.getElementById("imgus").innerHTML='<img src="shpin.jpg">';
 if (document.getElementById("roulet").checked) chck_roulet=true; else chck_roulet=false;
  }

function pizza(){
 document.getElementById("imgus").innerHTML='<img src="hell.jpg">';
 if (document.getElementById("pizza").checked) chck_pizza=true; else chck_pizza=false;
  }

function cocktail(){
 document.getElementById("imgus").innerHTML='<img src="cock.jpg">';
 if(document.getElementById("cocktail").checked) chck_cocktail=true; else chck_cocktail=false;

  }
function grapefr(){
 document.getElementById("imgus").innerHTML='<img src="grape.jpg">';
 if (document.getElementById("grapefr").checked) chck_grapefr=true;  else chck_grapefr=false;
  }
function count_irt(){
  sum=0;
  if(chck_forel) sum+=369; if(chck_telyatina) sum+=349; if(chck_soup) sum+=189; if (chck_roulet) sum+=179; if(chck_pizza) sum+=299; if(chck_cocktail) sum+=149; if(chck_grapefr) sum+=199;
  document.getElementById("kok").innerHTML=sum;
}
function final_count(){
  if(chck_forel==false && chck_telyatina==false && chck_soup==false && chck_roulet==false && chck_pizza==false && chck_cocktail==false && chck_grapefr==false) alert ("Вы не выбрали ни одного блюда"); else{
  var stroka="";
  if(chck_forel) stroka+="Фаршированная форель - 369 руб. <br>"
  if(chck_telyatina) stroka+="Телятина под соусом - 349 руб. <br>"
  if(chck_soup) stroka+="Крем-суп из шампиньонов - 189 руб. <br>"
  if(chck_roulet) stroka+="Рулет со шпинатом - 179 руб. <br>"
  if(chck_pizza) stroka+="Пицца гавайская - 299 руб. <br>"
  if (chck_cocktail) stroka+="Ванильный коктейль - 149 руб. <br> "
  if (chck_grapefr) stroka+="Напиток Грейпфрут - 199руб. <br>"
  sum=0;
  if(chck_forel) sum+=369; if(chck_telyatina) sum+=349; if(chck_soup) sum+=189; if (chck_roulet) sum+=179; if(chck_pizza) sum+=299; if(chck_cocktail) sum+=149; if(chck_grapefr) sum+=199;
  document.getElementById("final").style.display = "block";
  document.getElementById("final").innerHTML=stroka + "Итого: " + sum + " руб.";
  }
}
