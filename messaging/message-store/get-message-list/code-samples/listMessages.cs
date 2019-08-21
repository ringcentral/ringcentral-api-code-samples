// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListMessagesParameters listMessagesParameters = new ListMessagesParameters {
    //availability = new[] { "Alive", "Deleted", "Purged" },
    //conversationId = 000,
    //dateFrom = "<ENTER VALUE>",
    //dateTo = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //distinctConversations = true,
    //messageType = new[] { "Fax", "SMS", "VoiceMail", "Pager", "Text" },
    //readStatus = new[] { "Read", "Unread" },
    //page = 1,
    //perPage = 100,
    //phoneNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters);
// PROCESS RESPONSE
