////"use strict";
////var KTUsersAddUser = function () {
////    const t = document.getElementById("kt_modal_add_company"),
////        e = t.querySelector("#kt_modal_add_company_form"),
////        n = new bootstrap.Modal(t);
////    var company, number;
////    return {
////        init: function () {
////            (() => {
////                var o = FormValidation.formValidation(e, {
////                    fields: {
////                        customer_name: {
////                            validators: {
////                                notEmpty: {
////                                    message: "Vergi kimlik numarasý zorunludur."
////                                }
////                            }
////                        },
////                        customer_surname: {
////                            validators: {
////                                notEmpty: {
////                                    message: "Þirket ismi zorunludur."
////                                }
////                            }
////                        },
////                        customer_adress: {
////                            validators: {
////                                notEmpty: {
////                                    message: "Adres zorunludur."
////                                }
////                            }
////                        },

////                        phone_number: {
////                            validators: {
////                                notEmpty: {
////                                    message: "Adres zorunludur."
////                                }
////                            }
////                        },

////                        email: {
////                            validators: {
////                                notEmpty: {
////                                    message: "Adres zorunludur."
////                                }
////                            }
////                        },

////                        plugins: {
////                            trigger: new FormValidation.plugins.Trigger,
////                            bootstrap: new FormValidation.plugins.Bootstrap5({
////                                rowSelector: ".fv-row",
////                                eleInvalidClass: "",
////                                eleValidClass: ""
////                            })
////                        }
////                    });
////                const i = t.querySelector('[data-kt-users-modal-action="submit"]');
////                i.addEventListener("click", (t => {
////                    t.preventDefault(),
////                        o && o.validate().then((function (t) {
////                            console.log("validated!"), "Valid" == t ? (i.setAttribute("data-kt-indicator", "on"),
////                                i.disabled = !0, setTimeout((function () {
////                                    i.removeAttribute("data-kt-indicator"),
////                                        i.disabled = !1,
////                                        number = parseInt($("[name='company_citizen_number']").val());
////                                    company = {
////                                        /*companynumber: number,*/
////                                        customerName: $("[name='customer_name']").val(),
////                                        customerSurname: $("[name='customer_surname']").val(),
////                                        customerName: $("[name='customer_name']").val(),
////                                        address: $("[name='company_address']").val()
////                                    };
////                                    console.log("data", JSON.stringify(company));
////                                    $.ajax({
////                                        type: "POST",
////                                        url: "https://localhost:44312/api/customer/create",
////                                        contentType: "application/json; charset=utf-8",
////                                        data: JSON.stringify(company),
////                                        dataType: "json",
////                                        success: function (data) {
////                                            Swal.fire({
////                                                text: "Kayýt iþlemi baþarýyla gerçekleþti.",
////                                                icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
////                                                customClass: { confirmButton: "btn btn-primary" }
////                                            }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
////                                        },
////                                        error: function (data) {
////                                            Swal.fire({
////                                                text: "HATA! Sistem yöneticisi ile iletiþime geçiniz!'" + data + "'",
////                                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
////                                                customClass: { confirmButton: "btn btn-primary" }
////                                            }).then((function (t) { t.isConfirmed && (e.reset(), s.reset()) }))
////                                        }

////                                    });
////                                }), 2e3)) : Swal.fire({
////                                    text: "HATA! Sistem yöneticisi ile iletiþime geçiniz! Henüz post metoduna girilmedi.",
////                                    icon: "error",
////                                    buttonsStyling: !1,
////                                    confirmButtonText: "Ok, got it!",
////                                    customClass: {
////                                        confirmButton: "btn btn-primary"
////                                    }
////                                })
////                        }))
////                })), t.querySelector('[data-kt-users-modal-action="cancel"]').addEventListener("click", (t => {
////                    t.preventDefault(), Swal.fire({
////                        text: "Ýptal etmek istediðinize emin misiniz?",
////                        icon: "warning",
////                        showCancelButton: !0,
////                        buttonsStyling: !1,
////                        confirmButtonText: "Evet, iptal et!",
////                        cancelButtonText: "Hayýr",
////                        customClass: {
////                            confirmButton: "btn btn-primary",
////                            cancelButton: "btn btn-active-light"
////                        }
////                    }).then((function (t) {
////                        t.value ? (e.reset(), n.hide()) : "cancel" === t.dismiss && Swal.fire({
////                            text: "Ýþlem iptal ediliyor!.",
////                            icon: "error",
////                            buttonsStyling: !1,
////                            confirmButtonText: "Devam et!",
////                            customClass: {
////                                confirmButton: "btn btn-primary"
////                            }
////                        })
////                    }))
////                })), t.querySelector('[data-kt-users-modal-action="close"]').addEventListener("click", (t => {
////                    t.preventDefault(), Swal.fire({
////                        text: "Ýptal etmek istediðinize emin misiniz?",
////                        icon: "warning",
////                        showCancelButton: !0,
////                        buttonsStyling: !1,
////                        confirmButtonText: "Yes, cancel it!",
////                        cancelButtonText: "No, return",
////                        customClass: {
////                            confirmButton: "btn btn-primary",
////                            cancelButton: "btn btn-active-light"
////                        }
////                    }).then((function (t) {
////                        t.value ? (e.reset(), n.hide()) : "cancel" === t.dismiss && Swal.fire({
////                            text: "Ýþlem iptal ediliyor!.",
////                            icon: "error",
////                            buttonsStyling: !1,
////                            confirmButtonText: "Ok, got it!",
////                            customClass: {
////                                confirmButton: "btn btn-primary"
////                            }
////                        })
////                    }))
////                }))
////            })()
////        }
////    }
////}();
////KTUtil.onDOMContentLoaded((function () {
////    KTUsersAddUser.init()
////}));

"use strict";
var KTSignupGeneral = function () {
    var e, t, a, s, r, theContact = function () {
        return 100 === s.getScore()
    };
    return {
        init: function () {
            e = document.querySelector("#kt_modal_add_customer_form"),
                t = document.querySelector("#kt_customer_submit"),
                s = KTPasswordMeter.getInstance(e.querySelector('[data-kt-password-meter="true"]')),
                a = FormValidation.formValidation(e, {
                    fields: {
                        customer_name: {
                            validators: {
                                notEmpty: {
                                    message: "Vergi kimlik numarasý zorunludur."
                                }
                            }
                        },
                        customer_surname: {
                            validators: {
                                notEmpty: {
                                    message: "Þirket ismi zorunludur."
                                }
                            }
                        },
                        customer_adress: {
                            validators: {
                                notEmpty: {
                                    message: "Adres zorunludur."
                                }
                            }
                        },

                        phone_number: {
                            validators: {
                                notEmpty: {
                                    message: "Adres zorunludur."
                                }
                            }
                        },

                        email: {
                            validators: {
                                notEmpty: {
                                    message: "Adres zorunludur."
                                }
                            }
                        },
                    },
                    plugins: {
                        trigger: new FormValidation.plugins.Trigger({ event: { password: !1 } }),
                        bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
                    }
                }),
                t.addEventListener("click", (function (r) {

                    r.preventDefault(), a.revalidateField("address")
                    a.validate().then((function (a) {
                        "Valid" == a ? (t.setAttribute("data-kt-indicator", "on"),
                            t.disabled = !0, setTimeout((function () {
                                t.removeAttribute("data-kt-indicator"),
                                    t.disabled = !1,
                                    theContact = {
                                        customerName: $("[name='customer_name']").val(),
                                        customerSurname: $("[name='customer_surname']").val(),
                                        customerAdress: $("[name='customer_adress']").val(),
                                        phoneNumber: $("[name='phone_number']").val(),
                                        email: $("[name='email']").val()
                                    };

                                $.ajax({
                                    type: "POST",
                                    url: "https://localhost:44304/api/customer/create",
                                    contentType: "application/json; charset=utf-8",
                                    data: JSON.stringify(theContact),
                                    dataType: "json",
                                    success: function (data) {
                                        Swal.fire({
                                            text: "Kayýt iþlemi baþarýyla gerçekleþti",
                                            icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                            customClass: { confirmButton: "btn btn-primary" }
                                        }).then()
                                    },
                                    error: function (data) {
                                        Swal.fire({
                                            text: "HATA! Sistem yöneticisi ile iletiþime geçiniz'" + data + "'",
                                            icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                            customClass: { confirmButton: "btn btn-primary" }
                                        }).then()
                                    }

                                });

                            }), 1500)) : Swal.fire({
                                text: "Maalesef bazý hatalar tespit edildi, lütfen tekrar deneyin!",
                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                                customClass: { confirmButton: "btn btn-primary" }
                            }).then()
                    }))
                }))
        }
    }
}(); KTUtil.onDOMContentLoaded((function () { KTSignupGeneral.init() }));