// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';
const extensionId = '<ENTER VALUE>';

// OPTIONAL QUERY PARAMETERS
const queryParams = {
    //dateTo: '<ENTER VALUE>',
    //phoneNumber: '<ENTER VALUE>',
    //extensionNumber: '<ENTER VALUE>',
    //type: [ 'Voice', 'Fax' ],
    //direction: [ 'Inbound', 'Outbound' ],
    //dateFrom: '<ENTER VALUE>'
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.delete(`/restapi/v1.0/account/${accountId}/extension/${extensionId}/call-log`, queryParams).then((r) => {
        // PROCESS RESPONSE
    });
});
