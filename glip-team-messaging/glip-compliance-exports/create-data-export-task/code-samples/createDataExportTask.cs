// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
CreateDataExportTaskRequest createDataExportTaskRequest = new CreateDataExportTaskRequest {
    dateFrom = "<ENTER VALUE>",
    dateTo = "<ENTER VALUE>",
    userIds = new[] {
        "<ENTER VALUE>",
    },
    chatIds = new[] {
        "<ENTER VALUE>",
    }
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
var r = await rc.Restapi().Glip().DataExport().Post(createDataExportTaskRequest);
// PROCESS RESPONSE
