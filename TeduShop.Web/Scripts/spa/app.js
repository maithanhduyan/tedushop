/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("schoolController", schoolController);
myApp.service("validator", validator);
schoolController.$inject = ['$scope', 'validator'];

function schoolController($scope, validator) {
    $scope.checkNumber = function () {
        $scope.message = validator.checkNumber($scope.num);
    }
    $scope.num = 1;
}

function validator($window) {
    return { checkNumber: checkNumber }
    function checkNumber(input) {
        if (input % 2 == 0) {
            return 'This is even';
        }
        else return 'This is odd';
    }
}