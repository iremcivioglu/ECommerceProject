"use strict";
var KTSignupGeneral = function () {
    var e, t, a, s, r,theContact = function () {
        return 100 === s.getScore()
    };
    return {
        init: function () {
            e = document.querySelector("#register-form"),
                t = document.querySelector("#register"),
                s = KTPasswordMeter.getInstance(e.querySelector('[data-kt-password-meter="true"]')),
                a = FormValidation.formValidation(e, {
                    fields: {
                        "Fullname": { validators: { notEmpty: { message: "Ýsim alaný zorunludur" } } },
                        "last-name": { validators: { notEmpty: { message: "Soyad alaný zorunludur" } } },
                        email: {
                            validators: {
                                notEmpty: { message: "Email adresi zorunludur" },
                                emailAddress: { message: "Girilen ifade bir email deðildir." }
                            }
                        },
                        password: {
                            validators: {
                                notEmpty: { message: "Þifre alaný zorunludur." },
                                callback: { message: "Please enter valid password", callback: function (e) { if (e.value.length > 0) return r() } }
                            }
                        },
                        "confirm-password": {
                            validators: {
                                notEmpty: { message: "The password confirmation is required" },
                                identical: { compare: function () { return e.querySelector('[name="password"]').value }, message: "The password and its confirm are not the same" }
                            }
                        },
                        toc: { validators: { notEmpty: { message: "You must accept the terms and conditions" } } }
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
                                            name: $("[name='Fullname']").val(),
                                            surname: $("[name='last-name']").val(),
                                            email: $("[name='email']").val(),
                                            password: $("[name='password']").val()
                                        };

                                    $.ajax({
                                        type: "POST",
                                        url: "https://localhost:44352/api/login/create",
                                        contentType: "application/json; charset=utf-8",
                                        data: JSON.stringify(theContact),
                                        dataType: "json",
                                        success: function (data) {
                                            Swal.fire({
                                                text: "Kayýt iþlemi baþarýyla gerçekleþti.",
                                                icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                                                customClass: { confirmButton: "btn btn-primary" }
                                            }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
                                        },
                                        error: function (data) {
                                            Swal.fire({
                                                text: "HATA! Sistem yöneticisi ile iletiþime geçiniz.",
                                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                                                customClass: { confirmButton: "btn btn-primary" }
                                            }).then((function (t) {
                                                t.isConfirmed && (e.reset(), s.reset())}))
                                        }

                                    });

                                }), 1500)) : Swal.fire({
                                    text: "HATA! Sistem yöneticisi ile iletiþime geçiniz. Metota girilmeyen hatalar.", 
              icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                                    customClass: { confirmButton: "btn btn-primary" }
                                }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
                        }))
                })),
                e.querySelector('input[name="password"]').addEventListener("input", (function () { this.value.length > 0 && a.updateFieldStatus("password", "NotValidated") }))
        }
    }
}(); KTUtil.onDOMContentLoaded((function () { KTSignupGeneral.init() }));