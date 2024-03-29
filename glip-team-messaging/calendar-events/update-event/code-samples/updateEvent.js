// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
const eventId = '<ENTER VALUE>';

// POST BODY
const body = {
    id: '<ENTER VALUE>',
    creatorId: '<ENTER VALUE>',
    title: '<ENTER VALUE>',
    startTime: '<ENTER VALUE>',
    endTime: '<ENTER VALUE>',
    allDay: true,
    recurrence: 'None',
    endingCondition: '<ENTER VALUE>',
    endingAfter: 000,
    endingOn: 'None',
    color: 'Black',
    location: '<ENTER VALUE>',
    description: '<ENTER VALUE>'
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.put(`/restapi/v1.0/glip/events/${eventId}`, body).then((r) => {
        // PROCESS RESPONSE
    });
});
