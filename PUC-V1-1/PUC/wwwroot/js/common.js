$(document).ready(function () {
    document.getElementById('txt-customer-search').addEventListener('change', fncOnchangeCustomer, false)
    function fncOnchangeCustomer() {
        var custId = parseInt(document.getElementById("txt-customer-search").value);

        $('#txt-machineName-search').empty();
        $('#txt-machineName-search').append($('<option>', {
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
                    $('#txt-machineName-search').append($('<option>', {
                        value: value.machineId,
                        text: value.machineName
                    }));
                });
            }
        });
        //$('.cq-dropdown').dropdownCheckboxes();
    }
})