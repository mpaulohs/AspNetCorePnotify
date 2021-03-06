﻿

$(function () {

    $.pnotify.defaults.styling = "bootstrap3";

    $("#msgs li").each(function () {
        $.pnotify({
            text: $(this).text().trim(),
            type: $(this).data("classe"),
            icon: "ui-icon ui-icon-comment",
            closer: true,
            history: false,
            width: "390px",
            before_open: function (pnotify) {
                pnotify.css({
                    "top": "50px",
                    "left": ($(window).width() / 2) - (pnotify.width() / 2)
                });
            }
        });
    });
});

function SendMessagePnotify(text, type) {
    $.pnotify.defaults.styling = "bootstrap3";
    $.pnotify({
        text: text,
        type: type,
        icon: "ui-icon ui-icon-comment",
        closer: true,
        history: false,
        width: "390px",
        before_open: function (pnotify) {
            pnotify.css({
                "top": "50px",
                "left": ($(window).width() / 2) - (pnotify.width() / 2)
            });
        }
    });
}



