// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
IVRMenuInfo iVRMenuInfo = new IVRMenuInfo {
    id = "<ENTER VALUE>",
    uri = "<ENTER VALUE>",
    name = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    prompt = new IVRMenuPromptInfo {
        mode = 'Audio',
        audio = new PromptLanguageInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>"
        },
        text = "<ENTER VALUE>",
        language = new AudioPromptInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>"
        }
    },
    actions = new[] {
        new IVRMenuActionsInfo {
            input = "<ENTER VALUE>",
            action = 'Connect',
            extension = new IVRMenuExtensionInfo {
                uri = "<ENTER VALUE>",
                id = "<ENTER VALUE>"
            },
            phoneNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).IvrMenus().Post(iVRMenuInfo);
// PROCESS RESPONSE
