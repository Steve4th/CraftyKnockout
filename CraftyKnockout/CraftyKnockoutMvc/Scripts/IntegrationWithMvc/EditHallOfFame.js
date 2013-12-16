//to create a new entity we end up duplicating the C# class - boo
var CoderProfile = function () {
    this.CoderName = ko.observable();
    this.FameScore = ko.observable(0);
    this.FamousFor = ko.observable();
    this.isNew = ko.observable(true);
};


function EditableHallOfFrame(initialListOfCoders) {
    self = this;

    self.FamousCoders = ko.mapping.fromJSON(initialListOfCoders);

    self.AddCoder = function () {
        var newCoder = new CoderProfile()
                .CoderName('Enter Name Here')
                .FamousFor('Enter claim to fame here')
                .FameScore(0)
                .isNew(true);

        self.FamousCoders.push(newCoder);
        console.log('Added Coder');
    };
    
    self.FamousCoderCount = ko.computed(function () {
        return self.FamousCoders().length;
    });

    self.NewCoderCount = ko.computed(function () {
        var newCount = 0;
        ko.utils.arrayForEach(self.FamousCoders, function (item) {
            if (item.isNew()) { newCount++;}
        })
        console.log('NewCoderCount Called and found:' + newCount);
        return newCount;
    });

    self.RemoveCoder = function (record) {
        console.log('Removing Coder');
        self.FamousCoders.remove(record);
    };
    
    self.SaveIt = function () {
        
        // Do not just reference the array/model! 
        // It will not include your observables because they are functions
        console.log(JSON.stringify(self.FamousCoders()));

        // Use the ko.toJS to convert the array into POJO's. 
        // This way when encoded by the postJson method the observable properties are also included,
        var jsPayLoad = ko.toJS(self.FamousCoders()); 
        console.log(jsPayLoad);
        
        //post back the model as JSON to the server
        ko.utils.postJson(location.href, { model: jsPayLoad });
    };
}


$(document).ready(function () {
    //get our list of coders in JSON form to use to seed the knockout observable array
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = EditableHallOfFrame(listOfCoders);

    ko.applyBindings(viewModel);
});
