$(document).ready(function () {
    document.getElementById('txt-customer').addEventListener('change', fncOnchangeCustomer, false)
    function fncOnchangeCustomer() {
        var custId = parseInt(document.getElementById("txt-customer").value);

        $('#txt-machineName').empty();
        $('#txt-machineName').append($('<option>', {
            value: "",
            text: "--Please Select--"
        }));

        debugger
        $.ajax({
            type: 'post',
            url: '/common/Main_MachineName_get',
            dataType: 'json',
            data: { custId: custId },
            success: function (response) {
                var data = response.result;
                debugger
                $.each(data, function (index, value) {
                    $('#txt-machineName').append($('<option>', {
                        value: value.machineId,
                        text: value.machineName
                    }));
                });
            }
        });
        $('.cq-dropdown').dropdownCheckboxes();
    }

    
})