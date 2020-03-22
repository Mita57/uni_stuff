<!DOCTYPE html>
<html>
<head>
    <title>LA FETE DES FOUS</title>
    <link rel="stylesheet" href="main.css">
    <script src="main.js"></script>
</head>
<body>
    <div id="top">
        <select id="globalSelect" onchange="render(this.value)">
            <option value="" selected disabled hidden></option>
            <option value="getById">Выборка новости по ее идентификатору</option>
            <option value="getByDate">Выборка новостей по дате</option>
            <option value="addNews">Добаление новости</option>
            <option value="deleteById">Удаление новости с указанным идентификатором</option>
            <option value="editByIdGet">Редактирование новости с указанным идентификатором</option>
        </select>
    </div>
    <div id="bottom">
        <div id="getByIdDiv" class="divCock">
            <input type="text" id="getByIdField" placeholder="Id">
            <button onclick="getById()">Получить новость</button>
            <br>
            <div id="getByIdDivTextArea" class="textCock"></div>
        </div>

        <div id="getByDateDiv" class="divCock">
            <input type="date" id="dateStart">
            <input type="date" id="dateEnd">
            <button onclick="getByDate()">Получить новости</button>
            <br>
            <div id="getByDatesDivTextArea" class="textCock"></div>
        </div>

        <div id="addNewsDiv" class="divCock" onkeypress="validation('add')">
            <input type="text" id="addNewsHeader" placeholder="Заголовок"><br>
            <input type="text" id="addNewsKindaHeader" placeholder="Что-то типа заголовка""><br>
            <input type="text" id="addNewsTopic" placeholder="Тема"><br>
            <input type="date" id="addNewsDate" placeholder="Дата"><br>
            <textarea id="addNewsText" class="manyFields" placeholder="Содержание"></textarea><br>
            <button onclick="submitNews()" id="addNewsButton" disabled>Опубликоватб</button>
        </div>

        <div id="deleteByIdDiv" class="divCock">
            <input type="text" id="deleteByIdField" placeholder="Id"><br>
            <button onclick="deleteById()">Удалить новость</button>
        </div>

        <div id="editByIdGetDiv" class="divCock">
            <input type="text" id="editByIdField"><br>
            <button onclick="editByIdGet()">Изменить новость</button>
        </div>

        <div id="editByIdEditDiv" class="divCock" onkeypress="validation('edit')">
            <input type="text" id="editNewsId" placeholder="Заголовок" readonly><br>
            <input type="text" id="editNewsHeader" placeholder="Заголовок"><br>
            <input type="text" id="editNewsKindaHeader" placeholder="Что-то типа заголовка"><br>
            <input type="text" id="editNewsTopic" placeholder="Тема"> <br>
            <input type="date" id="editNewsDate" placeholder="Дата"><br>
            <textarea id="editNewsText" class="manyFields" placeholder="Содержание"></textarea><br>
            <button onclick="editNewsSubmit()" id="editNewsButton" disabled>Поменять</button>
        </div>
    </div>
</body>
</html>
