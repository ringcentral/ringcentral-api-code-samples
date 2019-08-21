// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
CreateSipRegistrationRequest createSipRegistrationRequest = new CreateSipRegistrationRequest {
    device = new[] {
        new DeviceInfoRequest {
            id = "<ENTER VALUE>",
            appExternalId = "<ENTER VALUE>",
            computerName = "<ENTER VALUE>"
        },
    },
    sipInfo = new[] {
        new SIPInfoRequest {
            transport = 'UDP'
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
var r = await rc.Restapi().ClientInfo().SipProvision().Post(createSipRegistrationRequest);
// PROCESS RESPONSE
