// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
BulkAccountCallRecordingsResource bulkAccountCallRecordingsResource = new BulkAccountCallRecordingsResource {
    addedExtensions = new CallRecordingExtensionResource {
        id = "<ENTER VALUE>",
        uri = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>",
        type = "<ENTER VALUE>",
        callDirection = 'Outbound'
    },
    updatedExtensions = new CallRecordingExtensionResource {
        id = "<ENTER VALUE>",
        uri = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>",
        type = "<ENTER VALUE>",
        callDirection = 'Outbound'
    },
    removedExtensions = new CallRecordingExtensionResource {
        id = "<ENTER VALUE>",
        uri = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>",
        type = "<ENTER VALUE>",
        callDirection = 'Outbound'
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
var r = await rc.Restapi().Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource);
// PROCESS RESPONSE
