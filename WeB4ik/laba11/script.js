var counter=0;
function cock(){$("#ffs").on("keyup", function(event){
    event.preventDefault();
    if (event.keyCode===13){
        document.getElementById("memes").innerHTML+=('<div id = "p_' + counter + '" ondblclick="change('+"'"+'p_'+counter+"')"+'"><input type = "checkbox" id="a_'+counter+'" onChange = "imp('+"'p_"+counter +"'"+')">' +"<span id='s_"+counter+"'>"+ document.getElementById("ffs").value + '</span><img src = "remove.png" onClick = "remove('+"'p_"+counter +"'"+')"></div>' )
        document.getElementById("ffs").value='';
        counter++;
    }
})
}
function imp(id){
    $('#'+id).css({'color':'red', 'text-decoration':'underlined'});
    var chb=id.replace("p", "a");
    $('#'+chb).css('visibility','hidden');
}
function remove(id){
    $('#'+id).css('display','none');
}
function change(id){
    var spanid = id.replace("p", "s");
    var oldinf = $('#'+spanid).html();
    var prev = $('#'+id).html();
    $('#'+id).html("<input type ='text' id='cock' value="+ oldinf+">");
    $('#cock').focus();
    $('#cock').on("keyup", function(event){
        event.preventDefault();
        if(event.keyCode===13){
            var newVal = $('#cock').val();
            $('#'+id).html(prev);
            $('#'+spanid).text(newVal);
        }
    })
}