<!DOCTYPE html>
<html>
<head>
    <title>МАГАЗ 228</title>
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

        <div id="addNewsDiv" class="divCock" onkeypress="validation(add)">
            <input type="text" id="addNewsDivHeader" placeholder="Заголовок"><br>
            <input type="text" id="addNewsDivKindaHeader" placeholder="Что-то типа заголовка""><br>
            <input type="text" id="addNewsDivTopic" placeholder="Тема"><br>
            <input type="date" id="addNewsDivDate" placeholder="Дата"><br>
            <textarea id="addNewsDivText" class="manyFields" placeholder="Содержание"></textarea><br>
            <button onclick="submitNews()" disabled>Опубликоватб</button>
        </div>

        <div id="deleteByIdDiv" class="divCock">
            <input type="text" id="deleteByIdField" placeholder="Id"><br>
            <button onclick="deleteById()">Удалить новость</button>
        </div>

        <div id="editByIdGetDiv" class="divCock">
            <input type="text" id="editByIdField"><br>
            <button onclick="editByIdGet()">Изменить новость</button>
        </div>

        <div id="editByIdEditDiv" class="divCock" onkeypress="validation(edit)">
            <input type="text" id="editNewsDivHeader" placeholder="Заголовок"><br>
            <input type="text" id="editNewsDivKindaHeader" placeholder="Что-то типа заголовка"><br>
            <input type="text" id="editNewsDivTopic" placeholder="Тема"> <br>
            <input type="date" id="editNewsDivDate" placeholder="Дата"><br>
            <textarea id="editNewsDivText" class="manyFields" placeholder="Содержание"></textarea><br>
            <button onclick="editNewsSubmit()" disabled>Опубликоватб</button>
        </div>
    </div>
</body>
</html>
