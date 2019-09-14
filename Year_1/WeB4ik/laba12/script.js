function headingColorSelect() {
    $('#heading').css({ 'background-color': 'blue', 'font-weight': 'bold', 'color': 'white' });
}
time = 1;
function JS() {
    if ($('#heading').text() != 'JavaScript') {
        deSelect();
        headingColorSelect();
        $('#heading').text("JavaScript");
        f_acc();
        $('#JS').css({ 'border': 'blue solid 3px' })
        setTimeout(function () {
            $('#info').text('JavaScript, often abbreviated as JS, is a high-level, interpreted programming language that conforms to the ECMAScript specification. JavaScript has curly-bracket syntax, dynamic typing, prototype-based object-orientation, and first-class functions.Alongside HTML and CSS, JavaScript is one of the core technologies of the World Wide Web.[9] JavaScript enables interactive web pages and is an essential part of web applications. The vast majority of websites use it,[10] and major web browsers have a dedicated JavaScript engine to execute it.');
        }, time);
        time = 700;
    }
}
function JQ() {
    if ($('#heading').text() != 'jQuery') {
        deSelect();
        headingColorSelect();
        $('#heading').text("jQuery");
        f_acc();
        $('#JQ').css({ 'border': 'blue solid 3px' });
        setTimeout(function () {
            $('#info').text("jQuery is a JavaScript library designed to simplify HTML DOM tree traversal and manipulation, as well as event handling, CSS animation, and Ajax. It is free, open-source software using the permissive MIT License. Web analysis (from 2017) indicates that it is the most widely deployed JavaScript library by a large margin. jQuery's syntax is designed to make it easier to navigate a document, select DOM elements, create animations, handle events, and develop Ajax applications. jQuery also provides capabilities for developers to create plug-ins on top of the JavaScript library. This enables developers to create abstractions for low-level interaction and animation, advanced effects and high-level, themeable widgets. The modular approach to the jQuery library allows the creation of powerful dynamic web pages and Web applications.");
        }, time);
        time = 700;
    }
}
function DOM() {
    if ($('#heading').text() != 'DOM') {
        deSelect();
        headingColorSelect();
        f_acc();
        $('#heading').text("DOM");
        $('#DOM').css({ 'border': 'blue solid 3px' });
        setTimeout(function () {
            $('#info').text("The Document Object Model (DOM) is a cross-platform and language-independent application programming interface that treats an XML document as a tree structure wherein each node is an object representing a part of the document. The DOM represents a document with a logical tree. Each branch of the tree ends in a node, and each node contains objects. DOM methods allow programmatic access to the tree; with them one can change the structure, style or content of a document. Nodes can have event handlers attached to them. Once an event is triggered, the event handlers get executed. The principal standardization of DOM was handled by the World Wide Web Consortium, which last developed a recommendation in 2004. WHATWG took over development of the standard, publishing it as a living document. The W3C now publishes stable snapshots of the WHATWG standard."); 1
        }, time);
        time = 700;
    }
}
function CSS() {
    if ($('#heading').text() != 'CSS') {
        deSelect();
        headingColorSelect();
        $('#heading').text("CSS");
        f_acc();
        $('#CSS').css({ 'border': 'blue solid 3px' });
        setTimeout(function () {
            $('#info').text("Cascading Style Sheets (CSS) is a style sheet language used for describing the presentation of a document written in a markup language like HTML. CSS is a cornerstone technology of the World Wide Web, alongside HTML and JavaScript. CSS is designed to enable the separation of presentation and content, including layout, colors, and fonts. This separation can improve content accessibility, provide more flexibility and control in the specification of presentation characteristics, enable multiple web pages to share formatting by specifying the relevant CSS in a separate .css file, and reduce complexity and repetition in the structural content.Separation of formatting and content also makes it feasible to present the same markup page in different styles for different rendering methods, such as on-screen, in print, by voice (via speech-based browser or screen reader), and on Braille-based tactile devices. CSS also has rules for alternate formatting if the content is accessed on a mobile device.");
        }, time);
        time = 700;
    }
}
function deSelect() {
    $(".tab").css({ 'border': '' });
}
function f_acc() {
    if ($('#info').text() != '') {
        $('#info').slideUp(700);
        $('#info').slideDown(700);
    }
    else {
        setTimeout(function () {
            $('#info').slideDown(700);
        }, 2)
    }
}
function kostyl() {
    $("#info").css({ 'display': 'none' });
}