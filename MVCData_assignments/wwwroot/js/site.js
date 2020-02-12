"use strict";


function EditPerson(theId) {
    console.log(theId);
    $.get("Person/Edit/" + theId, function (data, status) {
        console.log("Data: " + data + "\nStatus: " + status);
        console.log("Data: " + "#personViewCard" + theId);

        $("#personViewCard" + theId).replaceWith(data);

        //$('#' + html_id).replaceWith(data);
    });
}

function UpdatePerson(theId) {
    event.preventDefault();

    let theForm = event.target;
    console.log(theForm);
    console.log(theForm[0]);
    console.log(theForm[0].value);
    //$.get("Person/Edit/" + theId, function (data, status) {
    //    console.log("Data: " + data + "\nStatus: " + status);
    //    console.log("Data: " + "#personViewCard" + theId);

    //    $("#personViewCard" + theId).replaceWith(data);

    //    //$('#' + html_id).replaceWith(data);
//});
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