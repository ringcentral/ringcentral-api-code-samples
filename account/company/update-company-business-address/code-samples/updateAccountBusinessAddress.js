// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';

// POST BODY
const body = {
    company: '<ENTER VALUE>',
    email: '<ENTER VALUE>',
    businessAddress: {
        country: '<ENTER VALUE>',
        state: '<ENTER VALUE>',
        city: '<ENTER VALUE>',
        street: '<ENTER VALUE>',
        zip: '<ENTER VALUE>'
    }
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.put(`/restapi/v1.0/account/${accountId}/business-address`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
