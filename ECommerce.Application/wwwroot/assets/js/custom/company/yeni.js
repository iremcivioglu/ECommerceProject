"use strict";
var KTSignupGeneral = function () {
    var e, t, a, s, r, theContact = function () {
        return 100 === s.getScore()
    };
    return {
        init: function () {
            e = document.querySelector("#kt_modal_add_company_form"),
                t = document.querySelector("#kt_modal_add_company"),
                s = KTPasswordMeter.getInstance(e.querySelector('[data-kt-password-meter="true"]')),
                a = FormValidation.formValidation(e, {
                    fields: {
                        customer_name: {
                            validators: {
                                notEmpty: {
                                    message: "Müşteri adı zorunludur."
                                }
                            }
                        },
                        customer_surname: {
                            validators: {
                                notEmpty: {
                                    message: "Müşteri soyadı zorunludur."
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
                                    message: "Telefon zorunludur."
                                }
                            }
                        },
                        email: {
                            validators: {
                                notEmpty: {
                                    message: "Mail adresi zorunludur."
                                }
                            }
                        }
                    },
                    plugins: {
                        trigger: new FormValidation.plugins.Trigger({ event: { password: !1 } }),
                        bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row", eleInvalidClass: "", eleValidClass: "" })
                    }
                }),
                t.addEventListener("click", (function (r) {

                    r.preventDefault(), a.revalidateField("CustomerAdress")
                    a.validate().then((function (a) {
                        "Valid" == a ? (t.setAttribute("data-kt-indicator", "on"),
                            t.disabled = !0, setTimeout((function () {
                                t.removeAttribute("data-kt-indicator"),
                                    t.disabled = !1,
                                    theContact = {
                                    CustomerName: $("[name='customer_name']").val(),
                                    CustomerSurname: $("[name='customer_surname']").val(),
                                    CustomerAdress: $("[name='customer_adress']").val(),
                                    PhoneNumber: $("[name='phone_number']").val(),
                                    Email: $("[name='email']").val()
                                    };

                                $.ajax({
                                    type: "POST",
                                    url: "https://localhost:44312/api/customer/create",
                                    contentType: "application/json; charset=utf-8",
                                    data: JSON.stringify(theContact),
                                    dataType: "json",
                                    success: function (data) {
                                        Swal.fire({
                                            text: "Kayıt işlemi başarıyla gerçekleşti",
                                            icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                            customClass: { confirmButton: "btn btn-primary" }
                                        }).then()
                                    },
                                    error: function (data) {
                                        Swal.fire({
                                            text: "HATA! Sistem yöneticisi ile iletişime geçiniz'" + data + "'",
                                            icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                            customClass: { confirmButton: "btn btn-primary" }
                                        }).then()
                                    }

                                });

                            }), 1500)) : Swal.fire({
                                text: "Maalesef bazı hatalar tespit edildi, lütfen tekrar deneyin!",
                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, got it!",
                                customClass: { confirmButton: "btn btn-primary" }
                            }).then()
                    }))
                }))
        }
    }
}(); KTUtil.onDOMContentLoaded((function () { KTSignupGeneral.init() }));