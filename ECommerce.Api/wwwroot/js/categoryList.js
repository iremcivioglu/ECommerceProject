var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/category",
            "type": "Get",
            "datatype": "json"
        },
        "columns": [
            { data: "categoryName", "width": "20%" },
            { data: "categoryDescription", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                    <div class= "text-center">
                    <a href="/CategoryList/Upsert?id=${data}" class="btn btn-success text-white" style="cursor:pointer; width: 70px">
                        Edit
                    </a>
                    &nbsp;
                    <a class="btn btn-danger text-white" style="cursor: pointer; width: 70px;"
                        onclick= Delete('/api/category?id='+${data})>
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
$(document).ready(function () {
    // Setup - add a text input to each footer cell
    $('#example tfoot th').each(function () {
        var title = $(this).text();
        $(this).html('<input type="text" placeholder="Search ' + title + '" />');
    });

    // DataTable
    var table = $('#example').DataTable({
        initComplete: function () {
            // Apply the search
            this.api().columns().every(function () {
                var that = this;

                $('input', this.footer()).on('keyup change clear', function () {
                    if (that.search() !== this.value) {
                        that
                            .search(this.value)
                            .draw();
                    }
                });
            });
        }
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