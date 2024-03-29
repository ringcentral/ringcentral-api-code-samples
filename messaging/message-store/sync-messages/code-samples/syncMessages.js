// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';
const extensionId = '<ENTER VALUE>';

// OPTIONAL QUERY PARAMETERS
const queryParams = {
    //conversationId: 000,
    //dateFrom: '<ENTER VALUE>',
    //dateTo: '<ENTER VALUE>',
    //direction: [ 'Inbound', 'Outbound' ],
    //distinctConversations: true,
    //messageType: [ 'Fax', 'SMS', 'VoiceMail', 'Pager', 'Text' ],
    //recordCount: 000,
    //syncToken: '<ENTER VALUE>',
    //syncType: [ 'FSync', 'ISync' ]
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.get(`/restapi/v1.0/account/${accountId}/extension/${extensionId}/message-sync`, queryParams).then((r) => {
        // PROCESS RESPONSE
    });
});
