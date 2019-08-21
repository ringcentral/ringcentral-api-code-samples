// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
UpdateConferencingInfoRequest updateConferencingInfoRequest = new UpdateConferencingInfoRequest {
    phoneNumbers = new[] {
        new ConferencePhoneNumberInfo {
            phoneNumber = "<ENTER VALUE>",
            default = true
        },
    },
    allowJoinBeforeHost = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest);
// PROCESS RESPONSE
