var counter = 0;
function cock() {
    $("#ffs").on("keyup", function (event) {
        event.preventDefault();
        if (event.keyCode === 13) {
            var checkEmail = false;
            var checkName = false;
            var checkPhone = false;
            var input = $("#ffs").val();
            var checkEmailRegex = /.{2,99}@.{2,99}/;
            checkEmail = checkEmailRegex.test(input);
            var checkNameRegex = /.{1,99}/;
            checkName = checkNameRegex.test(input);
            var checkPhoneRegex = /[0-9,+]{6,12}/;
            checkPhone = checkPhoneRegex.test(input);
            if (checkEmail && checkName && checkPhone) {
                document.getElementById("memes").innerHTML += ('<div id = "p_' + counter + '" ondblclick="change(' + "'"+"p_"+counter+  "')" + '"><input type = "checkbox" id="a_' + counter + '" onChange = "imp(' + "'p_" + counter + "'" + ')">' + "<span id='s_" + counter + "'>" + input + '</span><img src = "remove.png" onClick = "remove(' + "'p_" + counter + "'" + ')"></div>')
                document.getElementById("ffs").value = '';
                counter++;
            }
            if (!checkEmail) {
                alert("Неправильно введен Email");
            }
            if (!checkName) {
                alert("Неправильно введено имя");
            }
            if (!checkPhone) {
                alert("Неправильно введен телефон");
            }
        }
    })
}
function imp(id) {
    $('#' + id).css({ 'color': 'red', 'text-decoration': 'underlined' });
    var chb = id.replace("p", "a");
    $('#' + chb).css('visibility', 'hidden');
}
function remove(id) {
    $('#' + id).css('display', 'none');
}
function change(id) {
    var spanid = id.replace("p", "s");
    var oldinf = $('#' + spanid).text();
    console.log(oldinf);
    var prev = $('#' + id).html();
    $('#' + id).html("<input type ='text' id='cock'>");
    $('#cock').val(oldinf);
    $('#cock').focus();
    $('#cock').on("keyup", function (event) {
        event.preventDefault();
        if (event.keyCode === 13) {
            var checkEmail = false;
            var checkName = false;
            var checkPhone = false;
            var input = $("#cock").val();
            var checkEmailRegex = /.{2,99}@.{2,99}/;
            checkEmail = checkEmailRegex.test(input);
            var checkNameRegex = /.{1,99}/;
            checkName = checkNameRegex.test(input);
            var checkPhoneRegex = /[0-9,+]{6,12}/;
            checkPhone = checkPhoneRegex.test(input);
            if (checkEmail && checkName && checkPhone) {
                var newVal = $('#cock').val();
                $('#' + id).html(prev);
                $('#' + spanid).text(newVal);
            }
            if (!checkEmail) {
                alert("Неправильно введен Email");
            }
            if (!checkName) {
                alert("Неправильно введено имя");
            }
            if (!checkPhone) {
                alert("Неправильно введен телефон");
            }
        }
    })
}