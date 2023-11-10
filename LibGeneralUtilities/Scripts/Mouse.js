document.addEventListener('click', function (event) {
    let elem = event.target;
    let val = event.srcElement.innerHTML;
    let jsonObject =
    {
        Key: 'click',
        Value: val ,
        className: elem.className,
        id: elem.id,
        tagName: elem.tagName
    };
    debugger;
    //document.querySelector("#"+elem.id);
    event.target.style.backgroundColor = 'salmon';
    window.chrome.webview.postMessage(jsonObject);

});

