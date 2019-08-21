// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListLocationsParameters listLocationsParameters = new ListLocationsParameters {
    //orderBy = 'City',
    //page = 1,
    //perPage = 100,
    //stateId = "<ENTER VALUE>",
    //withNxx = true
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
var r = await rc.Restapi().Dictionary().Location().Get(listLocationsParameters);
// PROCESS RESPONSE
