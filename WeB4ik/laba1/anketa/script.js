function press()
{
    var txt_doc=document.getElementById("txt").value;
    var style_doc=document.getElementById("style").value;
    if (style_doc=="h1") document.getElementById("everything").innerHTML="<h1>" + txt_doc + "</h1>";
    if (style_doc=="h2") document.getElementById("everything").innerHTML="<h2>" + txt_doc + "</h2>";
    if (style_doc=="h3") document.getElementById("everything").innerHTML="<h3>" + txt_doc + "</h3>";
    if (style_doc=="text") document.getElementById("everything").innerHTML= txt_doc + "</p>";
}