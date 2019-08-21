// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string ruleId = "<ENTER VALUE>";

// POST BODY
CompanyAnsweringRuleUpdate companyAnsweringRuleUpdate = new CompanyAnsweringRuleUpdate {
    enabled = true,
    name = "<ENTER VALUE>",
    callers = new[] {
        new CompanyAnsweringRuleCallersInfoRequest {
            callerId = "<ENTER VALUE>",
            name = "<ENTER VALUE>"
        },
    },
    calledNumbers = new[] {
        new CompanyAnsweringRuleCalledNumberInfo {
            id = "<ENTER VALUE>"
        },
    },
    schedule = new CompanyAnsweringRuleScheduleInfoRequest {
        weeklyRanges = new CompanyAnsweringRuleWeeklyScheduleInfoRequest {
            monday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            tuesday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            wednesday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            thursday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            friday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            saturday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            },
            sunday = new[] {
                new CompanyAnsweringRuleTimeIntervalRequest {
                    from = "<ENTER VALUE>",
                    to = "<ENTER VALUE>"
                },
            }
        },
        ranges = new[] {
            new RangesInfo {
                from = "<ENTER VALUE>",
                to = "<ENTER VALUE>"
            },
        },
        ref = 'BusinessHours'
    },
    callHandlingAction = 'Operator',
    extension = new CompanyAnsweringRuleCallersInfoRequest {
        callerId = "<ENTER VALUE>",
        name = "<ENTER VALUE>"
    },
    greetings = new[] {
        new GreetingInfo {
            type = 'Introductory',
            usageType = 'UserExtensionAnsweringRule',
            preset = new PresetInfo {
                uri = "<ENTER VALUE>",
                id = "<ENTER VALUE>",
                name = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).AnsweringRule(ruleId).Put(companyAnsweringRuleUpdate);
// PROCESS RESPONSE
