// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CreateForwardingNumberRequest createForwardingNumberRequest = new CreateForwardingNumberRequest {
    phoneNumber = "<ENTER VALUE>",
    label = "<ENTER VALUE>",
    type = 'PhoneLine',
    device = new CreateForwardingNumberDeviceInfo {
        id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest);
// PROCESS RESPONSE
