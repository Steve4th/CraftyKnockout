function HelloViewModel() {

    viewModelMessage = "Hello Crafty Coders";

    viewModelButton = function () {
        alert('Hello Crafty Coders');
    }
}

var viewModel = new HelloViewModel();
ko.applyBindings(viewModel);