// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionsParameters listExtensionsParameters = new ListExtensionsParameters {
    //extensionNumber = "<ENTER VALUE>",
    //email = "<ENTER VALUE>",
    //page = 1,
    //perPage = 100,
    //status = new[] { "Enabled", "Disabled", "NotActivated", "Unassigned" },
    //type = new[] { "User", "FaxUser", "VirtualUser", "DigitalUser", "Department", "Announcement", "Voicemail", "SharedLinesGroup", "PagingOnly", "IvrMenu", "ApplicationExtension", "ParkLocation", "Limited", "Bot" }
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
var r = await rc.Restapi().Account(accountId).Extension().List(listExtensionsParameters);
// PROCESS RESPONSE
