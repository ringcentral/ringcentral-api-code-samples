// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
SearchDirectoryEntriesRequest searchDirectoryEntriesRequest = new SearchDirectoryEntriesRequest {
    searchString = "<ENTER VALUE>",
    showFederated = true,
    extensionType = 'User',
    orderBy = new[] {
        new OrderBy {
            index = 000,
            fieldName = 'firstName',
            direction = 'Asc'
        },
    },
    page = 000,
    perPage = 000
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
var r = await rc.Restapi().Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest);
// PROCESS RESPONSE
