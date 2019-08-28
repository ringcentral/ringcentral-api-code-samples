// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListChatTasksParameters listChatTasksParameters = new ListChatTasksParameters {
    //creationTimeTo = 'now',
    //creationTimeFrom = "<ENTER VALUE>",
    //creatorId = new[] { string },
    //status = new[] { "Pending", "InProgress", "Completed" },
    //assignmentStatus = 'Unassigned',
    //assigneeId = new[] { string },
    //assigneeStatus = 'Pending',
    //pageToken = "<ENTER VALUE>",
    //recordCount = 30
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
var r = await rc.Restapi().Glip().Chats(chatId).Tasks().Get(listChatTasksParameters);
// PROCESS RESPONSE
