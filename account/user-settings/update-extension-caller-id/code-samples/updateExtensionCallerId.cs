// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
ExtensionCallerIdInfo extensionCallerIdInfo = new ExtensionCallerIdInfo {
    uri = "<ENTER VALUE>",
    byDevice = new[] {
        new CallerIdByDevice {
            device = new CallerIdDeviceInfo {
                id = "<ENTER VALUE>",
                uri = "<ENTER VALUE>",
                phoneNumber = "<ENTER VALUE>"
            },
            callerId = new CallerIdByDeviceInfo {
                type = "<ENTER VALUE>",
                phoneInfo = new CallerIdPhoneInfo {
                    id = "<ENTER VALUE>",
                    uri = "<ENTER VALUE>",
                    phoneNumber = "<ENTER VALUE>"
                }
            }
        },
    },
    byFeature = new[] {
        new CallerIdByFeature {
            feature = 'RingOut',
            callerId = new CallerIdByFeatureInfo {
                type = "<ENTER VALUE>",
                phoneInfo = new CallerIdPhoneInfo {
                    id = "<ENTER VALUE>",
                    uri = "<ENTER VALUE>",
                    phoneNumber = "<ENTER VALUE>"
                }
            }
        },
    },
    extensionNameForOutboundCalls = true,
    extensionNumberForInternalCalls = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfo);
// PROCESS RESPONSE
