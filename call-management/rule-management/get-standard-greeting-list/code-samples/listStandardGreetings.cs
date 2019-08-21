// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListStandardGreetingsParameters listStandardGreetingsParameters = new ListStandardGreetingsParameters {
    //page = 1,
    //perPage = 100,
    //type = 'Introductory',
    //usageType = 'UserExtensionAnsweringRule'
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
var r = await rc.Restapi().Dictionary().Greeting().List(listStandardGreetingsParameters);
// PROCESS RESPONSE
