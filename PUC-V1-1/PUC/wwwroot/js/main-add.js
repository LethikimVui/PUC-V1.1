$(document).ready(function () {
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    var user = document.getElementById('userinfo').getAttribute('data-user');

    function Add() {
        var custId = $("#txt-customer").val();
        var machine = document.getElementById('txt-machine').value.trim();
        var serialNumber = document.getElementById('txt-serialNumber').value.trim();
        var partNumber = document.getElementById('txt-partNumber').value.trim();
        var description = document.getElementById('txt-description').value.trim();
        debugger
        if (custId && machine && (serialNumber || partNumber)) {
            var model = new Object();
            model.CustId = parseInt(custId);
            model.MachineName = machine.toUpperCase();
            model.SerialNumber = serialNumber.toUpperCase();
            model.PartNumber = partNumber.toUpperCase();
            model.Description = description;
            model.CreatedBy = user;
            $.ajax({
                type: 'post',
                url: '/Main/Main_Add',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (response) {

                    var statusCode = response.results.statusCode;
                    var message = response.results.message;

                    if (statusCode == 200) {
                        bootbox.alert(message, function () { Reset() });
                    }
                    else if (statusCode == 409) {
                        bootbox.alert(message);
                    }
                    else {
                        bootbox.alert(message);
                    }
                }
            })
        }
        else {
            bootbox.alert("Please make sure Customer / Machine Name / Fixture ID / Part Number  is provided");
        }
    }
    function Reset() {
        window.location.reload();
    }
})