// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
ExtensionUpdateRequest extensionUpdateRequest = new ExtensionUpdateRequest {
    status = 'Disabled',
    statusInfo = new ExtensionStatusInfo {
        comment = "<ENTER VALUE>",
        reason = 'Voluntarily'
    },
    reason = "<ENTER VALUE>",
    comment = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    contact = new ContactInfoUpdateRequest {
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
    regionalSettings = new ExtensionRegionalSettingRequest {
        homeCountry = new ExtensionCountryInfoRequest {
            id = "<ENTER VALUE>"
        },
        timezone = new ExtensionTimezoneInfoRequest {
            id = "<ENTER VALUE>"
        },
        language = new ExtensionLanguageInfoRequest {
            id = "<ENTER VALUE>"
        },
        greetingLanguage = new ExtensionGreetingLanguageInfoRequest {
            id = "<ENTER VALUE>"
        },
        formattingLocale = new ExtensionFormattingLocaleInfoRequest {
            id = "<ENTER VALUE>"
        },
        timeFormat = '12h'
    },
    setupWizardState = 'NotStarted',
    partnerId = "<ENTER VALUE>",
    ivrPin = "<ENTER VALUE>",
    password = "<ENTER VALUE>",
    callQueueInfo = new CallQueueInfoRequest {
        slaGoal = 000,
        slaThresholdSeconds = 000,
        includeAbandonedCalls = true,
        abandonedThresholdSeconds = 000
    },
    transition = new[] {
        new UserTransitionInfo {
            sendWelcomeEmailsToUsers = true,
            sendWelcomeEmail = true
        },
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Put(extensionUpdateRequest);
// PROCESS RESPONSE
