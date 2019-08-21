// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// POST BODY
PresenceInfoResource presenceInfoResource = new PresenceInfoResource {
    userStatus = 'Offline',
    dndStatus = 'TakeAllCalls',
    message = "<ENTER VALUE>",
    allowSeeMyPresence = true,
    ringOnMonitoredCall = true,
    pickUpCallsOnHold = true,
    activeCalls = new[] {
        new ActiveCallInfo {
            id = "<ENTER VALUE>",
            direction = 'Inbound',
            from = "<ENTER VALUE>",
            fromName = "<ENTER VALUE>",
            to = "<ENTER VALUE>",
            toName = "<ENTER VALUE>",
            startTime = "<ENTER VALUE>",
            telephonyStatus = "<ENTER VALUE>",
            sipData = new DetailedCallInfo {
                callId = "<ENTER VALUE>",
                toTag = "<ENTER VALUE>",
                fromTag = "<ENTER VALUE>",
                remoteUri = "<ENTER VALUE>",
                localUri = "<ENTER VALUE>",
                rcSessionId = "<ENTER VALUE>"
            },
            sessionId = "<ENTER VALUE>",
            terminationType = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Presence().Put(presenceInfoResource);
// PROCESS RESPONSE
