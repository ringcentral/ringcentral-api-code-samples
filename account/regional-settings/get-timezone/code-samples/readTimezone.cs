// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string timezoneId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadTimezoneParameters readTimezoneParameters = new ReadTimezoneParameters {
    //page = '1',
    //perPage = '100'
};

RestClient rc = new RestClient(
    Environment.GetEnvironmentVariable("clientId"),
    Environment.GetEnvironmentVariable("clientSecret"),
    false
);
await rc.Authorize(
    Environment.GetEnvironmentVariable("username"),
    Environment.GetEnvironmentVariable("extension"),
    Environment.GetEnvironmentVariable("password")
);
var r = await rc.Restapi().Dictionary().Timezone(timezoneId).Get(readTimezoneParameters);
// PROCESS RESPONSE
