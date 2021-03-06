"use strict";

var KTSignupGeneral = function () {
    var e, t, a, s, r,theContact = function () {
        return 100 === s.getScore()
    };
    return {
        init: function () {
            e = document.querySelector("#kt_sign_up_form"),
                t = document.querySelector("#kt_sign_up_submit"),
                s = KTPasswordMeter.getInstance(e.querySelector('[data-kt-password-meter="true"]')),
                a = FormValidation.formValidation(e, {
                    fields: {
                        "first-name": { validators: { notEmpty: { message: "?sim alan? zorunludur" } } },
                        /*"last-name": { validators: { notEmpty: { message: "Soyisim alan? zorunludur" } } },*/
                        email: {
                            validators: {
                                notEmpty: { message: "Email adresi zorunludur" },
                                emailAddress: { message: "Girilen ifade bir email de?ildir." }
                            }
                        },
                        password: {
                            validators: {
                                notEmpty: { message: "?ifre alan? zorunludur." },
                                callback: { message: "L?tfen ?ifre giriniz", callback: function (e) { if (e.value.length > 0) return r() } }
                            }
                        },
                        "confirm-password": {
                            validators: {
                                notEmpty: { message: "?ifrelerin e?le?mesi zorunludur." },
                                identical: { compare: function () { return e.querySelector('[name="password"]').value }, message: "?ifreler e?le?memektedir." }
                            }
                        },
                        toc: { validators: { notEmpty: { message: "S?zle?meyi kabul etmelisiniz" } } }
                    },
                    plugins: {
                        trigger: new FormValidation.plugins.Trigger({ event: { password: !1 } }),
                        bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
                    }
                }),
                t.addEventListener("click", (function (r) {                    
                    r.preventDefault(), a.revalidateField("password"),
                        a.validate().then((function (a) {
                            "Valid" == a ? (t.setAttribute("data-kt-indicator", "on"),
                                t.disabled = !0, setTimeout((function () {
                                    t.removeAttribute("data-kt-indicator"),
                                        t.disabled = !1,
                                        theContact = {
                                            UserName: $("[name='first-name']").val(),
                                            /*surname: $("[name='last-name']").val(),*/
                                            Email: $("[name='email']").val(),
                                            Password: $("[name='password']").val()
                                        };

                                    $.ajax({
                                        type: "POST",
                                        url: "https://localhost:44312/api/login/create/",
                                        contentType: "application/json; charset=utf-8",
                                        data: JSON.stringify(theContact),
                                        dataType: "json",
                                        success: function (data) {
                                            Swal.fire({
                                                text: "Kay?t i?lemi ba?ar?yla ger?ekle?ti.",
                                                icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                                customClass: { confirmButton: "btn btn-primary" }
                                            }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
                                        },
                                        error: function (data) {
                                            Swal.fire({
                                                text: "HATA! Sistem y?neticisi ile ileti?ime ge?iniz!'"+data+"'",
                                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                                customClass: { confirmButton: "btn btn-primary" }
                                            }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
                                        }

                                    });

                                }), 1500)) : Swal.fire({
                                    text: "HATA! Sistem y?neticisi ile ileti?ime ge?iniz! Metoda girilmeyen hatalar",
                                    icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                    customClass: { confirmButton: "btn btn-primary" }
                                }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
                        }))
                })),
                e.querySelector('input[name="password"]').addEventListener("input", (function () { this.value.length > 0 && a.updateFieldStatus("password", "NotValidated") }))
        }
    }
}(); KTUtil.onDOMContentLoaded((function () { KTSignupGeneral.init() }));