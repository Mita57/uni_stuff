var set = new Set();
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
    xmlHTTP.open('post', 'authAJAX.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send(params);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            var resp = xmlHTTP.responseText;
            if (resp == 'good') {
                localStorage.setItem('user', login);
                document.getElementById('loginInput').innerText = login;
                document.getElementById('pwrdInput').style.display = 'none';
                document.getElementById('loginBtn').style.display = 'none';
                document.getElementById('registerBtn').style.display = 'none';
                document.getElementById('logoutBtn').style.display = 'block';
                document.getElementById('login.Input').readOnly = true;
            }
            else {
                alert('Lol ceque chebureque');
            }
        }
    };
}
function logout() {
    localStorage.removeItem('user');
    document.getElementById('loginInput').innerText = null;
    document.getElementById('loginInput').readOnly = false;
    document.getElementById('loginBtn').style.display = 'inline-block';
    document.getElementById('registerBtn').style.display = 'inline-block';
    document.getElementById('pwrdInput').style.display = 'inline-block';
}
function checkAuth() {
    if (localStorage.getItem('user')) {
        document.getElementById('loginInput').value = localStorage.getItem('user');
        document.getElementById('pwrdInput').style.display = 'none';
        document.getElementById('loginBtn').style.display = 'none';
        document.getElementById('registerBtn').style.display = 'none';
        document.getElementById('logoutBtn').style.display = 'block';
        document.getElementById('loginInput').readOnly = true;
        loadCart();
    }
}
function loadCart() {
}
function addToCart(id) {
    if (document.getElementById("amount_" + id).innerText != '0') {
        if (document.getElementById('am_' + id).innerText == '0') {
            document.getElementById('cartUL').innerHTML += "<li id='entry_" + id + "'>" + id + "; <span id='entryAm" + id + "'>" + 1 + "</li>";
            // @ts-ignore
            document.getElementById('am_' + id).innerText++;
            updatePrice(id, '+');
            set.add({ id: document.getElementById('am_' + id).innerText });
            console.log(set);
        }
        else {
            if (document.getElementById("amount_" + id).innerText !=
                document.getElementById('am_' + id).innerText) {
                // @ts-ignore
                document.getElementById('am_' + id).innerText++;
                // @ts-ignore
                document.getElementById('entryAm' + id).innerHTML++;
                updatePrice(id, '+');
                set.add({ id: document.getElementById('am_' + id).innerText });
                console.log(set);
            }
            else {
                alert("Wait, it's illegal");
            }
        }
    }
}
function removeFromCart(id) {
    if (document.getElementById("am_" + id).innerText != '0') {
        // @ts-ignore
        if (document.getElementById('am_' + id).innerText > 1) {
            // @ts-ignore
            document.getElementById('am_' + id).innerText--;
            // @ts-ignore
            document.getElementById('entryAm' + id).innerHTML--;
            set.add({ id: document.getElementById('am_' + id).innerText });
            console.log(set);
        }
        else {
            // @ts-ignore
            document.getElementById('am_' + id).innerText--;
            document.getElementById("entry_" + id).outerHTML = '';
            set.add({ id: document.getElementById('am_' + id).innerText });
            console.log(set);
        }
        updatePrice(id, '-');
    }
}
function updatePrice(id, action) {
    var price = parseInt(document.getElementById('price_' + id).innerText);
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
