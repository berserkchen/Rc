/// <reference path="angular.js" />
function rcController($scope, $http, $q) {

    function reportXLS() {
        var deferred = $q.defer();
        $http.get('/api/Report').success(function (results) {
            window.open('/api/Report', '_self', '');
            deferred.resolve(results);
        }).error(function (data, status, headers, config) {
            deferred.reject('Failed generate pdf');
        });

        return deferred.promise;
    };

    $scope.reportXLS = function () {
        reportXLS();
    }


    function processError(error) {
        toastr.error(error);
    }

}
