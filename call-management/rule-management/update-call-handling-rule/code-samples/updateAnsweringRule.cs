// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string ruleId = "<ENTER VALUE>";

// POST BODY
UpdateAnsweringRuleRequest updateAnsweringRuleRequest = new UpdateAnsweringRuleRequest {
    forwarding = new ForwardingInfoCreateRuleRequest {
        notifyMySoftPhones = true,
        notifyAdminSoftPhones = true,
        softPhonesRingCount = 1,
        ringingMode = 'Sequentially',
        rules = new[] {
            new RuleInfoCreateRuleRequest {
                index = 000,
                ringCount = 000,
                enabled = true,
                forwardingNumbers = new[] {
                    new ForwardingNumberInfoRulesCreateRuleRequest {
                        id = "<ENTER VALUE>",
                        type = 'Home'
                    },
                }
            },
        },
        mobileTimeout = true
    },
    enabled = true,
    name = "<ENTER VALUE>",
    callers = new[] {
        new CallersInfoRequest {
            callerId = "<ENTER VALUE>",
            name = "<ENTER VALUE>"
        },
    },
    calledNumbers = new[] {
        new CalledNumberInfo {
            phoneNumber = "<ENTER VALUE>"
        },
    },
    schedule = new ScheduleInfo {
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
        },
        ranges = new[] {
            new RangesInfo {
                from = "<ENTER VALUE>",
                to = "<ENTER VALUE>"
            },
        },
        ref = 'BusinessHours'
    },
    callHandlingAction = 'ForwardCalls',
    unconditionalForwarding = new UnconditionalForwardingInfo {
        phoneNumber = "<ENTER VALUE>"
    },
    queue = new QueueInfo {
        transferMode = 'Rotating',
        fixedOrderAgents = new[] {
            new FixedOrderAgents {
                extension = new ExtensionInfo {
                    id = "<ENTER VALUE>",
                    uri = "<ENTER VALUE>",
                    extensionNumber = "<ENTER VALUE>",
                    partnerId = "<ENTER VALUE>"
                },
                index = 000
            },
        },
        holdAudioInterruptionMode = 'Never',
        holdAudioInterruptionPeriod = 000,
        agentTimeout = 000,
        wrapUpTime = 000,
        holdTime = 000,
        maxCallers = 000,
        maxCallersAction = 'Voicemail'
    },
    voicemail = new VoicemailInfo {
        enabled = true,
        recipient = new RecipientInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>"
        }
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
    },
    screening = 'Off',
    showInactiveNumbers = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Put(updateAnsweringRuleRequest);
// PROCESS RESPONSE
