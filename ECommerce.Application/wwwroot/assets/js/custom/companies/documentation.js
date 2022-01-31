﻿"use strict";
var KTLayoutDocumentation = {
    init: function (t) {
        ! function (t) {
            var e = t;
            if (void 0 === e && (e = document.querySelectorAll(".highlight")), e && e.length > 0)
                for (var n = 0; n < e.length; ++n) {
                    var i = e[n].querySelector(".highlight-copy");
                    i && new ClipboardJS(i, {
                        target: function (t) {
                            var e = t.closest(".highlight"),
                                n = e.querySelector(".tab-pane.active");
                            return null == n && (n = e.querySelector(".highlight-code")), n
                        }
                    }).on("success", (function (t) {
                        var e = t.trigger.innerHTML;
                        t.trigger.innerHTML = "copied", t.clearSelection(), setTimeout((function () {
                            t.trigger.innerHTML = e
                        }), 2e3)
                    }))
                }
        }(t)
    }
};
KTUtil.onDOMContentLoaded((function () {
    KTLayoutDocumentation.init()
}));