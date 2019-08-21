// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallRecordingCustomGreetingsParameters listCallRecordingCustomGreetingsParameters = new ListCallRecordingCustomGreetingsParameters {
    //type = 'StartRecording'
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
var r = await rc.Restapi().Account(accountId).CallRecording().CustomGreetings().List(listCallRecordingCustomGreetingsParameters);
// PROCESS RESPONSE
