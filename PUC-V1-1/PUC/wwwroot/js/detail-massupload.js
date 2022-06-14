$(document).ready(function () {
    $('body').off('click', '#btn-preview').on('click', '#btn-preview', Preview);
    $('body').off('click', '#btn-add').on('click', '#btn-add', Add);
    //$('body').off('click', '#btn-test').on('click', '#btn-test', test);

    var user = document.getElementById('userinfo').getAttribute('data-user');


    var ResetView = function () {
        $('#preview-table').html('');
        document.getElementById('btn-add').style.visibility = 'hidden';

    }

    var Categories = function () {
        var dict = {};
        $.ajax({
            async: false,
            type: 'post',
            url: '/common/Master_Category_get',
            success: function (response) {
                results = response.result
                $.each(results, function (index, value) {
                    dict[value.categoryName] = value.categoryId;
                })

            }
        });
        return dict;
    }();
    var Suppliers = function () {
        var dict = {};
        $.ajax({
            async: false,
            type: 'post',
            url: '/common/Master_Supplier_get',
            success: function (response) {
                results = response.result
                $.each(results, function (index, value) {
                    dict[value.supplier] = value.supplierId;
                })
            }
        });
        return dict;
    }();

    var ProcessExcel = function () {
        this.parseExcel = function (file, _machineId, _customLimit) {
            var reader = new FileReader();
            reader.onload = function (e) {
                var data = e.target.result;
                var workbook = XLSX.read(data, {
                    type: 'binary'
                });
                workbook.SheetNames.forEach(function (sheetName) {
                    var XL_row_object = XLSX.utils.sheet_to_row_object_array(workbook.Sheets[sheetName]);
                    var test = 'dsf';
                    $.each(XL_row_object, function (key, value) {
                        var supplier = value.Supplier.trim();
                        var category = value.Category.trim();
                        var location = value.Location.trim();
                        var partNumber = value.PartNumber.trim();
                        var limit = value.Limit;
                        var triggerLimit = value.TriggerLimit
                        var description = value.Description ? value.Description.trim() : null;
                        var model = new Object();
                        //model.FixId = parseInt(_fixId);
                        model.MachineId = parseInt(_machineId);
                        model.CategoryId = Categories[category];
                        model.SupplierId = Suppliers[supplier];
                        model.PartNumber = partNumber.toUpperCase();
                        model.Location = location.toUpperCase();
                        model.Limit = parseInt(limit);
                        model.CustomLimit = _customLimit;
                        model.TriggerLimit = parseInt(triggerLimit);
                        model.Description = description;
                        model.CreatedBy = 'System';
                        model.CreatedName = 'System';
                        debugger
                        $.ajax({
                            type: 'post',
                            url: '/detail/Detail_add',
                            data: JSON.stringify(model),
                            dataType: 'json',
                            contentType: 'application/json;charset=utf-8',
                            success: function (response) {
                                var result = response.results;
                                debugger
                                if (result.statusCode != 200) {
                                    test += location + ';'
                                }
                            }
                        })
                        bootbox.alert(test);

                    })

                })
                ResetView();
            }
            reader.onerror = function (ex) {
                console.log(ex);
            };
            reader.readAsBinaryString(file);
        }
    }  
  
    var ExcelToJSON = function () {
        this.parseExcel = function (file, _fixtureId, _customLimit) {
            var reader = new FileReader();

            reader.onload = function (e) {
                var data = e.target.result;
                var workbook = XLSX.read(data, {
                    type: 'binary'
                });
                workbook.SheetNames.forEach(function (sheetName) {
                    // Here is your object
                    var XL_row_object = XLSX.utils.sheet_to_row_object_array(workbook.Sheets[sheetName]);
                    var student = '';
                    var isValid = true;
                    $.each(XL_row_object, function (key, value) {
                        var supplier = value.Supplier ? value.Supplier.trim() : null;
                        var category = value.Category ? value.Category.trim() : null;
                        var location = value.Location ? value.Location.trim() : null;
                        var partNumber = value.PartNumber ? value.PartNumber.trim() : null;
                        var limit = value.Limit ? parseInt(value.Limit) : null;
                        var triggerLimit = value.TriggerLimit
                        var description = value.Description ? value.Description.trim() : null;

                        student += '<tr>';
                        student += '<td>' +
                            (key + 1) + '</td>';
                        student += '<td>' +
                            _fixtureId + '</td>';

                        if (supplier in Suppliers) {
                            student += '<td id="' + Suppliers[supplier] + '">' +
                                supplier + '</td>';
                        }
                        else {
                            isValid = false;
                            student += '<td style="background-color:red">' +
                                supplier + '</td>';
                        }

                        if (category in Categories) {
                            student += '<td id="' + Categories[category] + '">' +
                                category + '</td>';
                        }
                        else {
                            isValid = false;
                            student += '<td style="background-color:red">' +
                                category + '</td>';
                        }

                        if (parseInt(limit)) {
                            student += '<td>' +
                                limit + '</td>';
                        }
                        else {
                            isValid = false;
                            student += '<td style="background-color:red">' +
                                limit + '</td>';
                        }

                        if (location) {
                            student += '<td>' +
                                location.toUpperCase() + '</td>';
                        }
                        else {
                            isValid = false;
                            student += '<td style="background-color:red">' +
                                location + '</td>';
                        }
                        if (partNumber) {
                            student += '<td>' +
                                partNumber.toUpperCase() + '</td>';
                        }
                        else {
                            isValid = false;
                            student += '<td style="background-color:red">' +
                                partNumber + '</td>';
                        }
                        if (_customLimit)
                            if (parseInt(triggerLimit)) {
                                student += '<td>' + value.TriggerLimit + '</td>';
                            }
                            else {
                                isValid = false;
                                student += '<td style="background-color:red">' + triggerLimit + '</td>';
                            }
                        else
                            student += '<td>default</td>';

                        student += '<td >' +
                            description + '</td>';
                        student += '</tr>';
                    })

                    //INSERTING ROWS INTO TABLE
                    $('#preview-table').html(student);

                    // SHOW ADD BUTTON WHEN CONTENT FORMAT IS CORRECT
                    if (isValid) {
                        // show ADD button
                        document.getElementById('btn-add').style.visibility = 'visible';
                    }
                })
            };

            reader.onerror = function (ex) {
                console.log(ex);
            };

            reader.readAsBinaryString(file);
        };
    };


    function Preview() {
        ResetView();
        var customLimit = document.getElementById('customLimit').checked ? 1 : 0;
        var fixtureId = $('#txt-machineName-search option:selected').val() ? $('#txt-machineName-search option:selected').text() : null;

        const selectedFile = document.getElementById('upload').files;
        var countselectedFile = selectedFile.length;
        debugger
        if (fixtureId && countselectedFile) {
            var xl2json = new ExcelToJSON();
            xl2json.parseExcel(selectedFile[0], fixtureId, customLimit);
        }
        else {
            bootbox.alert('Please select machine or file');
        }
    }
  
    function Add() {
        $("#loading").show();
        var fixId = $('#txt-machineName-search option:selected').val();
        const selectedFile = document.getElementById('upload').files[0];
        var customLimit = document.getElementById('customLimit').checked ? 1 : 0;
        debugger
        var xl2json = new ProcessExcel();
        xl2json.parseExcel(selectedFile, fixId, customLimit);
        //setTimeout(() => { $("#loading").hide(); bootbox.alert('Upload done'); }, 4000);
        //sample();
        $("#loading").hide();

    }

  

})