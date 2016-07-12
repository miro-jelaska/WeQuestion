﻿(function () {
    'use strict';

    angular.module('app').config(AdminCreateStateConfig);

    AdminCreateStateConfig.$inject = ['$stateProvider'];
    function AdminCreateStateConfig($stateProvider) {
        $stateProvider
        .state('admin.create', {
            url: '/create',
            views: {
                'menu@admin': {
                    template: '<a ui-sref="admin.provisional"> ✕ </a>'
                },
                'content@admin': {
                    templateUrl: '/Scripts/app/admin/editor.template.html',
                    controller: 'adminCreateController',
                    controllerAs: 'vm'
                }
            }
        });
    }
})();