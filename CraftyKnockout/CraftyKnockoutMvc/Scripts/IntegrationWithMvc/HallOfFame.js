function HallOfFrameViewModel(coderList) {
    self = this;

    self.FamousCoders = ko.observableArray(coderList);

    self.SortCoders = function () {
        //TODO
    }
}

//get our list of codes in JSON form to use to seed the knockout observable array
var listOfCoders = $('initialCoderListJson').val(); 
var viewModel = new HallOfFrameViewModel(listOfCoders);

ko.applyBindings(viewModel);