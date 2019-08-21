// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListStatesParameters listStatesParameters = new ListStatesParameters {
    //allCountries = true,
    //countryId = 000,
    //page = 1,
    //perPage = 100,
    //withPhoneNumbers = true
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
var r = await rc.Restapi().Dictionary().State().List(listStatesParameters);
// PROCESS RESPONSE
