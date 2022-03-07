$(document).ready(function () {

    var user = document.getElementById('userinfo').getAttribute('data-user');


    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);
    function Add() {
        var model = new Object();
        model.CategoryName = $('#txt-category').val();
        model.Description = $('#txt-description').val();      
        model.CreatedBy = user;
        debugger
        $.ajax({
            type: 'post',
            url: '/common/Master_Category_insert',
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
        categoryId = $(this).attr('data-id');
        debugger
        category = $(this).attr('data-category');
        var model = new Object();
        model.CategoryId = parseInt(categoryId);
        model.UpdatedBy = user;
        $.ajax({
            type: 'post',
            url: '/common/Master_Category_delete',
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