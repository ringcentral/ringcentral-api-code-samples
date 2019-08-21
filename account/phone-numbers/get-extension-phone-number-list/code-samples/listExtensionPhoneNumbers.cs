// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionPhoneNumbersParameters listExtensionPhoneNumbersParameters = new ListExtensionPhoneNumbersParameters {
    //usageType = new[] { "MainCompanyNumber", "AdditionalCompanyNumber", "CompanyNumber", "DirectNumber", "CompanyFaxNumber", "ForwardedNumber", "ForwardedCompanyNumber" },
    //page = 000,
    //perPage = 000
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters);
// PROCESS RESPONSE
