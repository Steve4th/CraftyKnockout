var CoderProfile = function () {
    this.coderName = ko.observable('EnterName');
    this.fameScore = ko.observable(0);
    this.famousFor = ko.observable('Enter a claim to fame');
};


function CompareCoder(left, right) {
    console.log(ko.utils.unwrapObservable(left));
    if (left.fameScore() === right.fameScore()) {
        return 0;
    }
    else {
        if (left.fameScore() < right.fameScore()) {
            return -1;
        }
        else {
            return 1;
        }
    }
}

function HallOfFrameViewModel() {
    self = this;

    self.FamousCoders = ko.observableArray([]);

    self.EditableRecord = ko.observable();

    self.AddCoder = function () {
        var coder = new CoderProfile()
            .fameScore(0)
            .coderName('')
            .famousFor('');
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
        self.FamousCoders.sort(CompareCoder);
    };

}


var viewModel = new HallOfFrameViewModel();
ko.applyBindings(viewModel);