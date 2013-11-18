$(document).ready(function () {

    //get our list of coders in a separate AJAX call.
    $.getJSON("HallOfFameAjaxModel", function (data) {
        var viewModel = ko.mapping.fromJSON(data);

        ko.applyBindings(viewModel);
    });
});
