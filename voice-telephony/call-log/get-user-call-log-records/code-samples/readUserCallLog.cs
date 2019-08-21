// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadUserCallLogParameters readUserCallLogParameters = new ReadUserCallLogParameters {
    //extensionNumber = "<ENTER VALUE>",
    //showBlocked = true,
    //phoneNumber = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //sessionId = "<ENTER VALUE>",
    //type = new[] { "Voice", "Fax" },
    //transport = new[] { "PSTN", "VoIP" },
    //view = 'Simple',
    //withRecording = true,
    //recordingType = 'Automatic',
    //dateTo = "<ENTER VALUE>",
    //dateFrom = "<ENTER VALUE>",
    //page = 1,
    //perPage = 100,
    //showDeleted = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLog().List(readUserCallLogParameters);
// PROCESS RESPONSE
