var counter=0;
function cock(){document.getElementById("ffs").addEventListener("keyup", function(event){
    event.preventDefault();
    if (event.keyCode===13){
        document.getElementById("memes").innerHTML+=('<div id = "p_' + counter + '" ondblclick="change('+"'"+'p_'+counter+"')"+'"><input type = "checkbox" id="a_'+counter+'" onChange = "imp('+"'p_"+counter +"'"+')">' +"<span id='s_"+counter+"'>"+ document.getElementById("ffs").value + '</span><img src = "remove.png" onClick = "remove('+"'p_"+counter +"'"+')"></div>' )
        document.getElementById("ffs").value='';
        counter++;
    }
})
}
function imp(id){
    document.getElementById(id).style.color = 'red';
    document.getElementById(id).style.textDecoration = 'underlined';
    var chb=id.replace("p", "a");
    document.getElementById(chb).style.visibility= "hidden";
}
function remove(id){
    document.getElementById(id).style.display = "none";
}
function change(id){
    var spanid = id.replace("p", "s");
    var oldinf = document.getElementById(spanid).innerHTML;
    var prev = document.getElementById(id).innerHTML;
    document.getElementById(id).innerHTML = "<input type ='text' id='cock' value="+ oldinf+">";
    document.getElementById('cock').focus();
    document.getElementById('cock').addEventListener("keyup", function(event){
        event.preventDefault();
        if(event.keyCode===13){
            var newVal = document.getElementById('cock').value;
            document.getElementById(id).innerHTML=prev;
            document.getElementById(spanid).innerText = newVal;
        }
    })
}