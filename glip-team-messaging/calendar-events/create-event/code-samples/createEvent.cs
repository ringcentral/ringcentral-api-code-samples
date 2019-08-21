// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
GlipEventCreate glipEventCreate = new GlipEventCreate {
    id = "<ENTER VALUE>",
    creatorId = "<ENTER VALUE>",
    title = "<ENTER VALUE>",
    startTime = "<ENTER VALUE>",
    endTime = "<ENTER VALUE>",
    allDay = true,
    recurrence = 'None',
    endingCondition = "<ENTER VALUE>",
    endingAfter = 000,
    endingOn = 'None',
    color = 'Black',
    location = "<ENTER VALUE>",
    description = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Events().Post(glipEventCreate);
// PROCESS RESPONSE
