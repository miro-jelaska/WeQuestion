﻿(function () {
    'use strict';

    angular.module('app').config(Admin_ProvisionalStateConfig);

    Admin_ProvisionalStateConfig.$inject = ['$stateProvider'];
    function Admin_ProvisionalStateConfig($stateProvider) {
        $stateProvider
        .state('admin.provisional', {
            url: '/provisional',
            data: {
                stateTitle: 'Pregled'
            },
            templateUrl: '/Scripts/app/admin/admin.provisional.template.html',
            controller: 'adminProvisionalController',
            controllerAs: 'vm'
        });
    }
})();