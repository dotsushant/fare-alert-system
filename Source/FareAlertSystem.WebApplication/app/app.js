'use strict';

//// Declare app level module which depends on views, and components
//angular.module('myApp', [
//  'ngRoute',
//  'myApp.view1',
//  'myApp.view2',
//  'myApp.version'
//]).
//config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
//  $locationProvider.hashPrefix('!');

//  $routeProvider.otherwise({redirectTo: '/view1'});
//}]);
//var app = angular.module('StarterApp', ['ngMaterial']);

//app.controller('AppCtrl', ['$scope', '$mdSidenav', function ($scope, $mdSidenav) {
//    $scope.toggleSidenav = function (menuId) {
//        $mdSidenav(menuId).toggle();
//    };

//}]);

angular.module('fareAlertApp', ['ngMaterial'])
       .controller('radioButtonsController', radioButtonsController)
       .controller('passengerSelectContainer', passengerSelectContainer)
       .controller('selectController', selectController);


function radioButtonsController($scope) {
    $scope.radioData = [
       { label: 'One Way', value: 'oneway' },
       { label: 'Round', value: 'round' },
    ];
    $scope.group = 'round';
}

function selectController($scope) {
    $scope.fromCities = [
      { value: 'IDR', name: 'Indore' },
      { value: 'DEL', name: 'Delhi' },
      { value: 'MUM', name: 'Mumbai' }
    ];
    $scope.selectedFrom = { id: 'DEL', name: 'Delhi' };

    $scope.toCities = [
      { value: 'IDR', name: 'Indore' },
      { value: 'DEL', name: 'Delhi' },
      { value: 'MUM', name: 'Mumbai' }
    ];
    $scope.selectedTo = { id: 'DEL', name: 'Delhi' };

}

function passengerSelectContainer($scope) {
    $scope.adults = [
      { id: 1 },
      { id: 2 },
      { id: 3 },
      { id: 4 },
      { id: 5 },
      { id: 6 },
    ];
    $scope.selectedAdults = { id: 0 };
    $scope.selectedKids = { id: 0 };
    $scope.selectedInfants = { id: 0 };

}