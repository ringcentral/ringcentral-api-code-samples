// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
CheckUserPermissionParameters checkUserPermissionParameters = new CheckUserPermissionParameters {
    //permissionId = "<ENTER VALUE>",
    //targetExtensionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters);
// PROCESS RESPONSE
