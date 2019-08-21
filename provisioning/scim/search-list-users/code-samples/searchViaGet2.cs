// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
SearchViaGet2Parameters searchViaGet2Parameters = new SearchViaGet2Parameters {
    //filter = "<ENTER VALUE>",
    //startIndex = 1,
    //count = 100
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
var r = await rc.Scim().Users().List(searchViaGet2Parameters);
// PROCESS RESPONSE
