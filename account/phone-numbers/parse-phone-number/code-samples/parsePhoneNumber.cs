// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ParsePhoneNumberParameters parsePhoneNumberParameters = new ParsePhoneNumberParameters {
    //homeCountry = "<ENTER VALUE>",
    //nationalAsPriority = true
};

// POST BODY
ParsePhoneNumberRequest parsePhoneNumberRequest = new ParsePhoneNumberRequest {
    originalStrings = new[] {
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
var r = await rc.Restapi().NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters);
// PROCESS RESPONSE
