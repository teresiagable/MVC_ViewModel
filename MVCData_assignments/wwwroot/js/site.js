"use strict";


function EditPerson(theId) {
    console.log(theId);
    $.get("Person/Edit/" + theId, function (data, status) {
        //console.log("Data: " + data + "\nStatus: " + status);
        console.log("target id: " + "#personViewCard" + theId);

        $("#personViewCard" + theId).replaceWith(data);

        //$('#' + html_id).replaceWith(data);
    });
}

function UpdatePerson(theId) {
    event.preventDefault();

    let theForm = event.target;
    console.log("theId",theId);
    console.log(theForm);

    console.log("theForm[0]", theForm[0].value);

    //Serialize the form datas.   
    var valdata = $(theForm).serialize();

    //to get alert popup 
    console.log("valdata",valdata);

    console.log(valdata);
    var request = $.ajax({
        url: "/Person/Update",
        type: "POST",
        dataType: 'json',
        contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
        data: valdata
    });

    request.done(function (data) {
        $("#personViewCard" + theId).replaceWith(data);
    });

    request.fail(function (jqXHR, textStatus) {
        console.log("Request failed: " + textStatus);
    });
}


$(document).ready(function () {
    $("#btnEditPersonOrig").click(function (Id) {
        console.log("id");
        console.log(id);
        console.log(event);
        console.log(event.document);
        var parent = $(this).parent().parent();
        $.get("Person/Edit/" + id, function (data, status) {
            console.log(event);

            console.log("Data: " + data + "\nStatus: " + status);

            $("#divKey").html(data);
        });
    });
});