// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

// POST BODY
ForwardTarget forwardTarget = new ForwardTarget {
    phoneNumber = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    voicemail = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().Post(forwardTarget);
// PROCESS RESPONSE
