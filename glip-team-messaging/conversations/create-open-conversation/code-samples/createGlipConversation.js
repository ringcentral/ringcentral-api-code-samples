// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
const body = {
    members: [
        {
            id: '<ENTER VALUE>',
            email: '<ENTER VALUE>'
        },
    ]
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.post(`/restapi/v1.0/glip/conversations`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
