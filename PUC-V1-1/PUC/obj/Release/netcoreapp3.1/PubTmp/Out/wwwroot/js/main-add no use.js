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
                        bootbox.alert(message, function () { ReLoad() });
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
    function ReLoad() {
        window.location.reload();
    }


    var homeconfig = {
        pageSize: 15,
        pageIndex: 1
    }
    var MainTable =
    {
        loadData: function (changePageSize) {
            //document.getElementById("detail").setAttribute("style", "display:none");
            var totalRecord = 0;
            $("#loading").show();
            var txtcustId = $("#txt-customer-search").val();
            var txtmachineId = $("#txt-machineName-search").val();// $('#txt-fixtureID option:selected').text().toString();//document.getElementById('txt-fixtureID').value.trim();
            var txtdescription = document.getElementById('txt-description-search').value.trim();
            var txtserialNumber = document.getElementById('txt-serialNumber-search').value.trim();
            var selectedmachineId = txtmachineId ? txtmachineId.toString() : null;
            var description = txtdescription ? txtdescription : null;
            var serialNumber = txtserialNumber ? txtserialNumber : null;
            var selectedcustId = txtcustId ? txtcustId.toString() : null; //here I get all options and convert to string   

            var model = new Object();
            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.strCustId = selectedcustId;
            model.strMachineId = selectedmachineId;
            model.Description = description;
            model.SerialNumber = serialNumber;
            debugger
            $.ajax({
                type: 'post',
                url: '/Main/Main_Count',
                dataType: 'json',
                data: JSON.stringify(model),
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    totalRecord = parseInt(data.result);
                    if (totalRecord > 0) {
                        $.ajax({
                            type: 'post',
                            url: '/Main/Main_Get',
                            data: JSON.stringify(model),
                            contentType: "application/json; charset=utf-8",
                            success: function (data) {
                                $("#tbl-main").html(data);
                                MainTable.paging(totalRecord, function () { }, changePageSize);
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
                    MainTable.loadData();

                }
            });
            $("#loading").hide();
        },

    }
})