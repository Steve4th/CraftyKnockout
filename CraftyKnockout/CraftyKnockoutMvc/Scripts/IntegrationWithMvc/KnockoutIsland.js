$(document).ready(function () {
    //get our list of coders in JSON form form the views hidden field and use it to seed the knockout view model
    var listOfCoders = $('#eventModelJson').val();

    //the ko.mapping plug-in makes it a lot easier to create a view model from a JSON string.
    //The mapping process can be augmented and modified as required.
    var viewModel = ko.mapping.fromJSON(listOfCoders);

    ko.applyBindings(viewModel);
});
