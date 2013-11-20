var CoderProfile = function () {
    this.coderName = ko.observable();
    this.fameScore = ko.observable(0);
    this.famousFor = ko.observable();
    this.isSelected = ko.observable(false);
};


function HallOfFrameViewModel() {
    self = this;

    self.FamousCoders = ko.observableArray([]);

    self.AddCoder = function () {
        //create a new coder using our declared function. You must set some default values for you new object here too.
        var coder = new CoderProfile()
            .fameScore(0)
            .coderName('')
            .famousFor('');

        self.FamousCoders.push(coder);
        self.EditCoder(coder);
        console.log('Added Coder');
    };

    self.RemoveCoder = function (record) {
        console.log('Removing Coder');
        if (record == self.EditableRecord()) {
            self.EditableRecord(null);
        }
        self.FamousCoders.remove(record);
    };

    self.EditableRecord = ko.observable();

    self.EditCoder = function (data) {
        if (self.EditableRecord()) {
            self.EditableRecord().isSelected(false);
        }
        data.isSelected(true);
        self.EditableRecord(data);
    };

    self.SortCoders = function () {
        console.log('Sorting Coders');
        self.FamousCoders.sort(
            function CompareScore(left, right) {
                return right.fameScore() - left.fameScore();
            });
    };
}


var viewModel = new HallOfFrameViewModel();
ko.applyBindings(viewModel);