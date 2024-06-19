//function scrollToBottom() {
//    window.scrollTo(0, document.body.scrollHeight);
//}

//// Call this function whenever you need to scroll to the bottom of the page
//scrollToBottom();

function humanScrollToBottom() {
    let interval = setInterval(() => {
        window.scrollBy(0, 50); // Scroll by 50 pixels every 100ms
        //if ((window.innerHeight + window.pageYOffset) >= document.body.offsetHeight) {
        //    clearInterval(interval); // Stop scrolling when the bottom is reached
        //}
    }, 100);
}

// Call this function to start human-like scrolling
humanScrollToBottom();
