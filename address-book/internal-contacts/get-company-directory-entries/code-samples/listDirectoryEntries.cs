// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListDirectoryEntriesParameters listDirectoryEntriesParameters = new ListDirectoryEntriesParameters {
    //showFederated = true,
    //type = 'User',
    //page = '1',
    //perPage = 1000,
    //siteId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Directory().Entries().List(listDirectoryEntriesParameters);
// PROCESS RESPONSE
