$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    $('body').off('click', '#btn-reset').on('click', '#btn-reset', Reset);
    $('body').off('click', '#btn-detail').on('click', '#btn-detail', ShowDetail);
    $('body').off('click', '#btn-refresh').on('click', '#btn-refresh', Refresh);

    var user = document.getElementById('userinfo').getAttribute('data-user');


    function Load() {
        $("#tbl-detail").html("");
        $("#lbl-detail-title").html("");
        $("#tbl-activity-log").html("");
        debugger
        if ($('#txt-customer-search').val()) {
            MainTable.loadData(true);
        }
        else {
            bootbox.alert('Please select customer!')
        }
    }


    var homeconfig = {
        pageSize: 15,
        pageIndex: 1
    }
    var MainTable =
    {
        loadData: function (changePageSize) {
            document.getElementById("detail").setAttribute("style", "display:none");
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
                            url: '/Main/Maintenance_Get',
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
    //MainTable.loadData();

    function Reset() {
        window.location.reload();
    }

    function Refresh() {
        var usedTimes = {};
        var arrdetailId = [];
        var arrlocation = [];
        var elm = document.getElementsByClassName('confirm');
        var len = elm.length;
        for (var i = 0; i < len; i++) {
            if (elm[i].checked) {
                usedTimes[elm[i].value] = elm[i].attributes[5].value;
                arrdetailId.push(elm[i].value);
                arrlocation.push(elm[i].attributes[6].value);
            }
        }

        var machineId = $(this).attr('data-machineId');
        var custId = $(this).attr('data-custId');
        var machineName = $(this).attr('data-machineName');
        if (!(arrdetailId.length > 0 && $('#txt-reason').val())) {
            bootbox.alert('Please choose reason or location')
        }
        else {
            bootbox.confirm(`Are you sure to refresh the cycle count of ${arrlocation.toString()} ?`, function (result) {
                if (result) {
                    var message = $('#txt-reason option:selected').text();
                    var model = new Object();
                    model.strDetailId = arrdetailId.toString();
                    model.UpdatedBy = user;
                    debugger
                    $.ajax({
                        type: 'post',
                        url: '/detail/Detail_Usage_refresh',
                        dataType: 'json',
                        data: JSON.stringify(model),
                        contentType: "application/json; charset=utf-8",
                        success: function (response) {

                            var data = response.statusCode;
                            if (data == 200) {
                                $.each(usedTimes, function (key, value) {
                                    Log_update(key, value, message);
                                })

                                bootbox.alert(`Refresh the usage times for ${arrlocation.toString()} successfully`, function () {
                                    Detail(custId, machineId, machineName);
                                    Log_get(machineId);
                                });
                            }
                            else {
                                bootbox.alert("Refresh got error");

                            }
                        }
                    })
                }
            })
        }
    }



    function ShowDetail() {
        $("#loading").show();
        var machineId = $(this).attr('data-machineId');
        var custId = $(this).attr('data-custId');
        var machineName = $(this).attr('data-machineName');
        debugger

        Detail(custId, machineId, machineName);
        Log_get(machineId);
        $("#loading").hide();
    }
    function Detail(_custId, _machineId, _machineName) {
        $("#loading").show();
        var model = new Object();
        model.MachineId = parseInt(_machineId);
        debugger
        $.ajax({
            type: 'post',
            url: '/Detail/Get_PartialView',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                debugger
                document.getElementById("detail").setAttribute("style", "display:inline; min-height: auto !important;");
                $("#lbl-detail-title").html("Detail Part for " + _machineName);
                /*$("#lbl-log-title").html("Activity Log");*/
                $("#tbl-detail").html(data);
                $('#btn-refresh').attr('data-machineId', _machineId);
                $('#btn-refresh').attr('data-custId', _custId);
                $('#btn-refresh').attr('data-machineName', _machineName);

                const elm = document.getElementsByClassName('level')
                for (var i = elm.length; i--;) {

                    if (elm[i].getAttribute('data-level') == 2) {
                        elm[i].setAttribute("style", "background-color: red");

                    }
                    else if (elm[i].getAttribute('data-level') == 1) {
                        elm[i].setAttribute("style", "background-color: yellow");
                    }
                    else if (elm[i].getAttribute('data-level') == 0) {
                        elm[i].setAttribute("style", "background-color: green");
                    }
                }
            }
        });
        $("#loading").hide();
    }
    function Log_get(_machineId) {
        $("#loading").show();
        
        var model = new Object();
        model.MachineId = parseInt(_machineId);
        debugger
        $.ajax({
            type: 'post',
            url: '/main/Log_get',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {

                $("#tbl-log").html(data);
            }
        });
        $("#loading").hide();
    }

    function Log_update(_detailId, _usedTimes, _message) {
        var model = new Object();
        model.DetailId = parseInt(_detailId);
        model.UsedTimes = parseInt(_usedTimes);
        model.Message = _message;
        model.UpdatedBy = user;      
        debugger
        $.ajax({
            type: 'post',
            url: '/main/Log_update',
            data: JSON.stringify(model),
            contentType: "application/json; charset=utf-8",
            success: function (data) {

            }
        })
    }





})