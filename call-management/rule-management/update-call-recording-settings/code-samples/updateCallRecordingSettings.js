// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const accountId = '<ENTER VALUE>';

// POST BODY
const body = {
    onDemand: {
        enabled: true
    },
    automatic: {
        enabled: true,
        outboundCallTones: true,
        outboundCallAnnouncement: true,
        allowMute: true,
        extensionCount: 000
    },
    greetings: [
        {
            type: 'StartRecording',
            mode: 'Default'
        },
    ]
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.put(`/restapi/v1.0/account/${accountId}/call-recording`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
