// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
CreateContactParameters createContactParameters = new CreateContactParameters {
    //dialingPlan = "<ENTER VALUE>"
};

// POST BODY
PersonalContactRequest personalContactRequest = new PersonalContactRequest {
    firstName = "<ENTER VALUE>",
    lastName = "<ENTER VALUE>",
    middleName = "<ENTER VALUE>",
    nickName = "<ENTER VALUE>",
    company = "<ENTER VALUE>",
    jobTitle = "<ENTER VALUE>",
    email = "<ENTER VALUE>",
    email2 = "<ENTER VALUE>",
    email3 = "<ENTER VALUE>",
    birthday = "<ENTER VALUE>",
    webPage = "<ENTER VALUE>",
    notes = "<ENTER VALUE>",
    homePhone = "<ENTER VALUE>",
    homePhone2 = "<ENTER VALUE>",
    businessPhone = "<ENTER VALUE>",
    businessPhone2 = "<ENTER VALUE>",
    mobilePhone = "<ENTER VALUE>",
    businessFax = "<ENTER VALUE>",
    companyPhone = "<ENTER VALUE>",
    assistantPhone = "<ENTER VALUE>",
    carPhone = "<ENTER VALUE>",
    otherPhone = "<ENTER VALUE>",
    otherFax = "<ENTER VALUE>",
    callbackPhone = "<ENTER VALUE>",
    homeAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
    },
    businessAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
    },
    otherAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactRequest, createContactParameters);
// PROCESS RESPONSE
