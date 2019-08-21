// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListGlipConversationsParameters listGlipConversationsParameters = new ListGlipConversationsParameters {
    //recordCount = 30,
    //pageToken = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Conversations().List(listGlipConversationsParameters);
// PROCESS RESPONSE
