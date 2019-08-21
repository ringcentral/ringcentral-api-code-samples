// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListCountriesParameters listCountriesParameters = new ListCountriesParameters {
    //loginAllowed = true,
    //signupAllowed = true,
    //numberSelling = true,
    //page = 1,
    //perPage = 100,
    //freeSoftphoneLine = true
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
var r = await rc.Restapi().Dictionary().Country().List(listCountriesParameters);
// PROCESS RESPONSE
