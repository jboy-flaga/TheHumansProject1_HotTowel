define(function () {
    var imageSettings = {
        imageBasePath: '../../Content/photos/',
        noPhotoImage: 'NoPhoto.jpg'
    };

    var Human = function (humanDto) {
        var s = "";
    	var photo = (humanDto.Photo.trim() === "") ? imageSettings.noPhotoImage : humanDto.Photo;
        //var photo = imageSettings.noPhotoImage;
        return {
            id: humanDto.Id,
            firstName: ko.observable(humanDto.FirstName),
            lastName: ko.observable(humanDto.LastName),
            photoUrl: ko.observable(imageSettings.imageBasePath + photo)
        }
    };

    var model = {
        Human: Human
    };

    return model;
});