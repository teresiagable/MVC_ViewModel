"use strict";

$(document).ready(function () {
    $("#btnEditPerson").click(function (id) {
        console.log(event);

        $.get("Person/Edit/" + id, function (data, status) {
            console.log("Data: " + data + "\nStatus: " + status);

            console.log("Data: " + data + "\nStatus: " + status);

            $("#targetPartial").html(data);
        });
    });
});