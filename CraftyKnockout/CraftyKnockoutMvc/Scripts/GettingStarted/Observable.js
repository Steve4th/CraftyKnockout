function ObservableViewModel() {
    var self = this;

    self.enteredText = ko.observable('');
}

var viewModel = new ObservableViewModel();
ko.applyBindings(viewModel);