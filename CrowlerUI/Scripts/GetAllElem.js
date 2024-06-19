/*document.getElementsByTagName("*");*/

//var allHeadings = document.querySelectorAll("h1, h2, h3, h4, h5, h6");

var allHeadings = document.getElementsByTagName("*");


var file = new File([""], "elements.html");
var writer = new FileWriter();

for (var i = 0; i < allHeadings.length; i++) {
    writer.write(allHeadings[i].outerHTML);
}

writer.close();

//Good script
//"document.documentElement.textContent"
