// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
GlipPostTeamBody glipPostTeamBody = new GlipPostTeamBody {
    public = true,
    name = "<ENTER VALUE>",
    description = "<ENTER VALUE>",
    members = new[] {
        new  {
            id = "<ENTER VALUE>",
            email = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Teams().Post(glipPostTeamBody);
// PROCESS RESPONSE
