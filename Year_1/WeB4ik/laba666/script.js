var arr;

function check(){
    if (isNaN(document.getElementById("num").value)==true)
    {
        alert ("Проверьте число элементов массива")
        document.getElementById("crt").disabled=true;
        document.getElementById("calc").disabled=true;
    }
    else
    {
        document.getElementById("crt").disabled=false;
        document.getElementById("calc").disabled=false;
    }
}

function gener(){
    var am=document.getElementById("num").value;
    arr=[am];
    for (var i=0; i<am;i++)
    {
        arr[i]=Math.floor(Math.random() * 101);
        if(Math.random()<0.5) arr[i]=-arr[i];
    }
    document.lul.initial.value=arr;
}

function min(){
    var min=arr[0];
    for(var i=0;i<arr.length;i++)
    {
        if (min>arr[i]) min=arr[i];
    }
    document.getElementById("min_txt").value=min;
}

function max(){
    var max=arr[0];
    for(var i=0;i<arr.length;i++)
    {
        if(max<arr[i]) max=arr[i];
    }
    document.getElementById("max_txt").value=max;
}

function sum(){
    var sum=0;
    for(var i=0;i<arr.length;i++)
    {
        sum+=arr[i];
    }
    document.getElementById("sum_txt").value=sum;
}

function pos(){
    var am_pos=0;
    for(var i=0;i<arr.length;i++){
        if(arr[i]>=0) am_pos++;
    }
    document.getElementById("pos_txt").value=am_pos;
}

function neg(){
    var am_neg=0;
    for(var i=0; i<arr.length;i++){
        if(arr[i]<0)am_neg++;
    }
    document.getElementById("neg_txt").value=am_neg;
}

function asf(){
    if (document.getElementById("up").checked) arr.sort(function(a, b){return a - b});
    if (document.getElementById("down").checked)
    {
        arr.sort(function(a, b){return a - b});
        arr.reverse();
    }
    document.getElementById("end").value=arr;
    if (document.getElementById("min").checked) min();
    if (document.getElementById("max").checked) max();
    if (document.getElementById("sum").checked) sum();
    if (document.getElementById("pos").checked) pos();
    if (document.getElementById("neg").checked) neg();
}