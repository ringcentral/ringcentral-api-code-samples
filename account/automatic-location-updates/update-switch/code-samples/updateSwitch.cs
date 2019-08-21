// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string switchId = "<ENTER VALUE>";

// POST BODY
UpdateSwitchInfo updateSwitchInfo = new UpdateSwitchInfo {
    id = "<ENTER VALUE>",
    chassisId = "<ENTER VALUE>",
    name = "<ENTER VALUE>",
    site = new SwitchSiteInfo {
        id = "<ENTER VALUE>",
        name = "<ENTER VALUE>"
    },
    emergencyAddress = new LocationUpdatesEmergencyAddressInfo {
        country = "<ENTER VALUE>",
        countryId = "<ENTER VALUE>",
        countryIsoCode = "<ENTER VALUE>",
        countryName = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        stateId = "<ENTER VALUE>",
        stateIsoCode = "<ENTER VALUE>",
        stateName = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        street = "<ENTER VALUE>",
        street2 = "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Put(updateSwitchInfo);
// PROCESS RESPONSE
