//document.addEventListener('click', function (event) {
//    let modals = document.querySelectorAll('div[aria-modal="true"], .modal, .popup, .overlay, .dialog');
//    modals.forEach(modal => {
//        modal.style.display = 'none';
//    });
//});

document.addEventListener('click', function (event) {
    let modals = document.querySelectorAll(
        'div[aria-modal="true"], ' + // General modals
        'div[role="dialog"], ' + // ARIA role for dialogs
        'div[role="alertdialog"], ' + // ARIA role for alert dialogs
        'div[class*="modal"], ' + // Any class containing "modal"
        'div[class*="popup"], ' + // Any class containing "popup"
        'div[class*="overlay"], ' + // Any class containing "overlay"
        'div[class*="dialog"], ' + // Any class containing "dialog"
        'div[class*="banner"], ' + // Any class containing "banner"
        'div[class*="consent"], ' + // Any class containing "consent"
        'div[class*="offer"], ' + // Any class containing "offer"
        'div[class*="feedback"], ' + // Any class containing "feedback"
        'div[class*="survey"],' +// Any class containing "survey"
        ' .modal, .popup, .overlay, .dialog'
    );
    modals.forEach(modal => {
        modal.style.display = 'none';
    });
});

//// Function to hide modals and popups
//function hideModals() {
//    let modals = document.querySelectorAll(
//        'div[aria-modal="true"], ' + // General modals
//        'div[role="dialog"], ' + // ARIA role for dialogs
//        'div[role="alertdialog"], ' + // ARIA role for alert dialogs
//        'div[class*="modal"], ' + // Any class containing "modal"
//        'div[class*="popup"], ' + // Any class containing "popup"
//        'div[class*="overlay"], ' + // Any class containing "overlay"
//        'div[class*="dialog"], ' + // Any class containing "dialog"
//        'div[class*="banner"], ' + // Any class containing "banner"
//        'div[class*="consent"], ' + // Any class containing "consent"
//        'div[class*="offer"], ' + // Any class containing "offer"
//        'div[class*="feedback"], ' + // Any class containing "feedback"
//        'div[class*="survey"]' // Any class containing "survey"
//    );
//    modals.forEach(modal => {
//        modal.style.display = 'none';
//    });
//}

//// Override the style.display property
//Object.defineProperty(HTMLElement.prototype, 'style', {
//    get: function () {
//        return this._style || (this._style = new CSSStyleDeclaration());
//    },
//    set: function (value) {
//        if (this.tagName === 'DIV') {
//            value.display = 'none';
//        }
//        this._style = value;
//    }
//});

//// Override common methods used to show elements
//['show', 'showModal', 'open'].forEach(method => {
//    HTMLElement.prototype[method] = function () {
//        if (this.tagName === 'DIV') {
//            this.style.display = 'none';
//        }
//    };
//});

//// Override common jQuery methods if jQuery is used
//if (window.jQuery) {
//    jQuery.fn.show = function () {
//        return this.each(function () {
//            if (this.tagName === 'DIV') {
//                this.style.display = 'none';
//            }
//        });
//    };
//    jQuery.fn.fadeIn = function () {
//        return this.each(function () {
//            if (this.tagName === 'DIV') {
//                this.style.display = 'none';
//            }
//        });
//    };
//}

//// Add event listener to hide modals on click
//document.addEventListener('click', hideModals);

