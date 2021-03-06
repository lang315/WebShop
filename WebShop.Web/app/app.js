﻿/// <reference path="../assets/admin/libs/angular/angular.js" />


(function () {
    angular.module('webshop',
        ['webshop.products',
         'webshop.product_categories',
         'webshop.common'])
        .config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];

    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });
        $urlRouterProvider.otherwise('/admin');
    }
})();