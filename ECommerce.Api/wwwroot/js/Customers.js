//Load Data in Table when documents is ready  
$(document).ready(function () {
    loadData();
});

//Load Data function  
function loadData() {
    $.ajax({
        url: "https://localhost:44306/api/customer/GetAll",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td>' + item.customerId + '</td>';
                html += '<td>' + item.customerName + '</td>';
                html += '<td>' + item.customerSurname + '</td>';
                html += '<td>' + item.phoneNumber + '</td>';
                html += '<td>' + item.customerAdress + '</td>';
                html += '<td>' + item.email + '</td>';
                html += '<td><a href="#" onclick="return GetById(' + item.customerId + ')">Edit</a> | <a href="#" onclick="Delele()">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Add Data Function   
function Add() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var empObj = {
        CustomerId: $('#CustomerId').val(),
        CustomerName: $('#CustomerName').val(),
        CustomerSurname: $('#CustomerSurname').val(),
        PhoneNumber: $('#PhoneNumber').val(),
        CustomerAdress: $('#CustomerAdress').val(),
        Email: $('#Email').val(),
    };
    $.ajax({
        url: "https://localhost:44306/api/customer/create",
        data: JSON.stringify(empObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#myModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Function for getting the Data Based upon Employee ID  
function getbyID(EmpID) {
    $('#CustomerName').css('border-color', 'lightgrey');
    $('#CustomerSurname').css('border-color', 'lightgrey');
    $('#PhoneNumber').css('border-color', 'lightgrey');
    $('#CustomerAdress').css('border-color', 'lightgrey');
    $('#Email').css('border-color', 'lightgrey');
    $.ajax({
        url: "https://localhost:44306/api/customer/GetById" + EmpID,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
            $('#CustomerId').val(result.CustomerId);
            $('#CustomerName').val(result.CustomerName);
            $('#CustomerSurname').val(result.CustomerSurname);
            $('#PhoneNumber').val(result.PhoneNumber);
            $('#CustomerAdress').val(result.CustomerAdress);
            $('#Email').val(result.Email);

            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

//function for updating employee's record  
function Update() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var empObj = {
        CustomerId: $('#CustomerId').val(),
        CustomerName: $('#CustomerName').val(),
        CustomerSurname: $('#CustomerSurname').val(),
        PhoneNumber: $('#PhoneNumber').val(),
        CustomerAdress: $('#CustomerAdress').val(),
        Email: $('#Email').val(),
    };
    $.ajax({
        url: "https://localhost:44306/api/customer/update",
        data: JSON.stringify(empObj),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#myModal').modal('hide');
            $('#CustomerId').val("");
            $('#CustomerName').val("");
            $('#CustomerSurname').val("");
            $('#PhoneNumber').val("");
            $('#CustomerAdress').val
            $('#Email').val("");
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//function for deleting employee's record  
function Delele() {
    var ans = confirm("Are you sure you want to delete this Record?");
    if (ans) {
        $.ajax({
            url: "api/customer/delete",
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

//Function for clearing the textboxes  
function clearTextBox() {
    $('#CustomerId').val("");
    $('#CustomerName').val("");
    $('#CustomerSurname').val("");
    $('#PhoneNumber').val("");
    $('#CustomerAdress').val("");
    $('#Email').val("");
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    $('#CustomerName').css('border-color', 'lightgrey');
    $('#CustomerSurname').css('border-color', 'lightgrey');
    $('#PhoneNumber').css('border-color', 'lightgrey');
    $('#CustomerAdress').css('border-color', 'lightgrey');
    $('#Email').css('border-color', 'lightgrey');
}
//Valdidation using jquery  
function validate() {
    var isValid = true;
    if ($('#customerName').val().trim() == "") {
        $('#customerName').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#CustomerName').css('border-color', 'lightgrey');
    }
    if ($('#CustomerSurname').val().trim() == "") {
        $('#CustomerSurname').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#CustomerSurname').css('border-color', 'lightgrey');
    }
    if ($('#PhoneNumber').val().trim() == "") {
        $('#PhoneNumber').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#PhoneNumber').css('border-color', 'lightgrey');
    }
    if ($('#CustomerAdress').val().trim() == "") {
        $('#CustomerAdress').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#CustomerAdress').css('border-color', 'lightgrey');
    }
    if ($('#Email').val().trim() == "") {
        $('#Email').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Email').css('border-color', 'lightgrey');
    }
    return isValid;
}