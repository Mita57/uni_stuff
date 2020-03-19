<!DOCTYPE html>
<html>
<head>
    <title>РЕГАЦА</title>
    <link rel="stylesheet" href="regMain.css">
    <script src="regMain.js"></script>
</head>
<body>
    <div id='form'>
        <input type='text' id='login' placeholder='Логин' onkeypress="checkInputs()"><br>
        <input type='text' id='email' placeholder='Email' onkeypress="checkInputs()"><br>
        <input type='password' id='pwrd' placeholder='Пароль' onkeypress="checkInputs()"><br>
        <button id='registrationBtn' onclick="register()" disabled>Зарегаца</button>
        <button id='registrationBtn' onclick="window.location = '/'" >Абратна</button>
    </div>
</body>
</html>
