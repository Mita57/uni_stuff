function checkInputs() {
    let emailCheck = false;
    let loginCheck = false;
    let pwrdCheck = false;

    if (document.getElementById('login').value) {
        loginCheck = true;
    }

    if (document.getElementById('email').value) {
        emailCheck = true;
    }

    if (document.getElementById('pwrd').value) {
        pwrdCheck = true;
    }

    if (loginCheck && emailCheck && pwrdCheck) {
        document.getElementById('registrationBtn').disabled = false;
    } else {
        document.getElementById('registrationBtn').disabled = true;
    }
}

function register() {
    var email = document.getElementById('email').value;
    var login = document.getElementById('login').value;
    var pwrd = document.getElementById('pwrd').value;
    var params = 'login=' + login + "&pwrd=" + pwrd + "&email=" + email;
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('post', '/registerAJAX.php/', true);
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            var resp = xmlHTTP.responseText;
            if (resp == 'good') {
                window.location = '/';

            } else {
                alert('lol ceque, vous assez des problemes');
            }
        }
    }
}
