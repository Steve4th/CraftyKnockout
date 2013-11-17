function HallOfFameViewModel(coderList) {
    self = this;

    // Use the Knockout Mapping utility function to convert the supplied JSON into an observable array
    self.FamousCoders = ko.mapping.fromJSON(coderList);
}


$(document).ready(function () {
    //get our list of codes in JSON form to use to seed the knockout observable array
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = new HallOfFameViewModel(listOfCoders);

    ko.applyBindings(viewModel);
});
