function HelloViewModel() {
    var self = this;

    self.viewModelMessage = "Hello Crafty Coders";

    self.viewModelButton = function () {
        alert('Hello Crafty Coders');
    };
}

var viewModel = new HelloViewModel();
ko.applyBindings(viewModel);