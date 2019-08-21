// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string id = "<ENTER VALUE>";

// POST BODY
User user = new User {
    active = true,
    addresses = new[] {
        new UserAddress {
            country = "<ENTER VALUE>",
            locality = "<ENTER VALUE>",
            postalCode = "<ENTER VALUE>",
            region = "<ENTER VALUE>",
            streetAddress = "<ENTER VALUE>",
            type = 'work'
        },
    },
    emails = new[] {
        new Email {
            type = 'work',
            value = "<ENTER VALUE>"
        },
    },
    externalId = "<ENTER VALUE>",
    id = "<ENTER VALUE>",
    name = new Name {
        familyName = "<ENTER VALUE>",
        givenName = "<ENTER VALUE>"
    },
    phoneNumbers = new[] {
        new PhoneNumber {
            type = 'work',
            value = "<ENTER VALUE>"
        },
    },
    photos = new[] {
        new Photo {
            type = 'photo',
            value = "<ENTER VALUE>"
        },
    },
    schemas = new[] {
        'urn:ietf:params:scim:schemas:core:2.0:User',
    },
    urn:ietf:params:scim:schemas:extension:enterprise:2.0:User = new EnterpriseUser {
        department = "<ENTER VALUE>"
    },
    userName = "<ENTER VALUE>"
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
var r = await rc.Scim().Users(id).Put(user);
// PROCESS RESPONSE
