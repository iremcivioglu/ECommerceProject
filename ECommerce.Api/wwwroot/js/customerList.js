var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "https://localhost:44306/api/customer/GetCustomers",
            "type": "POST",
            "datatype": "json"
        },
        "columns": [
            { data: "customerId", name: "id", autowidth: true },
            { data: "customerName", name: "ad", autowidth: true },
            { data: "customerSurname", name: "soyad", autowidth: true },
            { data: "phoneNumber", name: "adres", autowidth: true },
            { data: "customerAdress", name: "telefon", autowidth: true },
            { data: "email", name: "email", autowidth: true },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class= "text-center">
                    <a href="/CustomerList/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width: 70px">
                        Edit
                    </a>
                    &nbsp;
                    <a class="btn btn-danger text-white" style="cursor: pointer; width: 70px;"
                        onclick= Delete('/api/customer?id='+${data})>
                        Delete
                    </a>
                    </div>`;
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "no data available"
        },
        "width": "100%"
    });
}

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
                url: url,
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