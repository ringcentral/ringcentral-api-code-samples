// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string deviceId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// POST BODY
AccountDeviceUpdate accountDeviceUpdate = new AccountDeviceUpdate {
    emergencyServiceAddress = new EmergencyServiceAddressResourceRequest {
        street = "<ENTER VALUE>",
        street2 = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        zip = "<ENTER VALUE>",
        customerName = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        stateId = "<ENTER VALUE>",
        stateIsoCode = "<ENTER VALUE>",
        stateName = "<ENTER VALUE>",
        countryId = "<ENTER VALUE>",
        countryIsoCode = "<ENTER VALUE>",
        country = "<ENTER VALUE>",
        countryName = "<ENTER VALUE>"
    },
    extension = new DeviceUpdateExtensionInfo {
        id = "<ENTER VALUE>"
    },
    phoneLines = new DeviceUpdatePhoneLinesInfo {
        phoneLines = new[] {
            new UpdateDevicePhoneInfo {
                id = "<ENTER VALUE>"
            },
        }
    },
    useAsCommonPhone = true
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
var r = await rc.Restapi().Account(accountId).Device(deviceId).Put(accountDeviceUpdate);
// PROCESS RESPONSE
