function ComputedViewModel() {
    var self = this;

    self.NetPrice = ko.observable(100.00);
    self.VatRate = ko.observable(20.00);

    self.VatAmount = ko.computed(function () {
        return (self.NetPrice() * (self.VatRate() / 100)).toFixed(2);
    });

    self.GrossPrice = ko.computed(function () {
        return  ((self.NetPrice() * (self.VatRate() / 100)) + parseFloat(self.NetPrice())).toFixed(2);
    });
}

var viewModel = new ComputedViewModel();
ko.applyBindings(viewModel);