// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string subscriptionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
UpdateSubscriptionParameters updateSubscriptionParameters = new UpdateSubscriptionParameters {
    //aggregated = true
};

// POST BODY
ModifySubscriptionRequest modifySubscriptionRequest = new ModifySubscriptionRequest {
    eventFilters = new[] {
        "<ENTER VALUE>",
    },
    deliveryMode = new NotificationDeliveryModeRequest {
        transportType = 'PubNub',
        address = "<ENTER VALUE>",
        encryption = true,
        certificateName = "<ENTER VALUE>",
        registrationId = "<ENTER VALUE>",
        verificationToken = "<ENTER VALUE>"
    },
    expiresIn = 604800
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
var r = await rc.Restapi().Subscription(subscriptionId).Put(modifySubscriptionRequest, updateSubscriptionParameters);
// PROCESS RESPONSE
