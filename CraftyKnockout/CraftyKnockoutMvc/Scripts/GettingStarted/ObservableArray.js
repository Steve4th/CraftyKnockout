function CoderProfile() {
    coderName = ko.observable('EnterName');
    score = ko.observable(0);
    famousFor = ko.observable('Enter your claim to fame');
    presentationDate = ko.observable(Date.now());
};

function HallOfFrameViewModel() {
    self = this;

    self.FamousCoders = ko.observableArray([]);

    self.currentRecord = ko.observable(new CoderProfile());

    self.AddCoder = function () {
        var coder = new CoderProfile();
        self.FamousCoders.push(coder);
        //self.currentRecord(coder);
    };

    self.RemoveCoder = function(record) {
        self.FamousCoders.remove(record);
    };

    self.EditCoder = function(record) {
        self.currentRecord(record);
    };

    self.SortCoders = function () {
        self.FamousCoders().sort(function (left, right) {
            return left.score == right.score ? 0 : (left.score < right.score ? -1 : 1)
        });
    };
}


var viewModel = new HallOfFrameViewModel();

//push an example record into the hall of fame model
//var firstCoder = new CoderProfile();
//firstCoder.coderName('Jon Skeet');
//firstCoder.score(10);
//firstCoder.famousFor('Stack overflow answers');
//viewModel.FamousCoders().push(firstCoder);

ko.applyBindings(viewModel);