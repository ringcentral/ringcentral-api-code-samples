// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string meetingId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// POST BODY
MeetingRequestResource meetingRequestResource = new MeetingRequestResource {
    topic = "<ENTER VALUE>",
    meetingType = 'Scheduled',
    schedule = new MeetingScheduleResource {
        startTime = "<ENTER VALUE>",
        durationInMinutes = 000,
        timeZone = new TimezoneResource {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            description = "<ENTER VALUE>"
        }
    },
    password = "<ENTER VALUE>",
    host = new HostInfoRequest {
        id = "<ENTER VALUE>"
    },
    allowJoinBeforeHost = true,
    startHostVideo = true,
    startParticipantsVideo = true,
    usePersonalMeetingId = true,
    audioOptions = new[] {
        "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting(meetingId).Put(meetingRequestResource);
// PROCESS RESPONSE
