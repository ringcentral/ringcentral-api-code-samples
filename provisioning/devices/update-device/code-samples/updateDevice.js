// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const deviceId = '<ENTER VALUE>';
const accountId = '<ENTER VALUE>';

// POST BODY
const body = {
    emergencyServiceAddress: {
        street: '<ENTER VALUE>',
        street2: '<ENTER VALUE>',
        city: '<ENTER VALUE>',
        zip: '<ENTER VALUE>',
        customerName: '<ENTER VALUE>',
        state: '<ENTER VALUE>',
        stateId: '<ENTER VALUE>',
        stateIsoCode: '<ENTER VALUE>',
        stateName: '<ENTER VALUE>',
        countryId: '<ENTER VALUE>',
        countryIsoCode: '<ENTER VALUE>',
        country: '<ENTER VALUE>',
        countryName: '<ENTER VALUE>'
    },
    extension: {
        id: '<ENTER VALUE>'
    },
    phoneLines: {
        phoneLines: [
            {
                id: '<ENTER VALUE>'
            },
        ]
    },
    useAsCommonPhone: true
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.put(`/restapi/v1.0/account/${accountId}/device/${deviceId}`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
