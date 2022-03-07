$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    $('body').off('click', '#btn-reset').on('click', '#btn-reset', Reset);
    $('body').off('click', '#btn-export').on('click', '#btn-export', DownloadAsExcel);

    var user = document.getElementById('userinfo').getAttribute('data-user');

   
    const EXCEL_TYPE = 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=UTF-8';
    const EXCEL_EXTENSION = '.xlsx';

    function DownloadAsExcel() {
        var data = [];

        var txtcustId = $("#txt-customer").val();
        var txtfixtureId = $('#txt-fixtureID option:selected').text().toString();//document.getElementById('txt-fixtureID').value.trim();
        var txtfixtureName = document.getElementById('txt-fixtureName').value.trim();
        var txtserialNumber = document.getElementById('txt-serialNumber').value.trim();
        var fixtureId = txtfixtureId ? txtfixtureId : null;
        var fixtureName = txtfixtureName ? txtfixtureName : null;
        var serialNumber = txtserialNumber ? txtserialNumber : null;
        var custId = txtcustId ? parseInt(txtcustId) : 0; //here I get all options and convert to string   

        if ($('#txt-customer').val()) {
            var model = new Object();
            model.PageSize = homeconfig.pageSize
            model.PageIndex = homeconfig.pageIndex - 1;
            model.CustId = custId;
            model.FixtureId = fixtureId;
            model.FixtureName = fixtureName;
            model.SerialNumber = serialNumber;
            $.ajax({
                async: false,
                type: 'post',
                url: '/Main/Download',
                data: JSON.stringify(model),
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    data = response.result;
                    const worksheet = XLSX.utils.json_to_sheet(data);
                    const workbook = {
                        Sheets: {
                            'data': worksheet
                        },
                        SheetNames: ['data']
                    };
                    const excelBuffer = XLSX.write(workbook, { bookType: 'xlsx', type: 'array' });
                    SaveAsExcel(excelBuffer, 'Fixture List ');
                }
            });
        }
        else {
            bootbox.alert('Please select customer!')
        }


    }
    function SaveAsExcel(buffer, filename) {
        var dateTime = new Date(Date.now());
        var strDateTime = dateTime.getFullYear() + '' + (dateTime.getMonth() + 1) + dateTime.getDate() + dateTime.getHours() + dateTime.getMinutes() + dateTime.getMilliseconds();
        const data = new Blob([buffer], { type: EXCEL_TYPE });
        debugger
        saveAs(data, filename + strDateTime + EXCEL_EXTENSION);

    }
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

    function Reset() {
        window.location.reload();
    }


})