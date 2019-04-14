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
    var result = window.open("", "", "width=500pt,height=450pt");
    console.log(color);
    console.log(txt_ar);
    console.log(txt_color);
    result.document.writeln('<link rel="stylesheet" href="style.css">');
    result.document.writeln('<body id="final_meme" style="text-align:center; color:'+ txt_color+"; background-color:"+ color+'">');
    result.document.writeln(document.getElementById('hdr').value +"<br>");
    result.document.write('<img src="'+picture+'.jpg"> <br>');
    result.document.write(document.getElementById('sign').value +"<br>");
    result.document.writeln("</body>");
}