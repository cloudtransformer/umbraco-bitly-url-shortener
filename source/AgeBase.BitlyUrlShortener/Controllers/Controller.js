angular.module("umbraco").controller("AgeBase.BitlyUrlShortener", function ($scope, $routeParams, contentResource) {
    var nodeUrl;
    contentResource.getNiceUrl($routeParams.id).then(function (url) {
        nodeUrl = url;
    });
    $scope.generate = function () {
        $.getJSON(
            "http://api.bitly.com/v3/shorten?callback=?",
            {
                "format": "json",
                "apiKey": $scope.model.config.apiKey,
                "login": $scope.model.config.login,
                "longUrl": window.location.protocol + "//" + window.location.host + nodeUrl
            },
            function (response) {
                if (response && response.data && response.data.url)
                    $scope.model.value = response.data.url;
                else
                    $scope.model.value = "";
            }
        );
    };
});