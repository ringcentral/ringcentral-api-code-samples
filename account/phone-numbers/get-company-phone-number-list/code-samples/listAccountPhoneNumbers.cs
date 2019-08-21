// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListAccountPhoneNumbersParameters listAccountPhoneNumbersParameters = new ListAccountPhoneNumbersParameters {
    //page = 1,
    //perPage = 100,
    //usageType = new[] { "MainCompanyNumber", "AdditionalCompanyNumber", "CompanyNumber", "DirectNumber", "CompanyFaxNumber", "ForwardedNumber", "ForwardedCompanyNumber", "ContactCenterNumber", "ConferencingNumber", "MeetingsNumber" }
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
var r = await rc.Restapi().Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters);
// PROCESS RESPONSE
