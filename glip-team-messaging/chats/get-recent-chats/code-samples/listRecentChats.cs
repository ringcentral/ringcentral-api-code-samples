// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListRecentChatsParameters listRecentChatsParameters = new ListRecentChatsParameters {
    //type = new[] { "Everyone", "Group", "Personal", "Direct", "Team" },
    //recordCount = 30
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
var r = await rc.Restapi().Glip().Recent().Chats().Get(listRecentChatsParameters);
// PROCESS RESPONSE
