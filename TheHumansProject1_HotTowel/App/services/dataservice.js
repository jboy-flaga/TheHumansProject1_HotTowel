define(['services/model'], function (model) {

    var getHumans = function (humansObservable) {
        // reset the observable
        humansObservable([]);

        // set ajax call
        var options = {
            url: "api/humans",
            type: "GET",
            dataType: "json"
        };
        
        // make ajax call
        return $.ajax(options)
            .then(querySucceeded)
            .fail(queryFailed);

        // handle the ajax callback
        function querySucceeded(data) {
            var humans = [];
            data.forEach(function (item) {
                var h = new model.Human(item);
                humans.push(h);
            });

            humansObservable(humans);
        }
    };

    var getHumanById = function (id, humanObservable) {
        // set ajax call
        var options = {
            url: "api/humans/" + id,
            type: "GET",
            dataType: "json"
        };

        // make ajax call
        return $.ajax(options)
            .then(querySucceeded)
            .fail(queryFailed);

        // handle the ajax callback
        function querySucceeded(data) {
            var human = new model.Human(data);
            humanObservable(human);
        }
    };

    var dataservice = {
        getHumans: getHumans,
        getHumanById: getHumanById
    };

    return dataservice;

    function queryFailed(jqXHR, textStatus) {
        var msg = "Error getting data. " + textStatus;
        //log message
    }
});