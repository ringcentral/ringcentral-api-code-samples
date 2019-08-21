// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallQueuesParameters listCallQueuesParameters = new ListCallQueuesParameters {
    //page = 1,
    //perPage = 100,
    //memberExtensionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallQueues().Get(listCallQueuesParameters);
// PROCESS RESPONSE
