// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';
const telephonySessionId = '<ENTER VALUE>';
const partyId = '<ENTER VALUE>';

// POST BODY
const body = {
    party: {
        muted: true,
        standAlone: true
    }
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.patch(`/restapi/v1.0/account/${accountId}/telephony/sessions/${telephonySessionId}/parties/${partyId}`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
