// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// POST BODY
CallMonitoringBulkAssign callMonitoringBulkAssign = new CallMonitoringBulkAssign {
    updatedExtensions = new[] {
        new CallMonitoringExtensionUpdate {
            id = "<ENTER VALUE>",
            permissions = new[] {
                'Monitoring',
            }
        },
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign);
// PROCESS RESPONSE
