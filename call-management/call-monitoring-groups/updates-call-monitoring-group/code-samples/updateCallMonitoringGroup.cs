// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// POST BODY
CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest = new CreateCallMonitoringGroupRequest {
    id = "<ENTER VALUE>",
    name = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest);
// PROCESS RESPONSE
