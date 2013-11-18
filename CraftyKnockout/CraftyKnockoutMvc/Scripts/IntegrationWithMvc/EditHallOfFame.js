function EditableHallOfFrame(initialListOfCoders) {
    self = this;

    self.FamousCoders = ko.mapping.fromJSON(initialListOfCoders);

    self.FamousCoderCount = ko.computed(function () {
        return self.FamousCoders().length;
    });

    self.RemoveCoder = function (record) {
        //self.FamousCoders.remove(record);
    };

    self.SaveIt = function () {
        //postback the model as JSON to the server
        ko.utils.postJson(location.href, { model: self });

        //// Use the ko.toJS to convert the array into POJO's. 
        //// This way when encoded by the postJson method the observable properties are also included,
        ////var jsDataPayload = ko.toJS(self.NumberdwellingTypes);
        ////ko.utils.postJson(location.href, { NumberdwellingTypes: jsDataPayload });
    };
}

$(document).ready(function () {
    //get our list of coders in JSON form to use to seed the knockout observable array
    var listOfCoders = $('#initialCoderListJson').val();

    var viewModel = EditableHallOfFrame(listOfCoders);

    ko.applyBindings(viewModel);
});
