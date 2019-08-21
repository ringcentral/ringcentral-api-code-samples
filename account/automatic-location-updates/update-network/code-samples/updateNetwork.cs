// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string networkId = "<ENTER VALUE>";

// POST BODY
UpdateNetworkRequest updateNetworkRequest = new UpdateNetworkRequest {
    name = "<ENTER VALUE>",
    site = new AutomaticLocationUpdatesSiteInfo {
        id = "<ENTER VALUE>",
        name = "<ENTER VALUE>"
    },
    publicIpRanges = new[] {
        new PublicIpRangeInfo {
            id = "<ENTER VALUE>",
            startIp = "<ENTER VALUE>",
            endIp = "<ENTER VALUE>"
        },
    },
    privateIpRanges = new[] {
        new PrivateIpRangeInfo {
            id = "<ENTER VALUE>",
            startIp = "<ENTER VALUE>",
            endIp = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Put(updateNetworkRequest);
// PROCESS RESPONSE
