// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadCompanyCallLogParameters readCompanyCallLogParameters = new ReadCompanyCallLogParameters {
    //extensionNumber = "<ENTER VALUE>",
    //phoneNumber = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //type = new[] { "Voice", "Fax" },
    //view = 'Simple',
    //withRecording = true,
    //recordingType = 'Automatic',
    //dateFrom = "<ENTER VALUE>",
    //dateTo = "<ENTER VALUE>",
    //page = 1,
    //perPage = 100,
    //sessionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallLog().List(readCompanyCallLogParameters);
// PROCESS RESPONSE
