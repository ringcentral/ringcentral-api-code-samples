// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// POST BODY
GlipCreateTask glipCreateTask = new GlipCreateTask {
    subject = "<ENTER VALUE>",
    assignees = new[] {
        new  {
            id = "<ENTER VALUE>"
        },
    },
    completenessCondition = 'Simple',
    startDate = "<ENTER VALUE>",
    dueDate = "<ENTER VALUE>",
    color = 'Black',
    section = "<ENTER VALUE>",
    description = "<ENTER VALUE>",
    recurrence = new  {
        schedule = 'None',
        endingCondition = 'None',
        endingAfter = 000,
        endingOn = "<ENTER VALUE>"
    },
    attachments = new[] {
        new  {
            id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Chats(chatId).Tasks().Post(glipCreateTask);
// PROCESS RESPONSE
