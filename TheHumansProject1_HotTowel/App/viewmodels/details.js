define(['services/logger', 'services/dataservice'], function (logger, dataservice) {
    var human = ko.observable();

    var vm = {
        activate: activate,
        human: human,
        title: 'Details View'
    };

    return vm;

    //#region Internal Methods
    function activate(routeData) {
        var id = parseInt(routeData.id);
        logger.log('Details View Activated', null, 'details', true);
        return dataservice.getHumanById(id, human);
    }
    //#endregion
});