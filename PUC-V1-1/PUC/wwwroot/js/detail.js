﻿$(document).ready(function () {
    $('body').off('click', '#btn-search').on('click', '#btn-search', Load);
    $('body').off('click', '#btn-reset').on('click', '#btn-reset', Reset);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    $('body').off('click', '#btn-delete').on('click', '#btn-delete', Delete);
    $('body').off('click', '#btn-edit').on('click', '#btn-edit', Edit);
    $('body').off('click', '#btn-submit').on('click', '#btn-submit', Submit)

    var user = document.getElementById('userinfo').getAttribute('data-user');


    function Load() {
        debugger
        if ($('#txt-customer-search').val()) {
            DetailTable.loadData(true);
        }
        else {
            bootbox.alert('Please select customer!')
        }
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
            var machineId = $("#txt-machineName-search").val() ? parseInt($("#txt-machineName-search").val()) : 0;
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


                    //if (totalRecord > 0) {
                    //    $.ajax({
                    //        type: 'post',
                    //        url: '/Detail/Detail_Get',
                    //        data: JSON.stringify(model),
                    //        contentType: "application/json; charset=utf-8",
                    //        success: function (data) {
                    //            $("#tbl-main").html(data);
                    //            DetailTable.paging(totalRecord, function () { }, changePageSize);
                    //        }
                    //    });
                    //}
                    //else {
                    //    $("#tbl-main").html("");
                    //    $('#pagination').empty();
                    //    $("#loading").hide();
                    //    bootbox.alert('No record found')
                    //}
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

    function Delete() {
        var detailId = $(this).attr('data-detailId');
        debugger

        var model = new Object();
        model.DetailId = parseInt(detailId);
        model.UpdatedBy = user;
        $.ajax({
            type: 'post',
            url: '/Detail/Detail_Delete',
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

    function Edit() {
        $('#txt-Category').val($(this).data('categoryid'));
        $('#txt-Supplier').val($(this).data('supplierid'));
        $('#txt-Location').val($(this).data('location'));
        $('#txt-PartNumber').val($(this).data('partnumber'));
        $('#txt-Limit').val($(this).data('limit'));
        $('#txt-TriggerLimit').val($(this).data('triggerlimit'));
        $('#btn-submit').val($(this).data('detailid'));
        debugger
        var selectedFile = document.getElementById('upload')
        selectedFile.value = "";
        fileList = document.getElementById("fileList");
        fileList.innerHTML = "";
        const list = document.createElement("ul");
        fileList.appendChild(list);
        selectedFile.addEventListener("change", handleFiles, false);
    }
    function handleFiles() {
        //var li = document.createElement("li");
        //var getDate = new Date();
        //var date = getDate.getFullYear().toString() + (getDate.getMonth() + 1) + getDate.getDate() + getDate.getHours() + getDate.getMinutes() + getDate.getSeconds() + getDate.getMilliseconds();
        //this.innerHTML = ""
        //li.innerHTML =
        //    `${this.files[this.files.length - 1].name.split('.')[0] + '_' + date + '.' + this.files[this.files.length - 1].name.split('.')[1]}
        //  <span class="remove-list" style="background-color:lightblue" onclick="return this.parentNode.remove()">X</span>`;
        //fileList.appendChild(li);


        debugger
        if (!this.files.length) {
            fileList.innerHTML = "<p>No files selected!</p>";
        }
        else {
            //var form_data = new FormData();

            fileList.innerHTML = "";
            const list = document.createElement("ul");
            fileList.appendChild(list);
            for (let i = 0; i < this.files.length; i++) {
                const li = document.createElement("li");
                //form_data.append("files[]", this.files[i]);
                li.appendChild(document.createTextNode(this.files[i].name))
                list.appendChild(li);
            }
        }
    }

    updateList = function () {
        var input = document.getElementById('file2');
        var output = document.getElementById('fileList2');
        var li = document.createElement("li");
        var getDate = new Date();
        var date = getDate.getFullYear().toString() + (getDate.getMonth() + 1) + getDate.getDate() + getDate.getHours() + getDate.getMinutes() + getDate.getSeconds() + getDate.getMilliseconds();

        li.innerHTML =
            `${input.files[input.files.length - 1].name.split('.')[0] + '_' + date + '.' + input.files[input.files.length - 1].name.split('.')[1]}
          <span class="remove-list" style="background-color:lightblue" onclick="return this.parentNode.remove()">X</span>`;
        output.appendChild(li);
    }
    function Submit() {
        var fileName = "";
        var getDate = new Date();
        var date = getDate.getFullYear().toString() + (getDate.getMonth() + 1) + getDate.getDate() + getDate.getHours() + getDate.getMinutes() + getDate.getSeconds() + getDate.getMilliseconds();
        var selectedFile = document.getElementById('upload').files;
        if (selectedFile.length) {
            for (let i = 0; i < selectedFile.length; i++) {
                fileName += selectedFile[i].name.split('.')[0] + '_' + date + '.' + selectedFile[i].name.split('.')[1] + ';';
                uploadFile(selectedFile[i], date);
            }
        }
        var model = new Object();
        debugger
        model.DetailId = parseInt($(this).val());
        model.CategoryId = parseInt($('#txt-Category').val());
        model.SupplierId = parseInt($('#txt-Supplier').val());
        model.Location = $('#txt-Location').val().toUpperCase();
        model.PartNumber = $('#txt-PartNumber').val().toUpperCase();
        model.Limit = parseInt($('#txt-Limit').val());
        model.TriggerLimit = parseInt($('#txt-TriggerLimit').val());
        model.CreatedBy = user;
        model.Description = $('#txt-description').val();
        model.FileName = fileName ? fileName : null;

        $.ajax({
            type: 'post',
            url: '/Request/Request_insert',
            dataType: 'json',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                var results = response.results
                bootbox.alert(results.message, function () { $('#myModal').modal('hide'); ReLoad() });
            }
        })


    }
    function uploadFile(_file, _date) {
        var form_data = new FormData();
        form_data.append("files", _file);
        form_data.append("date", _date);
        debugger
        $.ajax({
            type: 'post',
            url: '/Request/UploadFile',
            data: form_data,
            contentType: false,
            dataType: 'json',
            processData: false,
            cache: false,
            success: function (data) {
                console.log(data)
            }
        })
    }

    function Reset() {
        window.location.reload();
    }
    function ReLoad() {
        DetailTable.loadData(true);
    }
})