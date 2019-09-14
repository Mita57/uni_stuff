function vyvod() {
    var Surname = document.anketa.surname.value;
    var name = document.anketa.name.value;
    var gender;
    if (document.anketa.gender.value == "male") gender = "Мужской"; else gender = "Женский";
    var age = document.anketa.age.value;
    var regged
    if (document.anketa.regged.value == "registered") regged = "Зарегестрированный пользователь";
    else regged = "Услугами магазина пользуется впервые";
    var spec;
    if (document.anketa.spech.checked) spec = "Прикладная информатика"; else spec = "Информационные системы и технологии"
    var city = document.anketa.town.value;
    var interested = "";
    if (document.anketa.books.checked) interested += " &#8226 Книги <br>";
    if (document.anketa.cd.checked) interested += " &#8226 Музыка на CD <br>";
    if (document.anketa.soft.checked) interested += " &#8226 Программное обеспечение <br>";
    if (document.anketa.canc.checked) interested += " &#8226 Канцелярские товары <br>";
    if (document.anketa.souvs.checked) interested += " &#8226 Сувениры <br>";
    if (document.anketa.others.value!=='') interested += ("&#8226 "+document.anketa.others.value);
    var ofs = document.anketa.offers.value;
    console.log(interested);
    document.writeln('<html><head><link rel="stylesheet" href="style.css"><title>');
    document.writeln('Документ HTML</title></head>');
    document.writeln('<body class="after_script">');
    document.writeln('<span class="pokup"> Информация о покупателе</span> <P>')
    document.writeln('<article> Фамилия: <span class="val">' + Surname + ' </span><p>'); //surname
    document.writeln('Имя:  <span class="val">' + name + '</span><p>');  //name
    document.writeln('Пол: <span class="val">' + gender + '</span><P>'); //gender
    document.writeln('Возраст: <span class="val">' + age + '</span><P>'); //age
    document.writeln('<span class="val">' + regged + '</span> <P>') //regged
    document.writeln('Специальность: <span class="val">' + spec + '</span> <P>'); //spec
    document.writeln('Город: <span class="val">' + city + '</span> <P>'); //city
    document.writeln('<span class="crit">Товары, представляющие интерес: </span> <P>');
    document.writeln('<span class="tovars">' + interested + '</span> <p>'); //entitites
    document.writeln('<p><span class="crit">  Пожелания покупателя: </span> <P>');
    document.writeln('<span class="val">' + ofs + "</span> </article> </body>");

}
