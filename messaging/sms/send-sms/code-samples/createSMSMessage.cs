// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CreateSMSMessage createSMSMessage = new CreateSMSMessage {
    from = new MessageStoreCallerInfoRequest {
        phoneNumber = "<ENTER VALUE>"
    },
    to = new[] {
        new MessageStoreCallerInfoRequest {
            phoneNumber = "<ENTER VALUE>"
        },
    },
    text = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Sms().Post(createSMSMessage);
// PROCESS RESPONSE
