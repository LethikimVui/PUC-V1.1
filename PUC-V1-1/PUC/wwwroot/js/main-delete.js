$(document).ready(function () {
    $('body').off('click', '#btn-add').on('click', '#btn-delete', Delete);
    var user = document.getElementById('userinfo').getAttribute('data-user');

    function Delete() {
        var machineId = $("#txt-machineId").val();
        debugger
        if (machineId) {
            var model = new Object();
            model.MachineId = parseInt(machineId);
            model.UpdatedBy = user;
            $.ajax({
                type: 'post',
                url: '/Main/Main_Delete',
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
            bootbox.alert("Please make sure Customer / Machine Name / Fixture ID / Part Number is provided");
        }
    }
    function Reset() {
        window.location.reload();
    }
})