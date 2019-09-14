function DB5(){
    document.getElementById("carName").value = "Aston Martin DB5 1963";
}
function Lotus(){
    document.getElementById("carName").value = "Lotus Espirit 1976";
}
function RR(){
    document.getElementById("carName").value = "Rolls-Royce Silver Shadow 1965";
}
function Jag(){
    document.getElementById("carName").value = "Jaguar E-Type 1961";
}
function clr(){
    document.getElementById("carName").value =  "";
}
var timer;
function start(){
    var order = [0,1,2,3];
    timer = setInterval(function(){
        for(var i =0;i<order.length;i++){
            order[i]++;
        }
        document.getElementById("block1").style.order = order[0]%4+1;
        document.getElementById("block2").style.order = order[1]%4+1;
        document.getElementById("block3").style.order = order[2]%4+1;
        document.getElementById("block4").style.order = order[3]%4+1;
    },500);

}
function stop(){
    clearInterval(timer);
}