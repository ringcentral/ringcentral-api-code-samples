// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListContactsParameters listContactsParameters = new ListContactsParameters {
    //startsWith = "<ENTER VALUE>",
    //sortBy = new[] { "FirstName", "LastName", "Company" },
    //page = 1,
    //perPage = 100,
    //phoneNumber = new[] { string }
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters);
// PROCESS RESPONSE
