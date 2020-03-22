var cart = new Object();
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
                document.getElementById('loginInput').readOnly = true;
                loadCart();
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
    document.getElementById('cartUL').innerText = '';
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
function addToCart(id) {
    if (document.getElementById("amount_" + id).innerText != '0') {
        if (document.getElementById('am_' + id).innerText == '0') {
            document.getElementById('cartUL').innerHTML += "<li id='entry_" + id + "'>" + id + "; <span id='entryAm" + id + "'>" + 1 + "</li>";
            // @ts-ignore
            document.getElementById('am_' + id).innerText++;
            updatePrice();
            cart[id] = document.getElementById('entryAm' + id).innerHTML;
            writeCart();
        }
        else {
            if (document.getElementById("amount_" + id).innerText !=
                document.getElementById('am_' + id).innerText) {
                // @ts-ignore
                document.getElementById('am_' + id).innerText++;
                // @ts-ignore
                document.getElementById('entryAm' + id).innerHTML++;
                updatePrice();
                cart[id] = document.getElementById('entryAm' + id).innerHTML;
                console.log(cart);
                writeCart();
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
            cart[id] = document.getElementById('entryAm' + id).innerHTML;
            console.log(cart);
            writeCart();
        }
        else {
            // @ts-ignore
            document.getElementById('am_' + id).innerText--;
            document.getElementById("entry_" + id).outerHTML = '';
            delete cart[id];
            console.log(cart);
            writeCart();
        }
        updatePrice();
    }
}
function updatePrice() {
    var price = 0;
    Object.keys(cart).forEach(function (key) {
        var tag = parseInt(document.getElementById('price_' + key).innerText);
        var amount = parseInt(document.getElementById('am_' + key).innerText);
        price += tag * amount;
    });
    document.getElementById('result').innerText = price.toString();
}
function writeCart() {
    var login = localStorage.user;
    var cartJSON = JSON.stringify(cart);
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('post', 'updateCartAJAX.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send('login=' + login + '&cart=' + cartJSON);
    xmlHTTP.onreadystatechange = function () {
    };
}
function loadCart() {
    var xmlHTTP = new XMLHttpRequest();
    xmlHTTP.open('post', 'getCartAJAX.php');
    xmlHTTP.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xmlHTTP.send("login=" + localStorage.user);
    xmlHTTP.onreadystatechange = function () {
        if (xmlHTTP.readyState == 4 && xmlHTTP.status == 200) {
            cart = JSON.parse(xmlHTTP.responseText);
        }
        var innerHTML = "";
        Object.keys(cart).forEach(function (key) {
            document.getElementById('am_' + key).innerHTML = cart[key];
            innerHTML += "<li id='entry_" + key + "'>" + key + "; " +
                "<span id='entryAm" + key + "'>" + cart[key] + "</span>" + "</li>";
        });
        document.getElementById('cartUL').innerHTML = innerHTML;
        updatePrice();
    };
}
