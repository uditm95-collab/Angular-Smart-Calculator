var app = angular.module("calcApp", []);

app.controller("calcController", function($scope, $http) {
    $scope.calculate = function() {
        $http.get("https://localhost:5001/api/calculator/calculate", {
            params: {
                num1: $scope.num1,
                num2: $scope.num2,
                operation: $scope.operation
            }
        }).then(function(response) {
            $scope.result = response.data.result;
        }, function(error) {
            $scope.result = "Error: " + error.data;
        });
    };
});
