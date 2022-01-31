"use strict";
var KTUsersAddCategory = function () {
    const t = document.getElementById("kt_modal_add_category"),
        e = t.querySelector("#kt_modal_add_category_form"),
        n = new bootstrap.Modal(t);
    var category, number, category_id;
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
                        category_citizen_number: {
                            validators: {
                                notEmpty: {
                                    message: "Müşteri numarası zorunludur."
                                }
                            }
                        },
                        category_name: {
                            validators: {
                                notEmpty: {
                                    message: "Kategori adı zorunludur."
                                }
                            }
                        },
                        category_description: {
                            validators: {
                                notEmpty: {
                                    message: "Kategori tanımı zorunludur."
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
    const i = t.querySelector('[data-kt-categories-modal-action="submit"]');
    i.addEventListener("click", (t => {
        t.preventDefault(),
            o && o.validate().then((function (t) {
                console.log("CategoryId", category_id), "Valid" == t ? (i.setAttribute("data-kt-indicator", "on"),
                    i.disabled = !0, setTimeout((function () {
                        i.removeAttribute("data-kt-indicator"),
                            i.disabled = !1,
                            number = parseInt($("[name='category_citizen_number']").val());
                        if ($("[name='category_id']").val() == "0") {
                            category_id = 0;
                        } else {
                            category_id = parseInt($("[name='category_id']").val());
                        }

                        category = {
                            CategoryId: category_id,
                            CategoryNumber: number,
                            CategoryName: $("[name='category_name']").val(),
                            CategoryDescription: $("[name='category_description']").val()
                            /*createdate: convertUTCDateToLocalDate(new Date(Date.now()))*/
                        };
                        console.log(JSON.stringify(category));
                        $.ajax({
                            type: "POST",
                            url: "https://localhost:44312/api/category/create",
                            contentType: "application/json; charset=utf-8",
                            data: JSON.stringify(category),
                            dataType: "json",
                            success: function (data) {
                                Swal.fire({
                                    text: "Kayıt işlemi başarıyla gerçekleşti.",
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
    })), t.querySelector('[data-kt-categories-modal-action="cancel"]').addEventListener("click", (t => {
        t.preventDefault(), Swal.fire({
            text: "İptal etmek istediğinize emin misiniz?",
            icon: "warning",
            showCancelButton: !0,
            buttonsStyling: !1,
            confirmButtonText: "Evet, iptal et!",
            cancelButtonText: "Hayır",
            customClass: {
                confirmButton: "btn btn-primary",
                cancelButton: "btn btn-active-light"
            }
        }).then((function (t) {
            t.value ? (e.reset(), n.hide()) : "cancel" === t.dismiss && Swal.fire({
                text: "İşlem iptal ediliyor!.",
                icon: "error",
                buttonsStyling: !1,
                confirmButtonText: "Devam et!",
                customClass: {
                    confirmButton: "btn btn-primary"
                }
            })
        }))
    })), t.querySelector('[data-kt-categories-modal-action="close"]').addEventListener("click", (t => {
        t.preventDefault(), Swal.fire({
            text: "İptal etmek istediğinize emin misiniz?",
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
                text: "İşlem iptal ediliyor!.",
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
    KTUsersAddCategory.init()
}));

