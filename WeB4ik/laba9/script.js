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
    result.document.write('<div id="final_meme">');
    result.document.write(document.getElementById('hdr').value);
    result.document.getElementById('final_meme').style.color = txt_color;
    result.document.getElementsByTagName('body').style.color = color;
    result.document.write('<img src="') + picture+".jpg>";
    result.document.write(document.getElementById('sign').value);
}