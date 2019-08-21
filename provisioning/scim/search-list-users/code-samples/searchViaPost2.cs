// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
SearchRequest searchRequest = new SearchRequest {
    count = 000,
    filter = "<ENTER VALUE>",
    schemas = new[] {
        'urn:ietf:params:scim:api:messages:2.0:SearchRequest',
    },
    startIndex = 000
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
var r = await rc.Scim().Users()..search().Post(searchRequest);
// PROCESS RESPONSE
