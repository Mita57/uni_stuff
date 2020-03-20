let set: Set = new Set();


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
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            let resp: String = xmlHTTP.responseText;
            if (resp == 'good') {
                localStorage.setItem('user', login);
                document.getElementById('loginInput').innerText = login;
                document.getElementById('pwrdInput').style.display = 'none';
                document.getElementById('loginBtn').style.display = 'none';
                document.getElementById('registerBtn').style.display = 'none';
                document.getElementById('logoutBtn').style.display = 'block';
                (document.getElementById('login.Input') as HTMLInputElement).readOnly = true;
            } else {
                alert('Lol ceque chebureque');
            }
        }
    }
}

function logout(): void {
    localStorage.removeItem('user');
    document.getElementById('loginInput').innerText = null;
    (document.getElementById('loginInput') as HTMLInputElement).readOnly = false;
    document.getElementById('loginBtn').style.display = 'inline-block';
    document.getElementById('registerBtn').style.display = 'inline-block';
    document.getElementById('pwrdInput').style.display = 'inline-block';
}

function checkAuth(): void {
    if (localStorage.getItem('user')) {
        (document.getElementById('loginInput') as HTMLInputElement).value = localStorage.getItem('user');
        document.getElementById('pwrdInput').style.display = 'none';
        document.getElementById('loginBtn').style.display = 'none';
        document.getElementById('registerBtn').style.display = 'none';
        document.getElementById('logoutBtn').style.display = 'block';
        (document.getElementById('loginInput') as HTMLInputElement).readOnly = true;
        loadCart();
    }
}

function loadCart(): void {

}

function addToCart(id: String): void {
    if (document.getElementById("amount_" + id).innerText != '0') {
        if (document.getElementById('am_' + id).innerText == '0') {
            document.getElementById('cartUL').innerHTML += "<li id='entry_" + id + "'>" + id + "; <span id='entryAm" + id + "'>" + 1 + "</li>";
            // @ts-ignore
            document.getElementById('am_' + id).innerText++;
            updatePrice(id, '+');
            set.add({id: document.getElementById('am_' + id).innerText});
            console.log(set);
        } else {
            if (document.getElementById("amount_" + id).innerText !=
                document.getElementById('am_' + id).innerText) {
                // @ts-ignore
                document.getElementById('am_' + id).innerText++;
                // @ts-ignore
                document.getElementById('entryAm' + id).innerHTML++;
                updatePrice(id, '+');
                set.add({id: document.getElementById('am_' + id).innerText});
                console.log(set);
            } else {
                alert("Wait, it's illegal");
            }
        }
    }
}

function removeFromCart(id: String): void {
    if (document.getElementById("am_" + id).innerText != '0') {
        // @ts-ignore
        if (document.getElementById('am_' + id).innerText > 1) {
            // @ts-ignore
            document.getElementById('am_' + id).innerText--;
            // @ts-ignore
            document.getElementById('entryAm' + id).innerHTML--;
            set.add({id: document.getElementById('am_' + id).innerText});
            console.log(set);
        } else {
            // @ts-ignore
            document.getElementById('am_' + id).innerText--;
            document.getElementById("entry_" + id).outerHTML = '';
            set.add({id: document.getElementById('am_' + id).innerText});
            console.log(set);
        }
        updatePrice(id, '-');
    }
}

function updatePrice(id: String, action: String): void {
    let price: Number = parseInt(document.getElementById('price_' + id).innerText);
    switch (action) {
        case '+': {
            // @ts-ignore
            document.getElementById('price').innerText -= -price;
            break;
        }
        case '-': {
            // @ts-ignore
            document.getElementById('price').innerText -= price;
            break;
        }
    }
}

