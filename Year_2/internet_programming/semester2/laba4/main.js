function verifyInputs() {
    if (document.getElementById('loginInput').value && (document.getElementById('pwrdInput').value)) {
        document.getElementById('loginBtn').disabled = false;
    }
    else {
        document.getElementById('loginBtn').disabled = true;
    }
}
function login() {
    var login = document.getElementById('loginInput').value;
    var pwrd = document.getElementById('pwrdInput').value;
    var params = 'login=' + login + "&pwrd=" + pwrd;
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('post', 'auth_check.php');
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            var resp = xmlHTTP.responseText;
            if (resp == 'good') {
                localStorage.setItem('user', login);
                document.getElementById('login').innerHTML = login;
            }
            else {
                alert('Lol ceque chebureque');
            }
        }
    }
}
