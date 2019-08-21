// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CompanyBusinessHoursUpdateRequest companyBusinessHoursUpdateRequest = new CompanyBusinessHoursUpdateRequest {
    schedule = new CompanyBusinessHoursScheduleInfo {
        weeklyRanges = new WeeklyScheduleInfo {
            monday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            tuesday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            wednesday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            thursday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            friday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            saturday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            sunday = new[] {
                new TimeInterval {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            }
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
var r = await rc.Restapi().Account(accountId).BusinessHours().Put(companyBusinessHoursUpdateRequest);
// PROCESS RESPONSE
