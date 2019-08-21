// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionActiveCallsParameters listExtensionActiveCallsParameters = new ListExtensionActiveCallsParameters {
    //direction = new[] { "Inbound", "Outbound" },
    //view = 'Simple',
    //type = new[] { "Voice", "Fax" },
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters);
// PROCESS RESPONSE
