// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const extensionId = '<ENTER VALUE>';
const accountId = '<ENTER VALUE>';

// POST BODY
const body = {
    topic: '<ENTER VALUE>',
    meetingType: 'Scheduled',
    schedule: {
        startTime: '<ENTER VALUE>',
        durationInMinutes: 000,
        timeZone: {
            uri: '<ENTER VALUE>',
            id: '<ENTER VALUE>',
            name: '<ENTER VALUE>',
            description: '<ENTER VALUE>'
        }
    },
    password: '<ENTER VALUE>',
    host: {
        id: '<ENTER VALUE>'
    },
    allowJoinBeforeHost: true,
    startHostVideo: true,
    startParticipantsVideo: true,
    usePersonalMeetingId: true,
    audioOptions: [
        '<ENTER VALUE>',
    ]
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.post(`/restapi/v1.0/account/${accountId}/extension/${extensionId}/meeting`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
