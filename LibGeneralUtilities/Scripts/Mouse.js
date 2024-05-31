document.addEventListener('click', function (event) {
    let elem = event.target;
    let val = event.srcElement.innerHTML;
    //let closestAnchor = elem.closest('a'); if you want to active this lines active them then copy mouse file to main project bin 
    //let href = closestAnchor ? closestAnchor.href : 'No parent <a> element';
    let jsonObject =
    {
        Key: 'click',
        Value: val ,
        className: elem.className,
        id: elem.id,
        tagName: elem.tagName,
        href: elem.href
    };
    debugger;
    //document.querySelector("#"+elem.id);
    event.target.style.backgroundColor = 'salmon';
    window.chrome.webview.postMessage(jsonObject);

});

