// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncUserCallLogParameters syncUserCallLogParameters = new SyncUserCallLogParameters {
    //syncType = new[] { "FSync", "ISync" },
    //syncToken = "<ENTER VALUE>",
    //dateFrom = "<ENTER VALUE>",
    //recordCount = 000,
    //statusGroup = new[] { "Missed", "All" },
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters);
// PROCESS RESPONSE
