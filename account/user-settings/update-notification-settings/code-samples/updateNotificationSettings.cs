// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
NotificationSettingsUpdateRequest notificationSettingsUpdateRequest = new NotificationSettingsUpdateRequest {
    emailAddresses = new[] {
        "<ENTER VALUE>",
    },
    smsEmailAddresses = new[] {
        "<ENTER VALUE>",
    },
    advancedMode = true,
    voicemails = new VoicemailsInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        includeAttachment = true,
        markAsRead = true
    },
    inboundFaxes = new InboundFaxesInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        includeAttachment = true,
        markAsRead = true
    },
    outboundFaxes = new OutboundFaxesInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        }
    },
    inboundTexts = new InboundTextsInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        }
    },
    missedCalls = new MissedCallsInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        }
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest);
// PROCESS RESPONSE
