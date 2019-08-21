// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string blockedNumberId = "<ENTER VALUE>";

// POST BODY
AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber = new AddBlockedAllowedPhoneNumber {
    phoneNumber = "<ENTER VALUE>",
    label = "<ENTER VALUE>",
    status = 'Blocked'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber);
// PROCESS RESPONSE
