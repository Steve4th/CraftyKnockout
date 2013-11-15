function CoderProfile() {
    coderName = ko.observable('EnterName'),
    score = ko.observable(0),
    famousFor = ko.observable('Enter a claim to fame')
};

function HallOfFrameViewModel() {
    self = this;

    self.FamousCoders = ko.observableArray([]);

    self.EditableRecord = ko.observable();

    self.AddCoder = function () {
        var coder = new CoderProfile();
        self.FamousCoders.push(coder);
        self.EditableRecord(coder);
    };

    self.RemoveCoder = function (record) {
        if (record == self.EditableRecord()) {
            self.EditableRecord(null);
        }
        self.FamousCoders.remove(record);
    };

    self.EditCoder = function (data) {
        self.EditableRecord(data);
    };

    self.SortCoders = function () {
        self.FamousCoders.sort(function (left, right) {
            console.log(ko.utils.unwrapObservable(left));
            if (left.score() == right.score()) {
                return 0;
            }
            else {
                if (left.score() < right.score()) {
                    return -1;
                }
                else {
                    return 1;
                }
            }
        });
    };
}


var viewModel = new HallOfFrameViewModel();
ko.applyBindings(viewModel);