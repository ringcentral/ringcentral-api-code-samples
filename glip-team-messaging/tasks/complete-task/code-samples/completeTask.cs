// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";

// POST BODY
GlipCompleteTask glipCompleteTask = new GlipCompleteTask {
    status = 'Incomplete',
    assignees = new[] {
        new  {
            id = "<ENTER VALUE>"
        },
    },
    completenessPercentage = 000
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
var r = await rc.Restapi().Glip().Tasks(taskId).Complete().Post(glipCompleteTask);
// PROCESS RESPONSE
