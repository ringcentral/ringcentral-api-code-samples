// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
CreateSubscriptionRequest createSubscriptionRequest = new CreateSubscriptionRequest {
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
var r = await rc.Restapi().Subscription().Post(createSubscriptionRequest);
// PROCESS RESPONSE
