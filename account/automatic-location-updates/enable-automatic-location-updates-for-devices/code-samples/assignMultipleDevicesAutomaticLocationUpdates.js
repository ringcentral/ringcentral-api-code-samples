// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';

// POST BODY
const body = {
    enabledDeviceIds: [
        '<ENTER VALUE>',
    ],
    disabledDeviceIds: [
        '<ENTER VALUE>',
    ]
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.post(`/restapi/v1.0/account/${accountId}/emergency-address-auto-update/devices/bulk-assign`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
