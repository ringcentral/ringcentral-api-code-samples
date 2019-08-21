// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";

// POST BODY
SuperviseCallSessionRequest superviseCallSessionRequest = new SuperviseCallSessionRequest {
    mode = 'Listen',
    deviceId = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().Post(superviseCallSessionRequest);
// PROCESS RESPONSE
