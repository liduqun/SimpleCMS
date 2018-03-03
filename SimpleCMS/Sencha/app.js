/*
 * This file launches the application by asking Ext JS to create
 * and launch() the Application class.
 */
Ext.application({
    extend: 'SimpleCMS.Application',

    name: 'SimpleCMS',

    requires: [
        // This will automatically load all classes in the SimpleCMS namespace
        // so that application classes do not need to require each other.
        'SimpleCMS.*'
    ],

    // The name of the initial view to create.
    mainView: 'SimpleCMS.view.main.Main'
});
