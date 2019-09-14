function checkMother(){
    //set picture
    var picture;
    if (document.getElementById("dog").checked) picture="doge";
    if (document.getElementById("cat").checked) picture = "cat";
    if (document.getElementById("fish").checked) picture = "fish";
    if (document.getElementById("flower").checked) picture = "flower";
    //set color of body
    var e = document.getElementById("body");
    var color = e[e.selectedIndex].value;
    var txt_ar = document.getElementsByName("txt_color");
    var txt_color;
    for(let i = 0;i<txt_ar.length;i++){
        if(txt_ar[i].checked){
            txt_color = txt_ar[i].value; 
            break;
        }
    }
    var result = "";
    result+=('<div id="final_meme" style="text-align:center; color:'+ txt_color+"; background-color:"+ color+'">');
    result+=(document.getElementById('hdr').value +"<br>");
    result+=('<img src="'+picture+'.jpg"> <br>');
    result+=(document.getElementById('sign').value +"<br>");
    result+=("</div>");
    document.getElementById('cheb').innerHTML = result;
}
