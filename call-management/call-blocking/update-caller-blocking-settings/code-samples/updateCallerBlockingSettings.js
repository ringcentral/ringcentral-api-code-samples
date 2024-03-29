// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';
const extensionId = '<ENTER VALUE>';

// POST BODY
const body = {
    mode: 'Specific',
    noCallerId: 'BlockCallsAndFaxes',
    payPhones: 'Block',
    greetings: [
        {
            type: '<ENTER VALUE>',
            preset: {
                uri: '<ENTER VALUE>',
                id: '<ENTER VALUE>',
                name: '<ENTER VALUE>'
            }
        },
    ]
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.put(`/restapi/v1.0/account/${accountId}/extension/${extensionId}/caller-blocking`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
