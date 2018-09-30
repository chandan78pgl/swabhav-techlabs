(function(){
    'use strict';

    angular
        .module('swabhav.modA', [
            'swabhav.modB',
            'swabhav.modC'
        ])
        .controller('ctrlA',function($scope ,$rootScope){
            console.log("Inside Module A");
            $scope.message="This is the message from module A";
            $rootScope.company="Hitech";
        });

    angular.module('swabhav.modB',[])
        .controller('ctrlB',function($scope,$rootScope){
            console.log("Inside Module B");
            $scope.message="This is the message from module B";
            console.log($rootScope.company+" calling in module B");
        });
    
    angular.module('swabhav.modC',[])
        .controller('ctrlC', function($scope){
            console.log("inside Module C");
            $scope.message="This is the message from module C";

        });

}());