// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListAccountSwitchesParameters listAccountSwitchesParameters = new ListAccountSwitchesParameters {
    //siteId = "<ENTER VALUE>",
    //searchString = "<ENTER VALUE>",
    //orderBy = "<ENTER VALUE>",
    //perPage = 000,
    //page = 1
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Switches().List(listAccountSwitchesParameters);
// PROCESS RESPONSE
