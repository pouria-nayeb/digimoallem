setTimeout(function () {
    $(".loader, .fa-circle-notch").css({
        "display": "none",
        "height": "0",
        "background": "none"
    });
    $(".container").css("display", "block");
}, 750);