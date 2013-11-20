//to create a new entity we end up duplicating the C# class - boo
function CoderProfile() {
    CoderName = ko.observable('');
    FameScore = ko.observable(0);
    FamousFor = ko.observable('');
};


function EditableHallOfFrame(initialListOfCoders) {
    vmself = this;

    vmself.FamousCoders = ko.mapping.fromJSON(initialListOfCoders);

    vmself.FamousCoderCount = ko.computed(function () {
        return vmself.FamousCoders().length;
    });

    vmself.RemoveCoder = function (record) {
        vmself.FamousCoders.remove(record);
    };

    vmself.AddCoder = function () {
        var newCoder = new CoderProfile();
        vmself.FamousCoders.push(newCoder);
    };

    vmself.SaveIt = function () {
        
        //// Use the ko.toJS to convert the array into POJO's. 
        //// This way when encoded by the postJson method the observable properties are also included,
        var jsPayLoad = ko.toJS(vmself.FamousCoders());

        //postback the model as JSON to the server
        ko.utils.postJson(location.href, { model: jsPayLoad });
    };
}

$(document).ready(function () {
    //get our list of coders in JSON form to use to seed the knockout observable array
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = EditableHallOfFrame(listOfCoders);

    ko.applyBindings(viewModel);
});
