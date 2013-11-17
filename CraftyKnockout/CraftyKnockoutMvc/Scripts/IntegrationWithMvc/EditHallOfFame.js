$(document).ready(function () {
    //get our list of codes in JSON form to use to seed the knockout observable array
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = ko.mapping.fromJSON(listOfCoders);

    ko.applyBindings(viewModel);
});
