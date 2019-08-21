// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListUserTemplatesParameters listUserTemplatesParameters = new ListUserTemplatesParameters {
    //type = 'UserSettings',
    //page = "<ENTER VALUE>",
    //perPage = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Templates().List(listUserTemplatesParameters);
// PROCESS RESPONSE
