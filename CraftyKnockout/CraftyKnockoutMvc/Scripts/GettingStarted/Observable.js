function HelloViewModel() {
    var self = this;

    self.enteredText = ko.observable('');

}

var viewModel = new HelloViewModel();
ko.applyBindings(viewModel);