// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
ExtensionCreationRequest extensionCreationRequest = new ExtensionCreationRequest {
    contact = new ContactInfoCreationRequest {
        firstName = "<ENTER VALUE>",
        lastName = "<ENTER VALUE>",
        company = "<ENTER VALUE>",
        jobTitle = "<ENTER VALUE>",
        email = "<ENTER VALUE>",
        businessPhone = "<ENTER VALUE>",
        mobilePhone = "<ENTER VALUE>",
        businessAddress = new ContactBusinessAddressInfo {
            country = "<ENTER VALUE>",
            state = "<ENTER VALUE>",
            city = "<ENTER VALUE>",
            street = "<ENTER VALUE>",
            zip = "<ENTER VALUE>"
        },
        emailAsLoginName = true,
        pronouncedName = new PronouncedNameInfo {
            type = 'Default',
            text = "<ENTER VALUE>"
        },
        department = "<ENTER VALUE>"
    },
    extensionNumber = "<ENTER VALUE>",
    password = "<ENTER VALUE>",
    references = new[] {
        new ReferenceInfo {
            ref = "<ENTER VALUE>",
            type = 'PartnerId'
        },
    },
    roles = new[] {
        new Roles {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>"
        },
    },
    regionalSettings = new RegionalSettings {
        homeCountry = new CountryInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            isoCode = "<ENTER VALUE>",
            callingCode = "<ENTER VALUE>"
        },
        timezone = new TimezoneInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            description = "<ENTER VALUE>"
        },
        language = new LanguageInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            greeting = true,
            formattingLocale = true,
            localeCode = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            ui = true
        },
        greetingLanguage = new GreetingLanguageInfo {
            id = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>",
            name = "<ENTER VALUE>"
        },
        formattingLocale = new FormattingLocaleInfo {
            id = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>",
            name = "<ENTER VALUE>"
        },
        timeFormat = '12h'
    },
    setupWizardState = 'NotStarted',
    status = 'Enabled',
    statusInfo = new ExtensionStatusInfo {
        comment = "<ENTER VALUE>",
        reason = 'Voluntarily'
    },
    type = 'User',
    hidden = true
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
var r = await rc.Restapi().Account(accountId).Extension().Post(extensionCreationRequest);
// PROCESS RESPONSE
