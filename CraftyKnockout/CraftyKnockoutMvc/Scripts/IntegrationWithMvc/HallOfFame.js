$(document).ready(function () {
    //get our list of coders in JSON form form the views hidden field and use it to seed the knockout view model
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = ko.mapping.fromJSON(listOfCoders);

    ko.applyBindings(viewModel);
});
