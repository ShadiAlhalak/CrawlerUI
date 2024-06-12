//var anchors = document.getElementsByTagName("a")
//for (var i = 0; i < anchors.length; i++) {
//    anchors[i].onclick = function () { return false; };
//    //anchors[i].addEventListener('click', function (event) {
//    // Prevent the default action
//    //    event.preventDefault();
//    //});
//}

// Get all <a>, <button>, and <form> elements
let elements = document.querySelectorAll('a,button,form,img,h2');//,img ,span

// Loop through all elements
for (let i = 0; i < elements.length; i++) {
    // Add an event listener to each element
    debugger;
    elements[i].addEventListener('click', function (event) {
        // Prevent the default action
        debugger;
        event.preventDefault();
        return false;
    });
}

// a {
//     pointer-events:none;
// }