$(document).ready(function () {
    $('body').off('click', '#btn-approve').on('click', '#btn-approve', Approve);
    $('body').off('click', '#btn-reject').on('click', '#btn-reject', Reject);
    $('body').off('click', '#btn-show').on('click', '#btn-show', Show);

    var user = document.getElementById('userinfo').getAttribute('data-user');
    var email = document.getElementById('userinfo').getAttribute('data-email');
    var message = '';

    function Show() {
        $('.modal-body').attr("style", "background-color:none");

        message = '';
        reqId = $(this).data('reqid');
        createdby = $(this).data('createdby');
        createdemail = $(this).data('createdemail');
        $('.btn-modal').attr('data-reqid', reqId.toString());
        $('.btn-modal').attr('data-createdby', createdby.toString());
        $('.btn-modal').attr('data-createdemail', createdemail);

        var model = new Object();
        model.ReqId = parseInt(reqId);
        $.ajax({
            type: 'post',
            url: '/Request/Request_Detail',
            data: JSON.stringify(model),
            contentType: 'application/json;charset=utf-8',
            success: function (data) {
                $(".modal-body").html(data);

                if (!(($('#Supplier-New').text()) == ($('#Supplier-Current').text()))) {
                    $('#Supplier-New').attr("style", "background-color:red");
                    message += 'supplier:' + $('#Supplier-Current').text() + '->' + $('#Supplier-New').text() + '; '
                }
                if (!(($('#CategoryName-New').text()) == ($('#CategoryName-Current').text()))) {
                    $('#CategoryName-New').attr("style", "background-color:red");
                    message += 'Category:' + $('#CategoryName-Current').text() + '->' + $('#CategoryName-New').text() + '; '
                }
                if (!(($('#Limit-New').text()) == ($('#Limit-Current').text()))) {
                    $('#Limit-New').attr("style", "background-color:red");
                    message += 'Limit:' + $('#Limit-Current').text() + '->' + $('#Limit-New').text() + ';'
                }
                if (!(($('#Location-New').text()) == ($('#Location-Current').text()))) {
                    $('#Location-New').attr("style", "background-color:red");
                    message += 'Location:' + $('#Location-Current').text() + '->' + $('#Location-New').text() + '; '
                }
                if (!(($('#PartNumber-New').text()) == ($('#PartNumber-Current').text()))) {
                    $('#PartNumber-New').attr("style", "background-color:red");
                    message += 'PartNumber:' + $('#PartNumber-Current').text() + '->' + $('#PartNumber-New').text() + '; '
                }
                if (!(($('#TriggerLimit-New').text()) == ($('#TriggerLimit-Current').text()))) {
                    $('#TriggerLimit-New').attr("style", "background-color:red");
                    message += 'Trigger Limit:' + $('#TriggerLimit-Current').text() + '->' + $('#TriggerLimit-New').text() + ';'
                }

            }
        })
    }

    function Reject() {
        reqId = $(this).data('reqid');
        createdby = $(this).data('createdby');
        createdemail = $(this).data('createdemail');
        var model = new Object();
        model.ReqId = parseInt(reqId);
        model.ReqNumber = "PUC-" + parseInt(reqId);

        model.CreatedBy = createdby.toString();
        model.CreatedEmail = createdemail;
        model.UpdatedBy = user;
        model.UpdatedEmail = email;
        model.Description = $('#txt-description').val();
        message = 'rejected: ' + message
        debugger
        $.ajax({
            type: 'post',
            url: '/Request/Request_Reject',
            data: JSON.stringify(model),
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                var results = response.results;
                if (results.statusCode == 200) {
                    bootbox.alert(results.message, function () { $('#myModal').modal('hide'), location.reload() })
                    //Update_Log(reqId, message);
                }
                else
                    bootbox.alert(results.message)
            }
        })
    }
    function Approve() {
        reqId = $(this).data('reqid');
        createdby = $(this).data('createdby');
        createdemail = $(this).data('createdemail');
        var model = new Object();
        model.ReqId = parseInt(reqId);
        model.ReqNumber = "PUC-" + parseInt(reqId);
        model.CreatedBy = createdby.toString();
        model.CreatedEmail = createdemail;
        model.UpdatedBy = user;
        model.UpdatedEmail = email;
        model.Description = $('#txt-description').val();
        message = 'Modified: ' + message
        debugger
        $.ajax({
            type: 'post',
            url: '/Request/Request_Approve',
            data: JSON.stringify(model),
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            success: function (response) {
                var results = response.results;
                if (results.statusCode == 200) {
                    bootbox.alert(results.message, function () { $('#myModal').modal('hide'), location.reload() })
                    //Update_Log(reqId, message);
                }
                else
                    bootbox.alert(results.message)
            }
        })
    }
})