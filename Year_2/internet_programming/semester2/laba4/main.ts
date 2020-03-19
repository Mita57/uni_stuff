function verifyInputs(): void {
    if ((document.getElementById('loginInput') as HTMLInputElement).value && ((document.getElementById('pwrdInput') as HTMLInputElement).value)) {
        (document.getElementById('loginBtn') as HTMLButtonElement).disabled = false;
    } else {
        (document.getElementById('loginBtn') as HTMLButtonElement).disabled = true;
    }
}


function login(): void {
    let login: string = (document.getElementById('loginInput') as HTMLInputElement).value;
    let pwrd: string = (document.getElementById('pwrdInput') as HTMLInputElement).value;
    let params: string = 'login=' + login + "&pwrd=" + pwrd;
    let xmlHTTP: XMLHttpRequest = new XMLHttpRequest();
    xmlHTTP.open('post', 'authAJAX.php');
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            let resp: String = xmlHTTP.responseText;
            if (resp == 'good') {
                localStorage.setItem('user', login);
                document.getElementById('login').innerHTML = login;
            } else {
                alert('Lol ceque chebureque');
            }
        }
    }

}
