$(document).ready(function () {
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    var user = document.getElementById('userinfo').getAttribute('data-user');

    function Add() {
        var machineId = $('#txt-machineName').val();
        var categoryId = $('#txt-category').val();
        var supplierId = $('#txt-supplier').val();
        var location = document.getElementById('txt-location').value.trim();
        var partNumber = document.getElementById('txt-partNumber').value.trim();
        var limit = document.getElementById('txt-limit').value;
        customLimit = document.getElementById('customLimit').checked ? 1 : 0;
        var triggerLimit = document.getElementById('txt-triggerLimit').value;
        var description = document.getElementById('txt-description').value;
        if (machineId && categoryId && supplierId && location && partNumber && limit) {
            var model = new Object();
            model.MachineId = parseInt(machineId);
            model.CategoryId = parseInt(categoryId);
            model.SupplierId = parseInt(supplierId);
            model.PartNumber = partNumber.toUpperCase();
            model.Location = location.toUpperCase();
            model.Limit = parseInt(limit);
            model.CustomLimit = customLimit;
            model.TriggerLimit = parseInt(triggerLimit);
            model.Description = description;
            model.CreatedBy = user;
            debugger
            $.ajax({
                type: 'post',
                url: '/detail/Detail_add',
                data: JSON.stringify(model),
                dataType: 'json',
                contentType: 'application/json;charset=utf-8',
                success: function (response) {
                    var results = response.results
                    bootbox.alert(results.message, function () { ReLoad() });
                }
            })
        }
        else
            bootbox.alert('Please make sure all info are selected!');
    }

    function ReLoad() {
        DetailTable.loadData(true);
    }
    var homeconfig = {
        pageSize: 15,
        pageIndex: 1
    }
    var DetailTable =
    {
        loadData: function (changePageSize) {
            var totalRecord = 0;
            $("#loading").show();

            var partNumber = document.getElementById('txt-partNumber-search').value.trim() ? document.getElementById('txt-partNumber-search').value.trim() : null;
            var location = document.getElementById('txt-location-search').value.trim() ? document.getElementById('txt-location-search').value.trim() : null;
            var custId = $("#txt-customer-search").val() ? parseInt($("#txt-customer-search").val()) : 0;
            var categoryId = $("#txt-category-search").val() ? parseInt($("#txt-category-search").val()) : 0;
            var supplierId = $("#txt-supplier-search").val() ? parseInt($("#txt-supplier-search").val()) : 0;
            var machineId = $("#txt-machineName-search").val() ? $("#txt-machineName-search").val() : 0;

            var model = new Object();
            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.CustId = parseInt(custId);
            model.MachineId = machineId;
            model.CategoryId = categoryId;
            model.SupplierId = supplierId;
            model.PartNumber = partNumber;
            model.Location = location;
            debugger
            $.ajax({
                type: 'post',
                url: '/Detail/Detail_Count',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    totalRecord = parseInt(data.result);
                    if (totalRecord > 0) {
                        $.ajax({
                            type: 'post',
                            url: '/Detail/Detail_Get',
                            data: JSON.stringify(model),
                            contentType: "application/json; charset=utf-8",
                            success: function (data) {
                                $("#tbl-main").html(data);
                                DetailTable.paging(totalRecord, function () { }, changePageSize);
                            }
                        });
                    }
                    else {
                        $("#tbl-main").html("");
                        $('#pagination').empty();
                        $("#loading").hide();
                        bootbox.alert('No record found')
                    }
                }
            });
        },
        paging: function (totalRow, callback, changePageSize) {

            var totalPage = 0;
            if (totalRow < homeconfig.pageSize) {
                totalPage = 1
            }
            else {
                totalPage = Math.ceil(totalRow / homeconfig.pageSize);
            }

            if ($('#pagination a').length === 0 || changePageSize === true) {
                $('#pagination').empty();
                $('#pagination').removeData("twbs-pagination");
                $('#pagination').unbind("page");
            }
            $('#pagination').twbsPagination({
                totalPages: totalPage,
                first: "<<",
                next: ">",
                last: ">>",
                prev: "<",
                visiblePages: 15,
                onPageClick: function (event, page) {
                    homeconfig.pageIndex = page;
                    DetailTable.loadData();

                }
            });
            $("#loading").hide();
        },


    }
})