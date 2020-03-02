function addToCart(id) {
    if (document.getElementById("amount_" + id).innerText != '0') {
        if (document.getElementById('am_' + id).innerText == '0') {
            document.getElementById('cartUL').innerHTML += "<li id='entry_" + id + "'>" + id + "; <span id='entryAm" + id + "'>" + 1 + "</li>";
            // @ts-ignore
            document.getElementById('am_' + id).innerText++;
            updatePrice(id, '+');
        }
        else {
            if (document.getElementById("amount_" + id).innerText !=
                document.getElementById('am_' + id).innerText) {
                // @ts-ignore
                document.getElementById('am_' + id).innerText++;
                // @ts-ignore
                document.getElementById('entryAm' + id).innerHTML++;
                updatePrice(id, '+');
            }
            else {
                alert("Wait, it's illegal");
            }
        }
    }
    else {
        alert("Wait, it's illegal");
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
        }
        else {
            // @ts-ignore
            document.getElementById('am_' + id).innerText--;
            document.getElementById("entry_" + id).outerHTML = '';
        }
        updatePrice(id, '-');
    }
}
function updatePrice(id, action) {
    var price = document.getElementById('price_' + id).innerText;
    switch (action) {
        case '+': {
            // @ts-ignore
            document.getElementById('price').innerText = price;
            break;
        }
        case '-': {
            // @ts-ignore
            document.getElementById('price').innerText -= price;
            break;
        }
    }
}
