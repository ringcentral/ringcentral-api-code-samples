// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
MakeCallOutRequest makeCallOutRequest = new MakeCallOutRequest {
    from = new MakeCallOutCallerInfoRequestFrom {
        deviceId = "<ENTER VALUE>"
    },
    to = new MakeCallOutCallerInfoRequestTo {
        phoneNumber = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().CallOut().Post(makeCallOutRequest);
// PROCESS RESPONSE
