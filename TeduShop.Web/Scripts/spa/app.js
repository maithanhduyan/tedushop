/// <reference path="../plugins/angular/angular.js" />

var myApp = angular.module('myModule', []);

myApp.controller("studentController", studentController);
myApp.controller("teacherController", teacherController);
myApp.controller("schoolController", schoolController);

//declare
function studentController($scope) {
    $scope.message = "This is my message from Student";
}

function teacherController($scope) {
    $scope.message = "This is message from Teacher"
}

function schoolController($scope) {
    $scope.message = "This is message from School"
}