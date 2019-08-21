// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CallRecordingSettingsResource callRecordingSettingsResource = new CallRecordingSettingsResource {
    onDemand = new OnDemandResource {
        enabled = true
    },
    automatic = new AutomaticRecordingResource {
        enabled = true,
        outboundCallTones = true,
        outboundCallAnnouncement = true,
        allowMute = true,
        extensionCount = 000
    },
    greetings = new[] {
        new GreetingResource {
            type = 'StartRecording',
            mode = 'Default'
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
var r = await rc.Restapi().Account(accountId).CallRecording().Put(callRecordingSettingsResource);
// PROCESS RESPONSE
