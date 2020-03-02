<!DOCTYPE html>
<html>
<head>
    <title>РЕГАЦА</title>
    <link rel="stylesheet" href="regMain.css">
    <script src="regMain.js"></script>
</head>
<body>
    <div id='form'>
        <input type='text' id='login' placeholder='Логин' onchange="checkInputs()"><br>
        <input type='text' id='email' placeholder='Email'onchange="checkInputs()"><br>
        <input type='text' id='pwrd' placeholder='Пароль'onchange="checkInputs()"><br>
        <button id='registrationBtn' onclick="register()" disabled>Зарегаца</button>
    </div>
</body>
</html>
        