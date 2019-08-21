// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
MakeRingOutRequest makeRingOutRequest = new MakeRingOutRequest {
    from = new MakeRingOutCallerInfoRequestFrom {
        phoneNumber = "<ENTER VALUE>",
        forwardingNumberId = "<ENTER VALUE>"
    },
    to = new MakeRingOutCallerInfoRequestTo {
        phoneNumber = "<ENTER VALUE>"
    },
    callerId = new MakeRingOutCallerInfoRequestTo {
        phoneNumber = "<ENTER VALUE>"
    },
    playPrompt = true,
    country = new MakeRingOutCoutryInfo {
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest);
// PROCESS RESPONSE
