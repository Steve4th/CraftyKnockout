function HallOfFameViewModel(coderList) {
    self = this;

    // Use the Knockout Mapping utility function to convert the supplied JSON into an observable array
    self.FamousCoders = ko.mapping.fromJSON(coderList);

    self.SortCoders = function () {
        //TODO
    }

    self.Debug = ko.observable('debugging');
}


$(document).ready(function () {
    //get our list of codes in JSON form to use to seed the knockout observable array
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = new HallOfFameViewModel(listOfCoders);

    ko.applyBindings(viewModel);
});
