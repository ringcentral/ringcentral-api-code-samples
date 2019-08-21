// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CallerBlockingSettingsUpdate callerBlockingSettingsUpdate = new CallerBlockingSettingsUpdate {
    mode = 'Specific',
    noCallerId = 'BlockCallsAndFaxes',
    payPhones = 'Block',
    greetings = new[] {
        new BlockedCallerGreetingInfo {
            type = "<ENTER VALUE>",
            preset = new PresetInfo {
                uri = "<ENTER VALUE>",
                id = "<ENTER VALUE>",
                name = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate);
// PROCESS RESPONSE
