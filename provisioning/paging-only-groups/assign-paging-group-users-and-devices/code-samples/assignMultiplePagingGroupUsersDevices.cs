// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pagingOnlyGroupId = "<ENTER VALUE>";

// POST BODY
EditPagingGroupRequest editPagingGroupRequest = new EditPagingGroupRequest {
    addedUserIds = new[] {
        "<ENTER VALUE>",
    },
    removedUserIds = new[] {
        "<ENTER VALUE>",
    },
    addedDeviceIds = new[] {
        "<ENTER VALUE>",
    },
    removedDeviceIds = new[] {
        "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest);
// PROCESS RESPONSE
