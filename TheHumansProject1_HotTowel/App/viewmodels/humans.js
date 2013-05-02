define(['services/logger', 'services/dataservice', 'durandal/plugins/router'], function (logger, dataservice, router) {
    var humans = ko.observableArray();
    var initialized = false;

    var vm = {
        activate: activate,
        gotoDetails: gotoDetails,
        humans: humans,
        refresh: refresh,
        title: 'Humans View'
    };

    return vm;

    function refresh(forceRefresh) {
                        // if (forceRefresh is not undefined) { return forceRefresh} else { return true}
        forceRefresh = !forceRefresh ? forceRefresh : true;
        if (!forceRefresh && initialized) {
            return;
        }
        initialized = true;
        return dataservice.getHumans(humans);
    }

    function gotoDetails(selectedHuman) {
        if (selectedHuman && selectedHuman.id) {
            var url = '#/details/' + selectedHuman.id;
            router.navigateTo(url);
        }
    }

    //#region Internal Methods
    function activate() {
        logger.log('Humans View Activated', null, 'humans', true);
        return refresh(false);
    }
    //#endregion
});