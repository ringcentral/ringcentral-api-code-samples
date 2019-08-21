// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCompanyActiveCallsParameters listCompanyActiveCallsParameters = new ListCompanyActiveCallsParameters {
    //direction = new[] { "Inbound", "Outbound" },
    //view = 'Simple',
    //type = new[] { "Voice", "Fax" },
    //transport = new[] { "PSTN", "VoIP" },
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
var r = await rc.Restapi().Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters);
// PROCESS RESPONSE
