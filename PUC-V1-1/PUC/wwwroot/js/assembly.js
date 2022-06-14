$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    //$('body').off('click', '#btn-reset').on('click', '#btn-reset', Reset);
    //$('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);
    //$('body').off('click', '#btn-edit').on('click', '#btn-edit', Edit);

    var user = document.getElementById('userinfo').getAttribute('data-user');
    var email = document.getElementById('userinfo').getAttribute('data-email');


    function Load() {
        debugger
        if ($('#txt-customer-search').val()) {
            DataTable.loadData(true);
        }
        else {
            bootbox.alert('Please select customer!')
        }
    }

    var homeconfig = {
        pageSize: 15,
        pageIndex: 1
    }
    var DataTable =
    {
        loadData: function (changePageSize) {
            var totalRecord = 0;
            $("#loading").show();

            var assemblyNo = document.getElementById('txt-assyno-search').value.trim() ? document.getElementById('txt-assyno-search').value.trim() : null;
            var custId = $("#txt-customer-search").val() ? parseInt($("#txt-customer-search").val()) : 0;          
            var machineId = $("#txt-machineName-search").val() ? parseInt($("#txt-machineName-search").val()) : 0;
            var model = new Object();
            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.CustId = parseInt(custId);
            model.MachineId = machineId;          
            model.AssemblyNo = assemblyNo;
            debugger
            $.ajax({
                type: 'post',
                url: '/Assembly/Assembly_Count',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    totalRecord = parseInt(data.result);
                    $.ajax({
                        type: 'post',
                        url: '/Assembly/Assembly_Get',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            $("#tbl-main").html(data);
                            DataTable.paging(totalRecord, function () { }, changePageSize);
                        }
                    });


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
                    DataTable.loadData();
                }
            });
            $("#loading").hide();
        },
    }

  
    function Delete() {
        assyId = parseInt($(this).data('assyid'));
        assemblyNo = $(this).data('assyno');
        debugger
        var model = new Object();
        model.AssemblyId = assyId;
        model.AssemblyNo = assemblyNo;
        model.UpdatedBy = user;
        $.ajax({
            type: 'post',
            url: '/Assembly/Master_Assembly_delete',
            //dataType: 'json',
            data: JSON.stringify(model),
            contentType:'application/json, character=utf-8',
            success: function (data) {
                response = data.results;
                bootbox.alert(response.message, function () { ReLoad()});
            }
        })
    }


    function ReLoad() {
        DataTable.loadData(true);
    }
})