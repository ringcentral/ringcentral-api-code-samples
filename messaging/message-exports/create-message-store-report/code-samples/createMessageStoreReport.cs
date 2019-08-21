// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateMessageStoreReportRequest createMessageStoreReportRequest = new CreateMessageStoreReportRequest {
    dateFrom = "<ENTER VALUE>",
    dateTo = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest);
// PROCESS RESPONSE
