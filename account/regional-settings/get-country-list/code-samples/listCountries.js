// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
const queryParams = {
    //loginAllowed: true,
    //signupAllowed: true,
    //numberSelling: true,
    //page: 1,
    //perPage: 100,
    //freeSoftphoneLine: true
};

const SDK = require('ringcentral');
const rcsdk = new SDK({server: process.env.serverURL, appKey: process.env.clientId, appSecret: process.env.clientSecret});
const platform = rcsdk.platform();
platform.login({ username: process.env.username, extension: process.env.extension, password: process.env.password }).then(() => {
    platform.get(`/restapi/v1.0/dictionary/country`, queryParams).then((r) => {
        // PROCESS RESPONSE
    });
});
