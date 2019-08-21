// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncAccountCallLogParameters syncAccountCallLogParameters = new SyncAccountCallLogParameters {
    //syncType = 'FSync',
    //syncToken = "<ENTER VALUE>",
    //dateFrom = "<ENTER VALUE>",
    //recordCount = 000,
    //statusGroup = 'Missed',
    //view = 'Simple',
    //showDeleted = true
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
var r = await rc.Restapi().Account(accountId).CallLogSync().Get(syncAccountCallLogParameters);
// PROCESS RESPONSE
