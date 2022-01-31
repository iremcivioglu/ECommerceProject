"use strict";
var KTUsersAddUser = function () {
    const t = document.getElementById("kt_modal_add_company"),
        e = t.querySelector("#kt_modal_add_company_form"),
        n = new bootstrap.Modal(t);
    var customer, number, customer_id;
    //function convertUTCDateToLocalDate(date) {
    //    var newDate = new Date(date.getTime() + date.getTimezoneOffset() * 60 * 1000);
    //    var offset = date.getTimezoneOffset() / 60;
    //    var hours = date.getHours();
    //    newDate.setHours(hours - offset);
    //    return newDate;
    //}
    return {
        init: function () {
            (() => {
                var o = FormValidation.formValidation(e, {
                    fields: {
                        customer_citizen_number: {
                            validators: {
                                notEmpty: {
                                    message: "Müşteri numarası zorunludur."
                                }
                            }
                        },
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
                        trigger: new FormValidation.plugins.Trigger,
                        bootstrap: new FormValidation.plugins.Bootstrap5({
                            rowSelector: ".fv-row",
                            eleInvalidClass: "",
                            eleValidClass: ""
                        })
                    }
                });
                const i = t.querySelector('[data-kt-users-modal-action="submit"]');
                i.addEventListener("click", (t => {
                    t.preventDefault(),
                        o && o.validate().then((function (t) {
                            console.log("CustomerId", customer_id), "Valid" == t ? (i.setAttribute("data-kt-indicator", "on"),
                                i.disabled = !0, setTimeout((function () {
                                    i.removeAttribute("data-kt-indicator"),
                                        i.disabled = !1,
                                       number = parseInt($("[name='customer_citizen_number']").val());
                                    if ($("[name='customer_id']").val() == "0") {
                                        customer_id = 0;
                                    } else {
                                        customer_id = parseInt($("[name='customer_id']").val());
                                    }

                                    customer = {
                                        CustomerId: customer_id,
                                        CustomerNumber: number,
                                        CustomerName: $("[name='customer_name']").val(),
                                        CustomerSurname: $("[name='customer_surname']").val(),
                                        CustomerAdress: $("[name='customer_adress']").val(),
                                        PhoneNumber: $("[name='phone_number']").val(),
                                        Email: $("[name='email']").val()
                                        /*createdate: convertUTCDateToLocalDate(new Date(Date.now()))*/
                                    };
                                    console.log(JSON.stringify(customer));
                                    $.ajax({
                                        type: "POST",
                                        url: "https://localhost:44312/api/customer/create",
                                        contentType: "application/json; charset=utf-8",
                                        data: JSON.stringify(customer),
                                        dataType: "json",
                                        success: function (data) {
                                            Swal.fire({
                                                text: "Kayýt iþlemi baþarýyla gerçekleþti.",
                                                icon: "success", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                                customClass: { confirmButton: "btn btn-primary" }
                                            }).then((function (t) { t.isConfirmed && (e.reset(), n.hide(), $("#kt_datatable_example_1").DataTable().ajax.reload()) }))
                                        },
                                        error: function (data) {
                                            Swal.fire({
                                                text: "HATA! Sistem yöneticisi ile iletiþime geçiniz!'" + data + "'",
                                                icon: "error", buttonsStyling: !1, confirmButtonText: "Ok, devam et!",
                                                customClass: { confirmButton: "btn btn-primary" }
                                            }).then((function (t) { t.isConfirmed && (e.reset()) }))
                                        }

                                    });
                                }), 2e3)) : Swal.fire({
                                    text: "HATA! Sistem yöneticisi ile iletiþime geçiniz! Henüz post metoduna girilmedi.",
                                    icon: "error",
                                    buttonsStyling: !1,
                                    confirmButtonText: "Ok, got it!",
                                    customClass: {
                                        confirmButton: "btn btn-primary"
                                    }
                                })
                        }))
                })), t.querySelector('[data-kt-users-modal-action="cancel"]').addEventListener("click", (t => {
                    t.preventDefault(), Swal.fire({
                        text: "Ýptal etmek istediðinize emin misiniz?",
                        icon: "warning",
                        showCancelButton: !0,
                        buttonsStyling: !1,
                        confirmButtonText: "Evet, iptal et!",
                        cancelButtonText: "Hayýr",
                        customClass: {
                            confirmButton: "btn btn-primary",
                            cancelButton: "btn btn-active-light"
                        }
                    }).then((function (t) {
                        t.value ? (e.reset(), n.hide()) : "cancel" === t.dismiss && Swal.fire({
                            text: "Ýþlem iptal ediliyor!.",
                            icon: "error",
                            buttonsStyling: !1,
                            confirmButtonText: "Devam et!",
                            customClass: {
                                confirmButton: "btn btn-primary"
                            }
                        })
                    }))
                })), t.querySelector('[data-kt-users-modal-action="close"]').addEventListener("click", (t => {
                    t.preventDefault(), Swal.fire({
                        text: "Ýptal etmek istediðinize emin misiniz?",
                        icon: "warning",
                        showCancelButton: !0,
                        buttonsStyling: !1,
                        confirmButtonText: "Yes, cancel it!",
                        cancelButtonText: "No, return",
                        customClass: {
                            confirmButton: "btn btn-primary",
                            cancelButton: "btn btn-active-light"
                        }
                    }).then((function (t) {
                        t.value ? (e.reset(), n.hide()) : "cancel" === t.dismiss && Swal.fire({
                            text: "Ýþlem iptal ediliyor!.",
                            icon: "error",
                            buttonsStyling: !1,
                            confirmButtonText: "Ok, got it!",
                            customClass: {
                                confirmButton: "btn btn-primary"
                            }
                        })
                    }))
                }))
            })()
        }
    }
}();
KTUtil.onDOMContentLoaded((function () {
    KTUsersAddUser.init()
}));

