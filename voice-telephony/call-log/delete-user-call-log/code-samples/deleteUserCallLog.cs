// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
DeleteUserCallLogParameters deleteUserCallLogParameters = new DeleteUserCallLogParameters {
    //dateTo = "<ENTER VALUE>",
    //phoneNumber = "<ENTER VALUE>",
    //extensionNumber = "<ENTER VALUE>",
    //type = new[] { "Voice", "Fax" },
    //direction = new[] { "Inbound", "Outbound" },
    //dateFrom = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters);
// PROCESS RESPONSE
