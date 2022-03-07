$(document).ready(function () {

    var user = document.getElementById('userinfo').getAttribute('data-user');


    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);
    function Add() {
        var model = new Object();
        model.Supplier = $('#txt-supplier').val();
        model.Description = $('#txt-description').val();      
        model.CreatedBy = user;
        debugger
        $.ajax({
            type: 'post',
            url: '/common/Master_Supplier_insert',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",

            success: function (response) {
                var data = response.results

                if (data.statusCode == 200) {
                    bootbox.alert(data.message, function () {
                        location.reload(true);
                    })
                }
                else if (data.statusCode == 400) {
                    bootbox.alert(data.message)
                }
                else {
                    bootbox.alert("Update Error!")
                }
            }
        })
    }
    function Delete() {
        supplierId = $(this).attr('data-id');
        debugger
        supplier = $(this).attr('data-supplier');
        var model = new Object();
        model.SupplierId = parseInt(supplierId);
        model.UpdatedBy = user;
        $.ajax({
            type: 'post',
            url: '/common/Master_supplier_delete',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (response) {

                var data = response.results;
                if (data.statusCode == 200) {
                    bootbox.alert(`${category} is deleted`, function () {
                        location.reload(true);
                    })
                }
                else {
                    bootbox.alert("Error");
                }

            }
        })
    }

})