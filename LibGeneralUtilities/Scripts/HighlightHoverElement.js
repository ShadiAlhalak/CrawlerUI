//// Function to enable highlighting
//function enableHighlighting() {
//    // Apply to all elements
//    document.querySelectorAll('*').forEach((element) => {
//        element.addEventListener('mouseover', (event) => {
//            // Highlight the hovered item with light cyan color
//            event.target.style.backgroundColor = '#E0FFFF'; // Light Cyan

//            // Undo highlight for all other items
//            document.querySelectorAll('*').forEach((el) => {
//                if (el !== event.target) {
//                    el.style.backgroundColor = '';
//                }
//            });
//        });

//        element.addEventListener('mouseout', (event) => {
//            // Undo highlight when mouse moves out of the browser
//            event.target.style.backgroundColor = '';
//        });
//    });

//    // Undo highlight when mouse moves out of the browser window
//    window.addEventListener('mouseout', (event) => {
//        if (event.relatedTarget === null) {
//            document.querySelectorAll('*').forEach((el) => {
//                el.style.backgroundColor = '';
//            });
//        }
//    });
//}

//enableHighlighting();

//// Function to enable highlighting
//function enableHighlighting() {
//    const hoverColor = '#E0FFFF'; // Light Cyan

//    // Apply to all elements
//    document.querySelectorAll('*').forEach((element) => {
//        element.addEventListener('mouseover', (event) => {
//            // Highlight the hovered item with light cyan color
//            event.target.style.backgroundColor = hoverColor;

//            // Undo highlight for all other items
//            document.querySelectorAll('*').forEach((el) => {
//                if (el !== event.target && el.style.backgroundColor === hoverColor) {
//                    el.style.backgroundColor = '';
//                }
//            });
//        });

//        element.addEventListener('mouseout', (event) => {
//            // Only change the background color if it's currently the hover color
//            if (event.target.style.backgroundColor === hoverColor) {
//                event.target.style.backgroundColor = '';
//            }
//        });
//    });

//    // Undo highlight when mouse moves out of the browser window
//    window.addEventListener('mouseout', (event) => {
//        if (event.relatedTarget === null) {
//            document.querySelectorAll('*').forEach((el) => {
//                if (el.style.backgroundColor === hoverColor) {
//                    el.style.backgroundColor = '';
//                }
//            });
//        }
//    });
//}

//// Add event listener to your button
//enableHighlighting();

// Function to enable highlighting
function enableHighlighting() {
    const hoverColor = '#E0FFFF'; // Light Cyan
    const excludedColor = 'salmon'; // Color that should not be changed on hover

    // Apply to all elements
    document.querySelectorAll('*').forEach((element) => {
        element.addEventListener('mouseover', (event) => {
            // Change the background color only if it's not salmon
            if (event.target.style.backgroundColor !== excludedColor) {
                event.target.style.backgroundColor = hoverColor;
            }

            // Undo highlight for all other items
            document.querySelectorAll('*').forEach((el) => {
                if (el !== event.target && el.style.backgroundColor === hoverColor) {
                    el.style.backgroundColor = '';
                }
            });
        });

        element.addEventListener('mouseout', (event) => {
            // Only change the background color if it's currently the hover color
            if (event.target.style.backgroundColor !== excludedColor) {
                event.target.style.backgroundColor = '';
            }
        });
    });

    // Undo highlight when mouse moves out of the browser window
    window.addEventListener('mouseout', (event) => {
        if (event.relatedTarget === null) {
            document.querySelectorAll('*').forEach((el) => {
                if (el.style.backgroundColor !== excludedColor) {
                    el.style.backgroundColor = '';
                }
            });
        }
    });
}

enableHighlighting();