function KnockoutIslandViewModel(model) {
    self = this;

    self.EventModel = ko.mapping.fromJSON(model);

    self.AddSpeaker = function (speaker) {
        //move from the possible speakers array to the speakers array
        self.EventModel.Event.Speakers.push(speaker);
        self.EventModel.PossibleSpeakers.remove(speaker);
    };

    self.RemoveSpeaker = function (speaker) {
        self.EventModel.Event.Speakers.remove(speaker);
        self.EventModel.PossibleSpeakers.push(speaker);
    }
}


$(document).ready(function () {
    //get our list of coders in JSON form form the views hidden field and use it to seed the knockout view model
    var listOfCoders = $('#eventModelJson').val();

    //the ko.mapping plug-in makes it a lot easier to create a view model from a JSON string.
    //The mapping process can be augmented and modified as required.
    var viewModel = new KnockoutIslandViewModel(listOfCoders);

    ko.applyBindings(viewModel);
});
