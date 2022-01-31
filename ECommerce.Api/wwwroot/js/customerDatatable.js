$(document).ready(function () {
    $('#customerDatatable').DataTable({
        processing: true,
        serverside: true,
        filter: true,
        ajax: {
            url: "https://localhost:44306/api/customer/GetCustomers",
            type: "POST",
            datatype: "json",
            contentType: "application/x-www-form-urlencoded",
        },
        columnDefs: [{
            targets: [0],
            visible: false,
            searchable: false
        }],
        columns: [
            { data: "customerId", name: "id", autowidth: true },
            { data: "customerName", name: "ad", autowidth: true },
            { data: "customerSurname", name: "soyad", autowidth: true },
            { data: "phoneNumber", name: "adres", autowidth: true },
            { data: "customerAdress", name: "telefon", autowidth: true },
            { data: "email", name: "email", autowidth: true },
            {
                render: function (data, type, row) { return "<a href='#' class= 'btn btn-danger' onclick=Delete('" + row.CustomerId + "');>Delete</a>"; }
            },
            //render : function (data) {
            //    return `
            //        <div class= "text-center">
            //        <a href="/CustomerList/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width: 70px">
            //            Edit
            //        </a>
            //        &nbsp;
            //        <a class="btn btn-danger text-white" style="cursor: pointer; width: 70px;"
            //            onclick= Delete('/api/customer?id='+${data})>
            //            Delete
            //        </a>
            //        </div>`;
            //}, width: "40%"
        ]
    });
});

function Delete(url) {
    swal({
        title: "Are you sure",
        text: "Once Deleted, you will not be able to retrive",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: "api/customer/delete",
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    } else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}