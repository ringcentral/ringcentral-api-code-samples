// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncAddressBookParameters syncAddressBookParameters = new SyncAddressBookParameters {
    //syncType = new[] { "FSync", "ISync" },
    //syncToken = "<ENTER VALUE>",
    //perPage = 000,
    //pageId = 000
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters);
// PROCESS RESPONSE
