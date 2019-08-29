# RingCentral Node JS SDK Code Samples



## Get API Versions

HTTP get `/restapi`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/API-Info/readAPIVersions) in API Explorer.

## Get Version Info

HTTP get `/restapi/{apiVersion}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string apiVersion = "<ENTER VALUE>";

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
var r = await rc.Restapi(apiVersion).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/API-Info/readAPIVersion) in API Explorer.

## Get Service Status

HTTP get `/restapi/v1.0/status`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().Status().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/API-Info/readAPIStatus) in API Explorer.

## Get User Call Log Records

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadUserCallLogParameters readUserCallLogParameters = new ReadUserCallLogParameters {
    //extensionNumber = "<ENTER VALUE>",
    //showBlocked = true,
    //phoneNumber = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //sessionId = "<ENTER VALUE>",
    //type = new[] { "Voice", "Fax" },
    //transport = new[] { "PSTN", "VoIP" },
    //view = 'Simple',
    //withRecording = true,
    //recordingType = 'Automatic',
    //dateTo = "<ENTER VALUE>",
    //dateFrom = "<ENTER VALUE>",
    //page = 1,
    //perPage = 100,
    //showDeleted = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLog().List(readUserCallLogParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/readUserCallLog) in API Explorer.

## Delete User Call Log

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
DeleteUserCallLogParameters deleteUserCallLogParameters = new DeleteUserCallLogParameters {
    //dateTo = "<ENTER VALUE>",
    //phoneNumber = "<ENTER VALUE>",
    //extensionNumber = "<ENTER VALUE>",
    //type = new[] { "Voice", "Fax" },
    //direction = new[] { "Inbound", "Outbound" },
    //dateFrom = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLog().Delete(deleteUserCallLogParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/deleteUserCallLog) in API Explorer.

## Sync User Call Log

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log-sync`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncUserCallLogParameters syncUserCallLogParameters = new SyncUserCallLogParameters {
    //syncType = new[] { "FSync", "ISync" },
    //syncToken = "<ENTER VALUE>",
    //dateFrom = "<ENTER VALUE>",
    //recordCount = 000,
    //statusGroup = new[] { "Missed", "All" },
    //view = 'Simple',
    //showDeleted = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLogSync().Get(syncUserCallLogParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/syncUserCallLog) in API Explorer.

## Get User Call Record

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/call-log/{callRecordId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string callRecordId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadUserCallRecordParameters readUserCallRecordParameters = new ReadUserCallRecordParameters {
    //view = 'Simple'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallLog(callRecordId).Get(readUserCallRecordParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/readUserCallRecord) in API Explorer.

## Get User Active Calls

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/active-calls`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionActiveCallsParameters listExtensionActiveCallsParameters = new ListExtensionActiveCallsParameters {
    //direction = new[] { "Inbound", "Outbound" },
    //view = 'Simple',
    //type = new[] { "Voice", "Fax" },
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ActiveCalls().Get(listExtensionActiveCallsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/listExtensionActiveCalls) in API Explorer.

## Get Company Call Log Records

HTTP get `/restapi/v1.0/account/{accountId}/call-log`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadCompanyCallLogParameters readCompanyCallLogParameters = new ReadCompanyCallLogParameters {
    //extensionNumber = "<ENTER VALUE>",
    //phoneNumber = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //type = new[] { "Voice", "Fax" },
    //view = 'Simple',
    //withRecording = true,
    //recordingType = 'Automatic',
    //dateFrom = "<ENTER VALUE>",
    //dateTo = "<ENTER VALUE>",
    //page = 1,
    //perPage = 100,
    //sessionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallLog().List(readCompanyCallLogParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/readCompanyCallLog) in API Explorer.

## Sync Company Call Log

HTTP get `/restapi/v1.0/account/{accountId}/call-log-sync`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncAccountCallLogParameters syncAccountCallLogParameters = new SyncAccountCallLogParameters {
    //syncType = 'FSync',
    //syncToken = "<ENTER VALUE>",
    //dateFrom = "<ENTER VALUE>",
    //recordCount = 000,
    //statusGroup = 'Missed',
    //view = 'Simple',
    //showDeleted = true
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
var r = await rc.Restapi().Account(accountId).CallLogSync().Get(syncAccountCallLogParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/syncAccountCallLog) in API Explorer.

## Get Company Call Log Record(s)

HTTP get `/restapi/v1.0/account/{accountId}/call-log/{callRecordId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string callRecordId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).CallLog(callRecordId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/readCompanyCallRecord) in API Explorer.

## Get Company Active Calls

HTTP get `/restapi/v1.0/account/{accountId}/active-calls`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCompanyActiveCallsParameters listCompanyActiveCallsParameters = new ListCompanyActiveCallsParameters {
    //direction = new[] { "Inbound", "Outbound" },
    //view = 'Simple',
    //type = new[] { "Voice", "Fax" },
    //transport = new[] { "PSTN", "VoIP" },
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).ActiveCalls().Get(listCompanyActiveCallsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Log/listCompanyActiveCalls) in API Explorer.

## Get Call Recording

HTTP get `/restapi/v1.0/account/{accountId}/recording/{recordingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string recordingId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Recording(recordingId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Recordings/readCallRecording) in API Explorer.

## Get Call Recordings Data

HTTP get `/restapi/v1.0/account/{accountId}/recording/{recordingId}/content`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string recordingId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Recording(recordingId).Content().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Recordings/listCallRecordingData) in API Explorer.

## Send SMS

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/sms`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CreateSMSMessage createSMSMessage = new CreateSMSMessage {
    from = new MessageStoreCallerInfoRequest {
        phoneNumber = "<ENTER VALUE>"
    },
    to = new[] {
        new MessageStoreCallerInfoRequest {
            phoneNumber = "<ENTER VALUE>"
        },
    },
    text = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Sms().Post(createSMSMessage);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SMS/createSMSMessage) in API Explorer.

## Create Internal Text Message

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CreateInternalTextMessageRequest createInternalTextMessageRequest = new CreateInternalTextMessageRequest {
    from = new PagerCallerInfoRequest {
        extensionId = "<ENTER VALUE>"
    },
    replyOn = 000,
    text = "<ENTER VALUE>",
    to = new[] {
        new PagerCallerInfoRequest {
            extensionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CompanyPager().Post(createInternalTextMessageRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Pager-Messages/createInternalTextMessage) in API Explorer.

## Create Fax Message

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/fax`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Fax().Post(formData);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Fax/createFaxMessage) in API Explorer.

## Get Fax Cover Page List

HTTP get `/restapi/v1.0/dictionary/fax-cover-page`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListFaxCoverPagesParameters listFaxCoverPagesParameters = new ListFaxCoverPagesParameters {
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Dictionary().FaxCoverPage().Get(listFaxCoverPagesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Fax/listFaxCoverPages) in API Explorer.

## Get Message List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListMessagesParameters listMessagesParameters = new ListMessagesParameters {
    //availability = new[] { "Alive", "Deleted", "Purged" },
    //conversationId = 000,
    //dateFrom = "<ENTER VALUE>",
    //dateTo = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //distinctConversations = true,
    //messageType = new[] { "Fax", "SMS", "VoiceMail", "Pager", "Text" },
    //readStatus = new[] { "Read", "Unread" },
    //page = 1,
    //perPage = 100,
    //phoneNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore().List(listMessagesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/listMessages) in API Explorer.

## Delete Conversation

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
DeleteMessageByFilterParameters deleteMessageByFilterParameters = new DeleteMessageByFilterParameters {
    //conversationId = new[] { string },
    //dateTo = "<ENTER VALUE>",
    //type = 'All'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore().Delete(deleteMessageByFilterParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/deleteMessageByFilter) in API Explorer.

## Get Message

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string messageId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore(messageId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/readMessage) in API Explorer.

## Update Message(s)

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string messageId = "<ENTER VALUE>";

// POST BODY
UpdateMessageRequest updateMessageRequest = new UpdateMessageRequest {
    readStatus = 'Read'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore(messageId).Put(updateMessageRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/updateMessage) in API Explorer.

## Delete Message

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string messageId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
DeleteMessageParameters deleteMessageParameters = new DeleteMessageParameters {
    //purge = true,
    //conversationId = 000
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore(messageId).Delete(deleteMessageParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/deleteMessage) in API Explorer.

## Get Message Content

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-store/{messageId}/content/{attachmentId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string attachmentId = "<ENTER VALUE>";
string messageId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadMessageContentParameters readMessageContentParameters = new ReadMessageContentParameters {
    //contentDisposition = 'Inline'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageStore(messageId).Content(attachmentId).Get(readMessageContentParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/readMessageContent) in API Explorer.

## Sync Messages

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/message-sync`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncMessagesParameters syncMessagesParameters = new SyncMessagesParameters {
    //conversationId = 000,
    //dateFrom = "<ENTER VALUE>",
    //dateTo = "<ENTER VALUE>",
    //direction = new[] { "Inbound", "Outbound" },
    //distinctConversations = true,
    //messageType = new[] { "Fax", "SMS", "VoiceMail", "Pager", "Text" },
    //recordCount = 000,
    //syncToken = "<ENTER VALUE>",
    //syncType = new[] { "FSync", "ISync" }
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MessageSync().Get(syncMessagesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/syncMessages) in API Explorer.

## Get Message Store Configuration

HTTP get `/restapi/v1.0/account/{accountId}/message-store-configuration`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).MessageStoreConfiguration().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/readMessageStoreConfiguration) in API Explorer.

## Update Message Store Configuration

HTTP put `/restapi/v1.0/account/{accountId}/message-store-configuration`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
MessageStoreConfiguration messageStoreConfiguration = new MessageStoreConfiguration {
    retentionPeriod = 000
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
var r = await rc.Restapi().Account(accountId).MessageStoreConfiguration().Put(messageStoreConfiguration);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Store/updateMessageStoreConfiguration) in API Explorer.

## Make RingOut Call

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
MakeRingOutRequest makeRingOutRequest = new MakeRingOutRequest {
    from = new MakeRingOutCallerInfoRequestFrom {
        phoneNumber = "<ENTER VALUE>",
        forwardingNumberId = "<ENTER VALUE>"
    },
    to = new MakeRingOutCallerInfoRequestTo {
        phoneNumber = "<ENTER VALUE>"
    },
    callerId = new MakeRingOutCallerInfoRequestTo {
        phoneNumber = "<ENTER VALUE>"
    },
    playPrompt = true,
    country = new MakeRingOutCoutryInfo {
        id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).RingOut().Post(makeRingOutRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/RingOut/createRingOutCall) in API Explorer.

## Get RingOut Call Status

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string ringoutId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).RingOut(ringoutId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/RingOut/readRingOutCallStatus) in API Explorer.

## Cancel RingOut Call

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/ring-out/{ringoutId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string ringoutId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).RingOut(ringoutId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/RingOut/deleteRingOutCall) in API Explorer.

## Get Contact List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListContactsParameters listContactsParameters = new ListContactsParameters {
    //startsWith = "<ENTER VALUE>",
    //sortBy = new[] { "FirstName", "LastName", "Company" },
    //page = 1,
    //perPage = 100,
    //phoneNumber = new[] { string }
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact().List(listContactsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/listContacts) in API Explorer.

## Create Contact

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
CreateContactParameters createContactParameters = new CreateContactParameters {
    //dialingPlan = "<ENTER VALUE>"
};

// POST BODY
PersonalContactRequest personalContactRequest = new PersonalContactRequest {
    firstName = "<ENTER VALUE>",
    lastName = "<ENTER VALUE>",
    middleName = "<ENTER VALUE>",
    nickName = "<ENTER VALUE>",
    company = "<ENTER VALUE>",
    jobTitle = "<ENTER VALUE>",
    email = "<ENTER VALUE>",
    email2 = "<ENTER VALUE>",
    email3 = "<ENTER VALUE>",
    birthday = "<ENTER VALUE>",
    webPage = "<ENTER VALUE>",
    notes = "<ENTER VALUE>",
    homePhone = "<ENTER VALUE>",
    homePhone2 = "<ENTER VALUE>",
    businessPhone = "<ENTER VALUE>",
    businessPhone2 = "<ENTER VALUE>",
    mobilePhone = "<ENTER VALUE>",
    businessFax = "<ENTER VALUE>",
    companyPhone = "<ENTER VALUE>",
    assistantPhone = "<ENTER VALUE>",
    carPhone = "<ENTER VALUE>",
    otherPhone = "<ENTER VALUE>",
    otherFax = "<ENTER VALUE>",
    callbackPhone = "<ENTER VALUE>",
    homeAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
    },
    businessAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
    },
    otherAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact().Post(personalContactRequest, createContactParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/createContact) in API Explorer.

## Get Contact

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string contactId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/readContact) in API Explorer.

## Update Contact

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string contactId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
UpdateContactParameters updateContactParameters = new UpdateContactParameters {
    //dialingPlan = "<ENTER VALUE>"
};

// POST BODY
PersonalContactRequest personalContactRequest = new PersonalContactRequest {
    firstName = "<ENTER VALUE>",
    lastName = "<ENTER VALUE>",
    middleName = "<ENTER VALUE>",
    nickName = "<ENTER VALUE>",
    company = "<ENTER VALUE>",
    jobTitle = "<ENTER VALUE>",
    email = "<ENTER VALUE>",
    email2 = "<ENTER VALUE>",
    email3 = "<ENTER VALUE>",
    birthday = "<ENTER VALUE>",
    webPage = "<ENTER VALUE>",
    notes = "<ENTER VALUE>",
    homePhone = "<ENTER VALUE>",
    homePhone2 = "<ENTER VALUE>",
    businessPhone = "<ENTER VALUE>",
    businessPhone2 = "<ENTER VALUE>",
    mobilePhone = "<ENTER VALUE>",
    businessFax = "<ENTER VALUE>",
    companyPhone = "<ENTER VALUE>",
    assistantPhone = "<ENTER VALUE>",
    carPhone = "<ENTER VALUE>",
    otherPhone = "<ENTER VALUE>",
    otherFax = "<ENTER VALUE>",
    callbackPhone = "<ENTER VALUE>",
    homeAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
    },
    businessAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        zip = "<ENTER VALUE>"
    },
    otherAddress = new ContactAddressInfo {
        street = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Put(personalContactRequest, updateContactParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/updateContact) in API Explorer.

## Delete Contact

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book/contact/{contactId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string contactId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBook().Contact(contactId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/deleteContact) in API Explorer.

## Address Book Synchronization

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/address-book-sync`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
SyncAddressBookParameters syncAddressBookParameters = new SyncAddressBookParameters {
    //syncType = new[] { "FSync", "ISync" },
    //syncToken = "<ENTER VALUE>",
    //perPage = 000,
    //pageId = 000
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AddressBookSync().Get(syncAddressBookParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/syncAddressBook) in API Explorer.

## Get Favorite Contact List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Favorite().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/listFavoriteContacts) in API Explorer.

## Update Favorite Contact List

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/favorite`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
FavoriteCollection favoriteCollection = new FavoriteCollection {
    records = new[] {
        new FavoriteContactResource {
            id = "<ENTER VALUE>",
            extensionId = "<ENTER VALUE>",
            contactId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Favorite().Put(favoriteCollection);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/External-Contacts/updateFavoriteContactList) in API Explorer.

## Search Company Directory Entries

HTTP post `/restapi/v1.0/account/{accountId}/directory/entries/search`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
SearchDirectoryEntriesRequest searchDirectoryEntriesRequest = new SearchDirectoryEntriesRequest {
    searchString = "<ENTER VALUE>",
    showFederated = true,
    extensionType = 'User',
    orderBy = new[] {
        new OrderBy {
            index = 000,
            fieldName = 'firstName',
            direction = 'Asc'
        },
    },
    page = 000,
    perPage = 000
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
var r = await rc.Restapi().Account(accountId).Directory().Entries().Search().Post(searchDirectoryEntriesRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Internal-Contacts/searchDirectoryEntries) in API Explorer.

## Get Corporate Directory Entry

HTTP get `/restapi/v1.0/account/{accountId}/directory/entries/{entryId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string entryId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Directory().Entries(entryId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Internal-Contacts/readDirectoryEntry) in API Explorer.

## Get Company Directory Entries

HTTP get `/restapi/v1.0/account/{accountId}/directory/entries`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListDirectoryEntriesParameters listDirectoryEntriesParameters = new ListDirectoryEntriesParameters {
    //showFederated = true,
    //type = 'User',
    //page = '1',
    //perPage = 1000,
    //siteId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Directory().Entries().List(listDirectoryEntriesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Internal-Contacts/listDirectoryEntries) in API Explorer.

## Get Account Federation

HTTP get `/restapi/v1.0/account/{accountId}/directory/federation`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Directory().Federation().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Internal-Contacts/readAccountFederation) in API Explorer.

## Get User Presence Status

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadUserPresenceStatusParameters readUserPresenceStatusParameters = new ReadUserPresenceStatusParameters {
    //detailedTelephonyState = true,
    //sipData = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Presence().Get(readUserPresenceStatusParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Presence/readUserPresenceStatus) in API Explorer.

## Update User Presence Status

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/presence`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// POST BODY
PresenceInfoResource presenceInfoResource = new PresenceInfoResource {
    userStatus = 'Offline',
    dndStatus = 'TakeAllCalls',
    message = "<ENTER VALUE>",
    allowSeeMyPresence = true,
    ringOnMonitoredCall = true,
    pickUpCallsOnHold = true,
    activeCalls = new[] {
        new ActiveCallInfo {
            id = "<ENTER VALUE>",
            direction = 'Inbound',
            from = "<ENTER VALUE>",
            fromName = "<ENTER VALUE>",
            to = "<ENTER VALUE>",
            toName = "<ENTER VALUE>",
            startTime = "<ENTER VALUE>",
            telephonyStatus = "<ENTER VALUE>",
            sipData = new DetailedCallInfo {
                callId = "<ENTER VALUE>",
                toTag = "<ENTER VALUE>",
                fromTag = "<ENTER VALUE>",
                remoteUri = "<ENTER VALUE>",
                localUri = "<ENTER VALUE>",
                rcSessionId = "<ENTER VALUE>"
            },
            sessionId = "<ENTER VALUE>",
            terminationType = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Presence().Put(presenceInfoResource);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Presence/updateUserPresenceStatus) in API Explorer.

## Get User Presence Status List

HTTP get `/restapi/v1.0/account/{accountId}/presence`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadAccountPresenceParameters readAccountPresenceParameters = new ReadAccountPresenceParameters {
    //detailedTelephonyState = true,
    //sipData = true,
    //page = 000,
    //perPage = 000
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
var r = await rc.Restapi().Account(accountId).Presence().Get(readAccountPresenceParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Presence/readAccountPresence) in API Explorer.

## Get Chats

HTTP get `/restapi/v1.0/glip/chats`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListGlipChatsParameters listGlipChatsParameters = new ListGlipChatsParameters {
    //type = new[] { "Everyone", "Group", "Personal", "Direct", "Team" },
    //recordCount = 30,
    //pageToken = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Chats().List(listGlipChatsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/listGlipChats) in API Explorer.

## Get Chat

HTTP get `/restapi/v1.0/glip/chats/{chatId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/readGlipChat) in API Explorer.

## Get Conversations

HTTP get `/restapi/v1.0/glip/conversations`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListGlipConversationsParameters listGlipConversationsParameters = new ListGlipConversationsParameters {
    //recordCount = 30,
    //pageToken = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Conversations().List(listGlipConversationsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Conversations/listGlipConversations) in API Explorer.

## Create/Open Conversation

HTTP post `/restapi/v1.0/glip/conversations`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
CreateGlipConversationRequest createGlipConversationRequest = new CreateGlipConversationRequest {
    members = new[] {
        new  {
            id = "<ENTER VALUE>",
            email = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Conversations().Post(createGlipConversationRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Conversations/createGlipConversation) in API Explorer.

## Get Conversation

HTTP get `/restapi/v1.0/glip/conversations/{chatId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Conversations(chatId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Conversations/readGlipConversation) in API Explorer.

## Get Teams

HTTP get `/restapi/v1.0/glip/teams`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListGlipTeamsParameters listGlipTeamsParameters = new ListGlipTeamsParameters {
    //recordCount = 30,
    //pageToken = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Teams().List(listGlipTeamsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/listGlipTeams) in API Explorer.

## Create Team

HTTP post `/restapi/v1.0/glip/teams`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
GlipPostTeamBody glipPostTeamBody = new GlipPostTeamBody {
    public = true,
    name = "<ENTER VALUE>",
    description = "<ENTER VALUE>",
    members = new[] {
        new  {
            id = "<ENTER VALUE>",
            email = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Teams().Post(glipPostTeamBody);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/createGlipTeam) in API Explorer.

## Get Team

HTTP get `/restapi/v1.0/glip/teams/{chatId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Teams(chatId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/readGlipTeam) in API Explorer.

## Update Team

HTTP patch `/restapi/v1.0/glip/teams/{chatId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// POST BODY
GlipPatchTeamBody glipPatchTeamBody = new GlipPatchTeamBody {
    public = true,
    name = "<ENTER VALUE>",
    description = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Teams(chatId).Patch(glipPatchTeamBody);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/patchGlipTeam) in API Explorer.

## Delete Team

HTTP delete `/restapi/v1.0/glip/teams/{chatId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Teams(chatId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/deleteGlipTeam) in API Explorer.

## Join Team

HTTP post `/restapi/v1.0/glip/teams/{chatId}/join`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Teams(chatId).Join().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/joinGlipTeam) in API Explorer.

## Leave Team

HTTP post `/restapi/v1.0/glip/teams/{chatId}/leave`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Teams(chatId).Leave().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/leaveGlipTeam) in API Explorer.

## Add Team Members

HTTP post `/restapi/v1.0/glip/teams/{chatId}/add`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// POST BODY
GlipPostMembersListBody glipPostMembersListBody = new GlipPostMembersListBody {
    members = new[] {
        new  {
            id = "<ENTER VALUE>",
            email = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Teams(chatId).Add().Post(glipPostMembersListBody);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/addGlipTeamMembers) in API Explorer.

## Remove Team Members

HTTP post `/restapi/v1.0/glip/teams/{chatId}/remove`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// POST BODY
GlipPostMembersIdsListBody glipPostMembersIdsListBody = new GlipPostMembersIdsListBody {
    members = new[] {
        new  {
            id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Teams(chatId).Remove().Post(glipPostMembersIdsListBody);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/removeGlipTeamMembers) in API Explorer.

## Archive Team

HTTP post `/restapi/v1.0/glip/teams/{chatId}/archive`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Teams(chatId).Archive().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/archiveGlipTeam) in API Explorer.

## Unarchive Team

HTTP post `/restapi/v1.0/glip/teams/{chatId}/unarchive`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Teams(chatId).Unarchive().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/unarchiveGlipTeam) in API Explorer.

## Get Everyone Chat

HTTP get `/restapi/v1.0/glip/everyone`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().Glip().Everyone().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/readGlipEveryone) in API Explorer.

## Update Everyone Сhat

HTTP patch `/restapi/v1.0/glip/everyone`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
UpdateGlipEveryoneRequest updateGlipEveryoneRequest = new UpdateGlipEveryoneRequest {
    name = 000,
    description = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Everyone().Patch(updateGlipEveryoneRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Teams/patchGlipEveryone) in API Explorer.

## Get Recent Chats

HTTP get `/restapi/v1.0/glip/recent/chats`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListRecentChatsParameters listRecentChatsParameters = new ListRecentChatsParameters {
    //type = new[] { "Everyone", "Group", "Personal", "Direct", "Team" },
    //recordCount = 30
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
var r = await rc.Restapi().Glip().Recent().Chats().Get(listRecentChatsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/listRecentChats) in API Explorer.

## Get Favorite Chats

HTTP get `/restapi/v1.0/glip/favorites`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListFavoriteChatsParameters listFavoriteChatsParameters = new ListFavoriteChatsParameters {
    //recordCount = 30
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
var r = await rc.Restapi().Glip().Favorites().Get(listFavoriteChatsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/listFavoriteChats) in API Explorer.

## Add Chat to Favorites

HTTP post `/restapi/v1.0/glip/chats/{chatId}/favorite`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Favorite().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/favoriteGlipChat) in API Explorer.

## Remove Chat from Favorites

HTTP post `/restapi/v1.0/glip/chats/{chatId}/unfavorite`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Unfavorite().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/unfavoriteGlipChat) in API Explorer.

## Mark Chat as Read

HTTP post `/restapi/v1.0/glip/chats/{chatId}/read`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Read().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/markChatRead) in API Explorer.

## Mark Chat as Unread

HTTP post `/restapi/v1.0/glip/chats/{chatId}/unread`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Unread().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Chats/markChatUnread) in API Explorer.

## Get Post

HTTP get `/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";
string postId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Posts(postId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Posts/readGlipPost) in API Explorer.

## Update Post

HTTP patch `/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";
string postId = "<ENTER VALUE>";

// POST BODY
GlipPatchPostBody glipPatchPostBody = new GlipPatchPostBody {
    text = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Chats(chatId).Posts(postId).Patch(glipPatchPostBody);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Posts/patchGlipPost) in API Explorer.

## Delete Post

HTTP delete `/restapi/v1.0/glip/chats/{chatId}/posts/{postId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";
string postId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Chats(chatId).Posts(postId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Posts/deleteGlipPost) in API Explorer.

## Get Posts

HTTP get `/restapi/v1.0/glip/chats/{chatId}/posts`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadGlipPostsParameters readGlipPostsParameters = new ReadGlipPostsParameters {
    //recordCount = 30,
    //pageToken = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Chats(chatId).Posts().List(readGlipPostsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Posts/readGlipPosts) in API Explorer.

## Create Post

HTTP post `/restapi/v1.0/glip/chats/{chatId}/posts`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// POST BODY
GlipPostPostBody glipPostPostBody = new GlipPostPostBody {
    text = "<ENTER VALUE>",
    attachments = new[] {
        new  {
            id = "<ENTER VALUE>",
            type = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Chats(chatId).Posts().Post(glipPostPostBody);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Posts/createGlipPost) in API Explorer.

## Get User Events List

HTTP get `/restapi/v1.0/glip/events`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ReadGlipEventsParameters readGlipEventsParameters = new ReadGlipEventsParameters {
    //recordCount = 30,
    //pageToken = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Events().List(readGlipEventsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/readGlipEvents) in API Explorer.

## Create Event

HTTP post `/restapi/v1.0/glip/events`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
GlipEventCreate glipEventCreate = new GlipEventCreate {
    id = "<ENTER VALUE>",
    creatorId = "<ENTER VALUE>",
    title = "<ENTER VALUE>",
    startTime = "<ENTER VALUE>",
    endTime = "<ENTER VALUE>",
    allDay = true,
    recurrence = 'None',
    endingCondition = "<ENTER VALUE>",
    endingAfter = 000,
    endingOn = 'None',
    color = 'Black',
    location = "<ENTER VALUE>",
    description = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Events().Post(glipEventCreate);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/createEvent) in API Explorer.

## Get Event

HTTP get `/restapi/v1.0/glip/events/{eventId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string eventId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Events(eventId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/readEvent) in API Explorer.

## Update Event

HTTP put `/restapi/v1.0/glip/events/{eventId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string eventId = "<ENTER VALUE>";

// POST BODY
GlipEventCreate glipEventCreate = new GlipEventCreate {
    id = "<ENTER VALUE>",
    creatorId = "<ENTER VALUE>",
    title = "<ENTER VALUE>",
    startTime = "<ENTER VALUE>",
    endTime = "<ENTER VALUE>",
    allDay = true,
    recurrence = 'None',
    endingCondition = "<ENTER VALUE>",
    endingAfter = 000,
    endingOn = 'None',
    color = 'Black',
    location = "<ENTER VALUE>",
    description = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Events(eventId).Put(glipEventCreate);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/updateEvent) in API Explorer.

## Delete Event

HTTP delete `/restapi/v1.0/glip/events/{eventId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string eventId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Events(eventId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/deleteEvent) in API Explorer.

## Create Event by Group ID

HTTP post `/restapi/v1.0/glip/groups/{groupId}/events`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string groupId = "<ENTER VALUE>";

// POST BODY
GlipEventCreate glipEventCreate = new GlipEventCreate {
    id = "<ENTER VALUE>",
    creatorId = "<ENTER VALUE>",
    title = "<ENTER VALUE>",
    startTime = "<ENTER VALUE>",
    endTime = "<ENTER VALUE>",
    allDay = true,
    recurrence = 'None',
    endingCondition = "<ENTER VALUE>",
    endingAfter = 000,
    endingOn = 'None',
    color = 'Black',
    location = "<ENTER VALUE>",
    description = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Groups(groupId).Events().Post(glipEventCreate);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/createEventbyGroupId) in API Explorer.

## Get Group Events

HTTP get `/restapi/v1.0/glip/groups/{groupId}/events`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string groupId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Groups(groupId).Events().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Calendar-Events/listGroupEvents) in API Explorer.

## Get Chat Tasks

HTTP get `/restapi/v1.0/glip/chats/{chatId}/tasks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListChatTasksParameters listChatTasksParameters = new ListChatTasksParameters {
    //creationTimeTo = 'now',
    //creationTimeFrom = "<ENTER VALUE>",
    //creatorId = new[] { string },
    //status = new[] { "Pending", "InProgress", "Completed" },
    //assignmentStatus = 'Unassigned',
    //assigneeId = new[] { string },
    //assigneeStatus = 'Pending',
    //pageToken = "<ENTER VALUE>",
    //recordCount = 30
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
var r = await rc.Restapi().Glip().Chats(chatId).Tasks().Get(listChatTasksParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Tasks/listChatTasks) in API Explorer.

## Create Task

HTTP post `/restapi/v1.0/glip/chats/{chatId}/tasks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string chatId = "<ENTER VALUE>";

// POST BODY
GlipCreateTask glipCreateTask = new GlipCreateTask {
    subject = "<ENTER VALUE>",
    assignees = new[] {
        new  {
            id = "<ENTER VALUE>"
        },
    },
    completenessCondition = 'Simple',
    startDate = "<ENTER VALUE>",
    dueDate = "<ENTER VALUE>",
    color = 'Black',
    section = "<ENTER VALUE>",
    description = "<ENTER VALUE>",
    recurrence = new  {
        schedule = 'None',
        endingCondition = 'None',
        endingAfter = 000,
        endingOn = "<ENTER VALUE>"
    },
    attachments = new[] {
        new  {
            id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Chats(chatId).Tasks().Post(glipCreateTask);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Tasks/createTask) in API Explorer.

## Get Task

HTTP get `/restapi/v1.0/glip/tasks/{taskId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Tasks(taskId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Tasks/readTask) in API Explorer.

## Patch Task

HTTP patch `/restapi/v1.0/glip/tasks/{taskId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";

// POST BODY
GlipUpdateTask glipUpdateTask = new GlipUpdateTask {
    subject = "<ENTER VALUE>",
    assignees = new[] {
        new  {
            id = "<ENTER VALUE>"
        },
    },
    completenessCondition = 'Simple',
    startDate = "<ENTER VALUE>",
    dueDate = "<ENTER VALUE>",
    color = 'Black',
    section = "<ENTER VALUE>",
    description = "<ENTER VALUE>",
    recurrence = new  {
        schedule = 'None',
        endingCondition = 'None',
        endingAfter = 000,
        endingOn = "<ENTER VALUE>"
    },
    attachments = new[] {
        new  {
            id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Glip().Tasks(taskId).Patch(glipUpdateTask);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Tasks/patchTask) in API Explorer.

## Delete Task

HTTP delete `/restapi/v1.0/glip/tasks/{taskId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Tasks(taskId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Tasks/deleteTask) in API Explorer.

## Complete Task

HTTP post `/restapi/v1.0/glip/tasks/{taskId}/complete`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";

// POST BODY
GlipCompleteTask glipCompleteTask = new GlipCompleteTask {
    status = 'Incomplete',
    assignees = new[] {
        new  {
            id = "<ENTER VALUE>"
        },
    },
    completenessPercentage = 000
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
var r = await rc.Restapi().Glip().Tasks(taskId).Complete().Post(glipCompleteTask);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Tasks/completeTask) in API Explorer.

## Get Person

HTTP get `/restapi/v1.0/glip/persons/{personId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string personId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Persons(personId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Profile/readGlipPerson) in API Explorer.

## Get Company Info

HTTP get `/restapi/v1.0/glip/companies/{companyId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string companyId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Companies(companyId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Profile/readGlipCompany) in API Explorer.

## Create Webhook in Group

HTTP post `/restapi/v1.0/glip/groups/{groupId}/webhooks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string groupId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Groups(groupId).Webhooks().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/createGlipGroupWebhook) in API Explorer.

## Get Webhooks in Group

HTTP get `/restapi/v1.0/glip/groups/{groupId}/webhooks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string groupId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Groups(groupId).Webhooks().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/listGlipGroupWebhooks) in API Explorer.

## Get Webhooks

HTTP get `/restapi/v1.0/glip/webhooks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().Glip().Webhooks().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/listGlipWebhooks) in API Explorer.

## Get Webhook

HTTP get `/restapi/v1.0/glip/webhooks/{webhookId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string webhookId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Webhooks(webhookId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/readGlipWebhook) in API Explorer.

## Delete Webhook

HTTP delete `/restapi/v1.0/glip/webhooks/{webhookId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string webhookId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Webhooks(webhookId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/deleteGlipWebhook) in API Explorer.

## Activate Webhook

HTTP post `/restapi/v1.0/glip/webhooks/{webhookId}/activate`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string webhookId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Webhooks(webhookId).Activate().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/activateGlipWebhook) in API Explorer.

## Suspend Webhook

HTTP post `/restapi/v1.0/glip/webhooks/{webhookId}/suspend`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string webhookId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().Webhooks(webhookId).Suspend().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Webhooks/suspendGlipWebhook) in API Explorer.

## Get Preferences

HTTP get `/restapi/v1.0/glip/preferences`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().Glip().Preferences().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Profile/readGlipPreferences) in API Explorer.

## Get Scheduled Meetings

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Management/listMeetings) in API Explorer.

## Create Meetings

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting().Post(meetingRequestResource);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Management/createMeeting) in API Explorer.

## Get Meeting Info

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string meetingId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting(meetingId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Management/readMeeting) in API Explorer.

## Update Meeting

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Management/updateMeeting) in API Explorer.

## Delete Meeting

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string meetingId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting(meetingId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Management/deleteMeeting) in API Explorer.

## End Meeting

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/{meetingId}/end`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string meetingId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting(meetingId).End().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Management/endMeeting) in API Explorer.

## Get Meeting Service Info

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meeting/service-info`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Meeting().ServiceInfo().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Configuration/readMeetingServiceInfo) in API Explorer.

## Get Assistants

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assistants`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MeetingsConfiguration().Assistants().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Configuration/readAssistants) in API Explorer.

## Get Assisted Users

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/meetings-configuration/assisted`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).MeetingsConfiguration().Assisted().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Meeting-Configuration/readAssistedUsers) in API Explorer.

## Get Subscriptions

HTTP get `/restapi/v1.0/subscription`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().Subscription().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Subscriptions/listSubscriptions) in API Explorer.

## Create Subscription

HTTP post `/restapi/v1.0/subscription`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Subscriptions/createSubscription) in API Explorer.

## Get Subscription

HTTP get `/restapi/v1.0/subscription/{subscriptionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string subscriptionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Subscription(subscriptionId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Subscriptions/readSubscription) in API Explorer.

## Renew Subscription / Update Event Filters

HTTP put `/restapi/v1.0/subscription/{subscriptionId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Subscriptions/updateSubscription) in API Explorer.

## Cancel Subscription

HTTP delete `/restapi/v1.0/subscription/{subscriptionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string subscriptionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Subscription(subscriptionId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Subscriptions/deleteSubscription) in API Explorer.

## Renew Subscription

HTTP post `/restapi/v1.0/subscription/{subscriptionId}/renew`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string subscriptionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Subscription(subscriptionId).Renew().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Subscriptions/renewSubscription) in API Explorer.

## Get Authorization Profile

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AuthzProfile().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Permissions/readAuthorizationProfile) in API Explorer.

## Check User Permission

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/authz-profile/check`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
CheckUserPermissionParameters checkUserPermissionParameters = new CheckUserPermissionParameters {
    //permissionId = "<ENTER VALUE>",
    //targetExtensionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AuthzProfile().Check().Get(checkUserPermissionParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Permissions/checkUserPermission) in API Explorer.

## Get User Business Hours

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).BusinessHours().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Business-Hours/readUserBusinessHours) in API Explorer.

## Update User Business Hours

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/business-hours`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
UserBusinessHoursUpdateRequest userBusinessHoursUpdateRequest = new UserBusinessHoursUpdateRequest {
    schedule = new UserBusinessHoursScheduleInfo {
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).BusinessHours().Put(userBusinessHoursUpdateRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Business-Hours/updateUserBusinessHours) in API Explorer.

## Get Company Business Hours

HTTP get `/restapi/v1.0/account/{accountId}/business-hours`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).BusinessHours().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Business-Hours/readCompanyBusinessHours) in API Explorer.

## Update Company Business Hours

HTTP put `/restapi/v1.0/account/{accountId}/business-hours`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Business-Hours/updateCompanyBusinessHours) in API Explorer.

## Get Caller Blocking Settings

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/readCallerBlockingSettings) in API Explorer.

## Update Caller Blocking Settings

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CallerBlockingSettingsUpdate callerBlockingSettingsUpdate = new CallerBlockingSettingsUpdate {
    mode = 'Specific',
    noCallerId = 'BlockCallsAndFaxes',
    payPhones = 'Block',
    greetings = new[] {
        new BlockedCallerGreetingInfo {
            type = "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().Put(callerBlockingSettingsUpdate);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/updateCallerBlockingSettings) in API Explorer.

## Get Blocked/Allowed Phone Numbers

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListBlockedAllowedNumbersParameters listBlockedAllowedNumbersParameters = new ListBlockedAllowedNumbersParameters {
    //page = 000,
    //perPage = 000,
    //status = 'Blocked'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().List(listBlockedAllowedNumbersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/listBlockedAllowedNumbers) in API Explorer.

## Add Blocked/Allowed Number

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber = new AddBlockedAllowedPhoneNumber {
    phoneNumber = "<ENTER VALUE>",
    label = "<ENTER VALUE>",
    status = 'Blocked'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers().Post(addBlockedAllowedPhoneNumber);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/createBlockedAllowedNumber) in API Explorer.

## Get Blocked/Allowed Number

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string blockedNumberId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/readBlockedAllowedNumber) in API Explorer.

## Delete Blocked/Allowed Number

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string blockedNumberId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/deleteBlockedAllowedNumber) in API Explorer.

## Update Blocked/Allowed Number

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-blocking/phone-numbers/{blockedNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string blockedNumberId = "<ENTER VALUE>";

// POST BODY
AddBlockedAllowedPhoneNumber addBlockedAllowedPhoneNumber = new AddBlockedAllowedPhoneNumber {
    phoneNumber = "<ENTER VALUE>",
    label = "<ENTER VALUE>",
    status = 'Blocked'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerBlocking().PhoneNumbers(blockedNumberId).Put(addBlockedAllowedPhoneNumber);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Blocking/updateBlockedAllowedNumber) in API Explorer.

## Get Forwarding Number List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListForwardingNumbersParameters listForwardingNumbersParameters = new ListForwardingNumbersParameters {
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ForwardingNumber().List(listForwardingNumbersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Forwarding/listForwardingNumbers) in API Explorer.

## Create Forwarding Number

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CreateForwardingNumberRequest createForwardingNumberRequest = new CreateForwardingNumberRequest {
    phoneNumber = "<ENTER VALUE>",
    label = "<ENTER VALUE>",
    type = 'PhoneLine',
    device = new CreateForwardingNumberDeviceInfo {
        id = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ForwardingNumber().Post(createForwardingNumberRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Forwarding/createForwardingNumber) in API Explorer.

## Get Forwarding Number

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string forwardingNumberId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Forwarding/readForwardingNumber) in API Explorer.

## Update Forwarding Number

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string forwardingNumberId = "<ENTER VALUE>";

// POST BODY
UpdateForwardingNumberRequest updateForwardingNumberRequest = new UpdateForwardingNumberRequest {
    phoneNumber = "<ENTER VALUE>",
    label = "<ENTER VALUE>",
    flipNumber = "<ENTER VALUE>",
    type = 'Home'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Put(updateForwardingNumberRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Forwarding/updateForwardingNumber) in API Explorer.

## Delete Forwarding Number

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/forwarding-number/{forwardingNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string forwardingNumberId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ForwardingNumber(forwardingNumberId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Forwarding/deleteForwardingNumber) in API Explorer.

## Get Call Handling Rules

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListAnsweringRulesParameters listAnsweringRulesParameters = new ListAnsweringRulesParameters {
    //view = 'Simple',
    //enabledOnly = true,
    //page = '1',
    //perPage = '100'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AnsweringRule().List(listAnsweringRulesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/listAnsweringRules) in API Explorer.

## Create Call Handling Rule

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
CreateAnsweringRuleRequest createAnsweringRuleRequest = new CreateAnsweringRuleRequest {
    enabled = true,
    type = "<ENTER VALUE>",
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
    forwarding = new ForwardingInfo {
        notifyMySoftPhones = true,
        notifyAdminSoftPhones = true,
        softPhonesRingCount = 000,
        ringingMode = 'Sequentially',
        rules = new[] {
            new RuleInfo {
                index = 000,
                ringCount = 000,
                enabled = true,
                forwardingNumbers = new[] {
                    new ForwardingNumberInfoRules {
                        uri = "<ENTER VALUE>",
                        id = "<ENTER VALUE>",
                        phoneNumber = "<ENTER VALUE>",
                        label = "<ENTER VALUE>",
                        type = 'Home'
                    },
                }
            },
        },
        mobileTimeout = true
    },
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
    transfer = new TransferredExtensionInfo {
        extension = new ExtensionInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            extensionNumber = "<ENTER VALUE>",
            partnerId = "<ENTER VALUE>"
        }
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
    screening = 'Off'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AnsweringRule().Post(createAnsweringRuleRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/createAnsweringRule) in API Explorer.

## Get Call Handling Rule

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string ruleId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadAnsweringRuleParameters readAnsweringRuleParameters = new ReadAnsweringRuleParameters {
    //showInactiveNumbers = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Get(readAnsweringRuleParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/readAnsweringRule) in API Explorer.

## Update Call Handling Rule

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/updateAnsweringRule) in API Explorer.

## Delete Call Handling Rule

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}/answering-rule/{ruleId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string ruleId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).AnsweringRule(ruleId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/deleteAnsweringRule) in API Explorer.

## Create Company Call Handling Rule

HTTP post `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CompanyAnsweringRuleRequest companyAnsweringRuleRequest = new CompanyAnsweringRuleRequest {
    name = "<ENTER VALUE>",
    enabled = true,
    type = 'BusinessHours',
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
var r = await rc.Restapi().Account(accountId).AnsweringRule().Post(companyAnsweringRuleRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/createCompanyAnsweringRule) in API Explorer.

## Get Company Call Handling Rule List

HTTP get `/restapi/v1.0/account/{accountId}/answering-rule`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).AnsweringRule().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/listCompanyAnsweringRules) in API Explorer.

## Get Company Call Handling Rule

HTTP get `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string ruleId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).AnsweringRule(ruleId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/readCompanyAnsweringRule) in API Explorer.

## Update Company Call Handling Rule

HTTP put `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/updateCompanyAnsweringRule) in API Explorer.

## Delete Company Call Handling Rule

HTTP delete `/restapi/v1.0/account/{accountId}/answering-rule/{ruleId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string ruleId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).AnsweringRule(ruleId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/deleteCompanyAnsweringRule) in API Explorer.

## Get Standard Greeting List

HTTP get `/restapi/v1.0/dictionary/greeting`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListStandardGreetingsParameters listStandardGreetingsParameters = new ListStandardGreetingsParameters {
    //page = 1,
    //perPage = 100,
    //type = 'Introductory',
    //usageType = 'UserExtensionAnsweringRule'
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
var r = await rc.Restapi().Dictionary().Greeting().List(listStandardGreetingsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/listStandardGreetings) in API Explorer.

## Get Standard Greeting

HTTP get `/restapi/v1.0/dictionary/greeting/{greetingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string greetingId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Dictionary().Greeting(greetingId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/readStandardGreeting) in API Explorer.

## Create Company Greeting

HTTP post `/restapi/v1.0/account/{accountId}/greeting`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Greeting().Post(formData);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/createCompanyGreeting) in API Explorer.

## Create Custom User Greeting

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Greeting().Post(formData);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/createCustomUserGreeting) in API Explorer.

## Get Custom Greeting

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/greeting/{greetingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string greetingId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Greeting(greetingId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/readCustomGreeting) in API Explorer.

## Create IVR Prompts

HTTP post `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).IvrPrompts().Post(formData);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/createIVRPrompt) in API Explorer.

## Get IVR Prompt List

HTTP get `/restapi/v1.0/account/{accountId}/ivr-prompts`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).IvrPrompts().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/listIVRPrompts) in API Explorer.

## Get IVR Prompt

HTTP get `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string promptId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).IvrPrompts(promptId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/readIVRPrompt) in API Explorer.

## Delete IVR Prompt

HTTP delete `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string promptId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).IvrPrompts(promptId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/deleteIVRPrompt) in API Explorer.

## Update IVR Prompt

HTTP put `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string promptId = "<ENTER VALUE>";

// POST BODY
UpdateIVRPromptRequest updateIVRPromptRequest = new UpdateIVRPromptRequest {
    filename = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).IvrPrompts(promptId).Put(updateIVRPromptRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/updateIVRPrompt) in API Explorer.

## Get IVR Prompt Content

HTTP get `/restapi/v1.0/account/{accountId}/ivr-prompts/{promptId}/content`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string promptId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).IvrPrompts(promptId).Content().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/readIVRPromptContent) in API Explorer.

## Create IVR Menu

HTTP post `/restapi/v1.0/account/{accountId}/ivr-menus`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
IVRMenuInfo iVRMenuInfo = new IVRMenuInfo {
    id = "<ENTER VALUE>",
    uri = "<ENTER VALUE>",
    name = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    prompt = new IVRMenuPromptInfo {
        mode = 'Audio',
        audio = new PromptLanguageInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>"
        },
        text = "<ENTER VALUE>",
        language = new AudioPromptInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>"
        }
    },
    actions = new[] {
        new IVRMenuActionsInfo {
            input = "<ENTER VALUE>",
            action = 'Connect',
            extension = new IVRMenuExtensionInfo {
                uri = "<ENTER VALUE>",
                id = "<ENTER VALUE>"
            },
            phoneNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).IvrMenus().Post(iVRMenuInfo);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/createIVRMenu) in API Explorer.

## Get IVR Menu

HTTP get `/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string ivrMenuId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).IvrMenus(ivrMenuId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/readIVRMenu) in API Explorer.

## Update IVR Menu

HTTP put `/restapi/v1.0/account/{accountId}/ivr-menus/{ivrMenuId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string ivrMenuId = "<ENTER VALUE>";

// POST BODY
IVRMenuInfo iVRMenuInfo = new IVRMenuInfo {
    id = "<ENTER VALUE>",
    uri = "<ENTER VALUE>",
    name = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    prompt = new IVRMenuPromptInfo {
        mode = 'Audio',
        audio = new PromptLanguageInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>"
        },
        text = "<ENTER VALUE>",
        language = new AudioPromptInfo {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>"
        }
    },
    actions = new[] {
        new IVRMenuActionsInfo {
            input = "<ENTER VALUE>",
            action = 'Connect',
            extension = new IVRMenuExtensionInfo {
                uri = "<ENTER VALUE>",
                id = "<ENTER VALUE>"
            },
            phoneNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).IvrMenus(ivrMenuId).Put(iVRMenuInfo);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Routing/updateIVRMenu) in API Explorer.

## Get Call Recording Settings

HTTP get `/restapi/v1.0/account/{accountId}/call-recording`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).CallRecording().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/readCallRecordingSettings) in API Explorer.

## Update Call Recording Settings

HTTP put `/restapi/v1.0/account/{accountId}/call-recording`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CallRecordingSettingsResource callRecordingSettingsResource = new CallRecordingSettingsResource {
    onDemand = new OnDemandResource {
        enabled = true
    },
    automatic = new AutomaticRecordingResource {
        enabled = true,
        outboundCallTones = true,
        outboundCallAnnouncement = true,
        allowMute = true,
        extensionCount = 000
    },
    greetings = new[] {
        new GreetingResource {
            type = 'StartRecording',
            mode = 'Default'
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
var r = await rc.Restapi().Account(accountId).CallRecording().Put(callRecordingSettingsResource);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/updateCallRecordingSettings) in API Explorer.

## Get Call Recording Extension List

HTTP get `/restapi/v1.0/account/{accountId}/call-recording/extensions`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).CallRecording().Extensions().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/listCallRecordingExtensions) in API Explorer.

## Update Call Recording Extension List

HTTP post `/restapi/v1.0/account/{accountId}/call-recording/bulk-assign`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
BulkAccountCallRecordingsResource bulkAccountCallRecordingsResource = new BulkAccountCallRecordingsResource {
    addedExtensions = new CallRecordingExtensionResource {
        id = "<ENTER VALUE>",
        uri = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>",
        type = "<ENTER VALUE>",
        callDirection = 'Outbound'
    },
    updatedExtensions = new CallRecordingExtensionResource {
        id = "<ENTER VALUE>",
        uri = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>",
        type = "<ENTER VALUE>",
        callDirection = 'Outbound'
    },
    removedExtensions = new CallRecordingExtensionResource {
        id = "<ENTER VALUE>",
        uri = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>",
        type = "<ENTER VALUE>",
        callDirection = 'Outbound'
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
var r = await rc.Restapi().Account(accountId).CallRecording().BulkAssign().Post(bulkAccountCallRecordingsResource);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/updateCallRecordingExtensionList) in API Explorer.

## Get Call Recording Custom Greeting List

HTTP get `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallRecordingCustomGreetingsParameters listCallRecordingCustomGreetingsParameters = new ListCallRecordingCustomGreetingsParameters {
    //type = 'StartRecording'
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
var r = await rc.Restapi().Account(accountId).CallRecording().CustomGreetings().List(listCallRecordingCustomGreetingsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/listCallRecordingCustomGreetings) in API Explorer.

## Delete Call Recording Custom Greeting List

HTTP delete `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).CallRecording().CustomGreetings().Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/deleteCallRecordingCustomGreetingList) in API Explorer.

## Delete Call Recording Custom Greeting

HTTP delete `/restapi/v1.0/account/{accountId}/call-recording/custom-greetings/{greetingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string greetingId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).CallRecording().CustomGreetings(greetingId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Rule-Management/deleteCallRecordingCustomGreeting) in API Explorer.

## Register SIP Device

HTTP post `/restapi/v1.0/client-info/sip-provision`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
CreateSipRegistrationRequest createSipRegistrationRequest = new CreateSipRegistrationRequest {
    device = new[] {
        new DeviceInfoRequest {
            id = "<ENTER VALUE>",
            appExternalId = "<ENTER VALUE>",
            computerName = "<ENTER VALUE>"
        },
    },
    sipInfo = new[] {
        new SIPInfoRequest {
            transport = 'UDP'
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
var r = await rc.Restapi().ClientInfo().SipProvision().Post(createSipRegistrationRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SIP/createSIPRegistration) in API Explorer.

## Get Extension Phone Number List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/phone-number`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionPhoneNumbersParameters listExtensionPhoneNumbersParameters = new ListExtensionPhoneNumbersParameters {
    //usageType = new[] { "MainCompanyNumber", "AdditionalCompanyNumber", "CompanyNumber", "DirectNumber", "CompanyFaxNumber", "ForwardedNumber", "ForwardedCompanyNumber" },
    //page = 000,
    //perPage = 000
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).PhoneNumber().Get(listExtensionPhoneNumbersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Phone-Numbers/listExtensionPhoneNumbers) in API Explorer.

## Get Extension

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/readExtension) in API Explorer.

## Update Extension

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
ExtensionUpdateRequest extensionUpdateRequest = new ExtensionUpdateRequest {
    status = 'Disabled',
    statusInfo = new ExtensionStatusInfo {
        comment = "<ENTER VALUE>",
        reason = 'Voluntarily'
    },
    reason = "<ENTER VALUE>",
    comment = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    contact = new ContactInfoUpdateRequest {
        firstName = "<ENTER VALUE>",
        lastName = "<ENTER VALUE>",
        company = "<ENTER VALUE>",
        jobTitle = "<ENTER VALUE>",
        email = "<ENTER VALUE>",
        businessPhone = "<ENTER VALUE>",
        mobilePhone = "<ENTER VALUE>",
        businessAddress = new ContactBusinessAddressInfo {
            country = "<ENTER VALUE>",
            state = "<ENTER VALUE>",
            city = "<ENTER VALUE>",
            street = "<ENTER VALUE>",
            zip = "<ENTER VALUE>"
        },
        emailAsLoginName = true,
        pronouncedName = new PronouncedNameInfo {
            type = 'Default',
            text = "<ENTER VALUE>"
        },
        department = "<ENTER VALUE>"
    },
    regionalSettings = new ExtensionRegionalSettingRequest {
        homeCountry = new ExtensionCountryInfoRequest {
            id = "<ENTER VALUE>"
        },
        timezone = new ExtensionTimezoneInfoRequest {
            id = "<ENTER VALUE>"
        },
        language = new ExtensionLanguageInfoRequest {
            id = "<ENTER VALUE>"
        },
        greetingLanguage = new ExtensionGreetingLanguageInfoRequest {
            id = "<ENTER VALUE>"
        },
        formattingLocale = new ExtensionFormattingLocaleInfoRequest {
            id = "<ENTER VALUE>"
        },
        timeFormat = '12h'
    },
    setupWizardState = 'NotStarted',
    partnerId = "<ENTER VALUE>",
    ivrPin = "<ENTER VALUE>",
    password = "<ENTER VALUE>",
    callQueueInfo = new CallQueueInfoRequest {
        slaGoal = 000,
        slaThresholdSeconds = 000,
        includeAbandonedCalls = true,
        abandonedThresholdSeconds = 000
    },
    transition = new[] {
        new UserTransitionInfo {
            sendWelcomeEmailsToUsers = true,
            sendWelcomeEmail = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Put(extensionUpdateRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/updateExtension) in API Explorer.

## Delete Extension

HTTP delete `/restapi/v1.0/account/{accountId}/extension/{extensionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/deleteExtension) in API Explorer.

## Get Extension Caller ID

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerId().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/readExtensionCallerId) in API Explorer.

## Update Extension Caller ID

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/caller-id`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
ExtensionCallerIdInfo extensionCallerIdInfo = new ExtensionCallerIdInfo {
    uri = "<ENTER VALUE>",
    byDevice = new[] {
        new CallerIdByDevice {
            device = new CallerIdDeviceInfo {
                id = "<ENTER VALUE>",
                uri = "<ENTER VALUE>",
                phoneNumber = "<ENTER VALUE>"
            },
            callerId = new CallerIdByDeviceInfo {
                type = "<ENTER VALUE>",
                phoneInfo = new CallerIdPhoneInfo {
                    id = "<ENTER VALUE>",
                    uri = "<ENTER VALUE>",
                    phoneNumber = "<ENTER VALUE>"
                }
            }
        },
    },
    byFeature = new[] {
        new CallerIdByFeature {
            feature = 'RingOut',
            callerId = new CallerIdByFeatureInfo {
                type = "<ENTER VALUE>",
                phoneInfo = new CallerIdPhoneInfo {
                    id = "<ENTER VALUE>",
                    uri = "<ENTER VALUE>",
                    phoneNumber = "<ENTER VALUE>"
                }
            }
        },
    },
    extensionNameForOutboundCalls = true,
    extensionNumberForInternalCalls = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).CallerId().Put(extensionCallerIdInfo);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/updateExtensionCallerId) in API Explorer.

## Get Extension Grant List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/grant`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionGrantsParameters listExtensionGrantsParameters = new ListExtensionGrantsParameters {
    //page = '1',
    //perPage = '100'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Grant().Get(listExtensionGrantsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/listExtensionGrants) in API Explorer.

## Get User List

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListAutomaticLocationUpdatesUsersParameters listAutomaticLocationUpdatesUsersParameters = new ListAutomaticLocationUpdatesUsersParameters {
    //type = 'User',
    //searchString = "<ENTER VALUE>",
    //department = "<ENTER VALUE>",
    //siteId = "<ENTER VALUE>",
    //featureEnabled = true,
    //orderBy = 'name',
    //perPage = 000,
    //page = 1
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Users().Get(listAutomaticLocationUpdatesUsersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/listAutomaticLocationUpdatesUsers) in API Explorer.

## Enable Automatic Location Updates for Users

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/users/bulk-assign`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
BulkAssignAutomaticaLocationUpdatesUsers bulkAssignAutomaticaLocationUpdatesUsers = new BulkAssignAutomaticaLocationUpdatesUsers {
    enabledUserIds = new[] {
        "<ENTER VALUE>",
    },
    disabledUserIds = new[] {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Users().BulkAssign().Post(bulkAssignAutomaticaLocationUpdatesUsers);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/assignMultipleAutomaticaLocationUpdatesUsers) in API Explorer.

## Get Wireless Point List

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListWirelessPointsParameters listWirelessPointsParameters = new ListWirelessPointsParameters {
    //siteId = "<ENTER VALUE>",
    //searchString = "<ENTER VALUE>",
    //orderBy = "<ENTER VALUE>",
    //perPage = 000,
    //page = 1
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().List(listWirelessPointsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/listWirelessPoints) in API Explorer.

## Create Wireless Point

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateWirelessPoint createWirelessPoint = new CreateWirelessPoint {
    bssid = "<ENTER VALUE>",
    name = "<ENTER VALUE>",
    site = new AutomaticLocationUpdatesSiteInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints().Post(createWirelessPoint);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/createWirelessPoint) in API Explorer.

## Get Wireless Point

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pointId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/readWirelessPoint) in API Explorer.

## Update Wireless Point

HTTP put `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pointId = "<ENTER VALUE>";

// POST BODY
UpdateWirelessPoint updateWirelessPoint = new UpdateWirelessPoint {
    id = "<ENTER VALUE>",
    bssid = "<ENTER VALUE>",
    name = "<ENTER VALUE>",
    site = new AutomaticLocationUpdatesSiteInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Put(updateWirelessPoint);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/updateWirelessPoint) in API Explorer.

## Delete Wireless Point

HTTP delete `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points/{pointId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pointId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPoints(pointId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/deleteWirelessPoint) in API Explorer.

## Get Network Map

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Networks().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/listNetworks) in API Explorer.

## Create Network

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateNetworkRequest createNetworkRequest = new CreateNetworkRequest {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Networks().Post(createNetworkRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/createNetwork) in API Explorer.

## Get Network

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string networkId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/readNetwork) in API Explorer.

## Update Network

HTTP put `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/updateNetwork) in API Explorer.

## Delete Network

HTTP delete `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/networks/{networkId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string networkId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Networks(networkId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/deleteNetwork) in API Explorer.

## Get Device List

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListDevicesAutomaticLocationUpdatesParameters listDevicesAutomaticLocationUpdatesParameters = new ListDevicesAutomaticLocationUpdatesParameters {
    //siteId = "<ENTER VALUE>",
    //featureEnabled = true,
    //model = "<ENTER VALUE>",
    //compatibleOnly = true,
    //searchString = "<ENTER VALUE>",
    //orderBy = 'name',
    //perPage = 000,
    //page = 1
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Devices().Get(listDevicesAutomaticLocationUpdatesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/listDevicesAutomaticLocationUpdates) in API Explorer.

## Enable Automatic Location Updates for Devices

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/devices/bulk-assign`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
AssignMultipleDevicesAutomaticLocationUpdates assignMultipleDevicesAutomaticLocationUpdates = new AssignMultipleDevicesAutomaticLocationUpdates {
    enabledDeviceIds = new[] {
        "<ENTER VALUE>",
    },
    disabledDeviceIds = new[] {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Devices().BulkAssign().Post(assignMultipleDevicesAutomaticLocationUpdates);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/assignMultipleDevicesAutomaticLocationUpdates) in API Explorer.

## Get Account Switch List

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListAccountSwitchesParameters listAccountSwitchesParameters = new ListAccountSwitchesParameters {
    //siteId = "<ENTER VALUE>",
    //searchString = "<ENTER VALUE>",
    //orderBy = "<ENTER VALUE>",
    //perPage = 000,
    //page = 1
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Switches().List(listAccountSwitchesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/listAccountSwitches) in API Explorer.

## Create Switch

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateSwitchInfo createSwitchInfo = new CreateSwitchInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Switches().Post(createSwitchInfo);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/createSwitch) in API Explorer.

## Get Switch

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string switchId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/readSwitch) in API Explorer.

## Update Switch

HTTP put `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/updateSwitch) in API Explorer.

## Delete Switch

HTTP delete `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches/{switchId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string switchId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Switches(switchId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/deleteSwitch) in API Explorer.

## Create Multiple Switches

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-create`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateMultipleSwitchesRequest createMultipleSwitchesRequest = new CreateMultipleSwitchesRequest {
    records = new[] {
        new CreateSwitchInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkCreate().Post(createMultipleSwitchesRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/createMultipleSwitches) in API Explorer.

## Update Multiple Switches

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-update`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
UpdateMultipleSwitchesRequest updateMultipleSwitchesRequest = new UpdateMultipleSwitchesRequest {
    records = new[] {
        new UpdateSwitchInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkUpdate().Post(updateMultipleSwitchesRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/updateMultipleSwitches) in API Explorer.

## Create Multiple Wireless Points

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-create`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateMultipleWirelessPointsRequest createMultipleWirelessPointsRequest = new CreateMultipleWirelessPointsRequest {
    records = new[] {
        new CreateWirelessPoint {
            bssid = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            site = new AutomaticLocationUpdatesSiteInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkCreate().Post(createMultipleWirelessPointsRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/createMultipleWirelessPoints) in API Explorer.

## Update Multiple Wireless Points

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-update`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
UpdateMultipleWirelessPointsRequest updateMultipleWirelessPointsRequest = new UpdateMultipleWirelessPointsRequest {
    records = new[] {
        new UpdateWirelessPoint {
            id = "<ENTER VALUE>",
            bssid = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            site = new AutomaticLocationUpdatesSiteInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkUpdate().Post(updateMultipleWirelessPointsRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/updateMultipleWirelessPoints) in API Explorer.

## Validate Multiple Wireless Points

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/wireless-points-bulk-validate`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
ValidateMultipleWirelessPointsRequest validateMultipleWirelessPointsRequest = new ValidateMultipleWirelessPointsRequest {
    records = new[] {
        new WirelessPointInfo {
            id = "<ENTER VALUE>",
            bssid = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            site = new AutomaticLocationUpdatesSiteInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().WirelessPointsBulkValidate().Post(validateMultipleWirelessPointsRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/validateMultipleWirelessPoints) in API Explorer.

## Validate Multiple Switches

HTTP post `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/switches-bulk-validate`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
ValidateMultipleSwitchesRequest validateMultipleSwitchesRequest = new ValidateMultipleSwitchesRequest {
    records = new[] {
        new SwitchInfo {
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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().SwitchesBulkValidate().Post(validateMultipleSwitchesRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/validateMultipleSwitches) in API Explorer.

## Get Emergency Map Configuration Task

HTTP get `/restapi/v1.0/account/{accountId}/emergency-address-auto-update/tasks/{taskId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string taskId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).EmergencyAddressAutoUpdate().Tasks(taskId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Automatic-Location-Updates/readAutomaticLocationUpdatesTask) in API Explorer.

## Get Notification Settings

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).NotificationSettings().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/readNotificationSettings) in API Explorer.

## Update Notification Settings

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/notification-settings`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
NotificationSettingsUpdateRequest notificationSettingsUpdateRequest = new NotificationSettingsUpdateRequest {
    emailAddresses = new[] {
        "<ENTER VALUE>",
    },
    smsEmailAddresses = new[] {
        "<ENTER VALUE>",
    },
    advancedMode = true,
    voicemails = new VoicemailsInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        includeAttachment = true,
        markAsRead = true
    },
    inboundFaxes = new InboundFaxesInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        includeAttachment = true,
        markAsRead = true
    },
    outboundFaxes = new OutboundFaxesInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        }
    },
    inboundTexts = new InboundTextsInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
        }
    },
    missedCalls = new MissedCallsInfo {
        notifyByEmail = true,
        notifyBySms = true,
        advancedEmailAddresses = new[] {
            "<ENTER VALUE>",
        },
        advancedSmsEmailAddresses = new[] {
            "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).NotificationSettings().Put(notificationSettingsUpdateRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/updateNotificationSettings) in API Explorer.

## Get User Profile Image

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ProfileImage().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/readUserProfileImage) in API Explorer.

## Upload User Profile Image

HTTP post `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ProfileImage().Post(formData);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/createUserProfileImage) in API Explorer.

## Update User Profile Image

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string extensionId = "<ENTER VALUE>";
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ProfileImage().Put(formData);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/updateUserProfileImage) in API Explorer.

## Get Scaled User Profile Image

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/profile-image/{scaleSize}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";
string scaleSize = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).ProfileImage(scaleSize).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/readScaledPofileImage) in API Explorer.

## Get User Conferencing Settings

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadConferencingSettingsParameters readConferencingSettingsParameters = new ReadConferencingSettingsParameters {
    //countryId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Conferencing().Get(readConferencingSettingsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/readConferencingSettings) in API Explorer.

## Update User Conferencing Settings

HTTP put `/restapi/v1.0/account/{accountId}/extension/{extensionId}/conferencing`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// POST BODY
UpdateConferencingInfoRequest updateConferencingInfoRequest = new UpdateConferencingInfoRequest {
    phoneNumbers = new[] {
        new ConferencePhoneNumberInfo {
            phoneNumber = "<ENTER VALUE>",
            default = true
        },
    },
    allowJoinBeforeHost = true
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Conferencing().Put(updateConferencingInfoRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/User-Settings/updateConferencingSettings) in API Explorer.

## Get Account Info

HTTP get `/restapi/v1.0/account/{accountId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Company/readAccountInfo) in API Explorer.

## Get Account Business Address

HTTP get `/restapi/v1.0/account/{accountId}/business-address`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).BusinessAddress().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Company/readAccountBusinessAddress) in API Explorer.

## Update Company Business Address

HTTP put `/restapi/v1.0/account/{accountId}/business-address`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
ModifyAccountBusinessAddressRequest modifyAccountBusinessAddressRequest = new ModifyAccountBusinessAddressRequest {
    company = "<ENTER VALUE>",
    email = "<ENTER VALUE>",
    businessAddress = new BusinessAddressInfo {
        country = "<ENTER VALUE>",
        state = "<ENTER VALUE>",
        city = "<ENTER VALUE>",
        street = "<ENTER VALUE>",
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
var r = await rc.Restapi().Account(accountId).BusinessAddress().Put(modifyAccountBusinessAddressRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Company/updateAccountBusinessAddress) in API Explorer.

## Get Account Service Info

HTTP get `/restapi/v1.0/account/{accountId}/service-info`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).ServiceInfo().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Company/readAccountServiceInfo) in API Explorer.

## Get Language List

HTTP get `/restapi/v1.0/dictionary/language`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Restapi().Dictionary().Language().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/listLanguages) in API Explorer.

## Get Language

HTTP get `/restapi/v1.0/dictionary/language/{languageId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string languageId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Dictionary().Language(languageId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/readLanguage) in API Explorer.

## Get Country List

HTTP get `/restapi/v1.0/dictionary/country`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListCountriesParameters listCountriesParameters = new ListCountriesParameters {
    //loginAllowed = true,
    //signupAllowed = true,
    //numberSelling = true,
    //page = 1,
    //perPage = 100,
    //freeSoftphoneLine = true
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
var r = await rc.Restapi().Dictionary().Country().List(listCountriesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/listCountries) in API Explorer.

## Get Country

HTTP get `/restapi/v1.0/dictionary/country/{countryId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string countryId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Dictionary().Country(countryId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/readCountry) in API Explorer.

## Get Location List

HTTP get `/restapi/v1.0/dictionary/location`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListLocationsParameters listLocationsParameters = new ListLocationsParameters {
    //orderBy = 'City',
    //page = 1,
    //perPage = 100,
    //stateId = "<ENTER VALUE>",
    //withNxx = true
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
var r = await rc.Restapi().Dictionary().Location().Get(listLocationsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/listLocations) in API Explorer.

## Get States List

HTTP get `/restapi/v1.0/dictionary/state`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListStatesParameters listStatesParameters = new ListStatesParameters {
    //allCountries = true,
    //countryId = 000,
    //page = 1,
    //perPage = 100,
    //withPhoneNumbers = true
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
var r = await rc.Restapi().Dictionary().State().List(listStatesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/listStates) in API Explorer.

## Get State

HTTP get `/restapi/v1.0/dictionary/state/{stateId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string stateId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Dictionary().State(stateId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/readState) in API Explorer.

## Get Timezone List

HTTP get `/restapi/v1.0/dictionary/timezone`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ListTimezonesParameters listTimezonesParameters = new ListTimezonesParameters {
    //page = '1',
    //perPage = '100'
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
var r = await rc.Restapi().Dictionary().Timezone().List(listTimezonesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/listTimezones) in API Explorer.

## Get Timezone

HTTP get `/restapi/v1.0/dictionary/timezone/{timezoneId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string timezoneId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadTimezoneParameters readTimezoneParameters = new ReadTimezoneParameters {
    //page = '1',
    //perPage = '100'
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
var r = await rc.Restapi().Dictionary().Timezone(timezoneId).Get(readTimezoneParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Regional-Settings/readTimezone) in API Explorer.

## Get Company Phone Number List

HTTP get `/restapi/v1.0/account/{accountId}/phone-number`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListAccountPhoneNumbersParameters listAccountPhoneNumbersParameters = new ListAccountPhoneNumbersParameters {
    //page = 1,
    //perPage = 100,
    //usageType = new[] { "MainCompanyNumber", "AdditionalCompanyNumber", "CompanyNumber", "DirectNumber", "CompanyFaxNumber", "ForwardedNumber", "ForwardedCompanyNumber", "ContactCenterNumber", "ConferencingNumber", "MeetingsNumber" }
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
var r = await rc.Restapi().Account(accountId).PhoneNumber().List(listAccountPhoneNumbersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Phone-Numbers/listAccountPhoneNumbers) in API Explorer.

## Get Phone Number

HTTP get `/restapi/v1.0/account/{accountId}/phone-number/{phoneNumberId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string phoneNumberId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).PhoneNumber(phoneNumberId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Phone-Numbers/readAccountPhoneNumber) in API Explorer.

## Get Extension List

HTTP get `/restapi/v1.0/account/{accountId}/extension`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionsParameters listExtensionsParameters = new ListExtensionsParameters {
    //extensionId = "<ENTER VALUE>",
    //email = "<ENTER VALUE>",
    //page = 1,
    //perPage = 100,
    //status = new[] { "Enabled", "Disabled", "NotActivated", "Unassigned" },
    //type = new[] { "User", "FaxUser", "VirtualUser", "DigitalUser", "Department", "Announcement", "Voicemail", "SharedLinesGroup", "PagingOnly", "IvrMenu", "ApplicationExtension", "ParkLocation", "Limited", "Bot" }
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
var r = await rc.Restapi().Account(accountId).Extension().List(listExtensionsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Extensions/listExtensions) in API Explorer.

## Create Extension

HTTP post `/restapi/v1.0/account/{accountId}/extension`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
ExtensionCreationRequest extensionCreationRequest = new ExtensionCreationRequest {
    contact = new ContactInfoCreationRequest {
        firstName = "<ENTER VALUE>",
        lastName = "<ENTER VALUE>",
        company = "<ENTER VALUE>",
        jobTitle = "<ENTER VALUE>",
        email = "<ENTER VALUE>",
        businessPhone = "<ENTER VALUE>",
        mobilePhone = "<ENTER VALUE>",
        businessAddress = new ContactBusinessAddressInfo {
            country = "<ENTER VALUE>",
            state = "<ENTER VALUE>",
            city = "<ENTER VALUE>",
            street = "<ENTER VALUE>",
            zip = "<ENTER VALUE>"
        },
        emailAsLoginName = true,
        pronouncedName = new PronouncedNameInfo {
            type = 'Default',
            text = "<ENTER VALUE>"
        },
        department = "<ENTER VALUE>"
    },
    extensionNumber = "<ENTER VALUE>",
    password = "<ENTER VALUE>",
    references = new[] {
        new ReferenceInfo {
            ref = "<ENTER VALUE>",
            type = 'PartnerId'
        },
    },
    roles = new[] {
        new Roles {
            uri = "<ENTER VALUE>",
            id = "<ENTER VALUE>"
        },
    },
    regionalSettings = new RegionalSettings {
        homeCountry = new CountryInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            isoCode = "<ENTER VALUE>",
            callingCode = "<ENTER VALUE>"
        },
        timezone = new TimezoneInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            description = "<ENTER VALUE>"
        },
        language = new LanguageInfo {
            id = "<ENTER VALUE>",
            uri = "<ENTER VALUE>",
            greeting = true,
            formattingLocale = true,
            localeCode = "<ENTER VALUE>",
            name = "<ENTER VALUE>",
            ui = true
        },
        greetingLanguage = new GreetingLanguageInfo {
            id = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>",
            name = "<ENTER VALUE>"
        },
        formattingLocale = new FormattingLocaleInfo {
            id = "<ENTER VALUE>",
            localeCode = "<ENTER VALUE>",
            name = "<ENTER VALUE>"
        },
        timeFormat = '12h'
    },
    setupWizardState = 'NotStarted',
    status = 'Enabled',
    statusInfo = new ExtensionStatusInfo {
        comment = "<ENTER VALUE>",
        reason = 'Voluntarily'
    },
    type = 'User',
    hidden = true
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
var r = await rc.Restapi().Account(accountId).Extension().Post(extensionCreationRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Extensions/createExtension) in API Explorer.

## Get User Template List

HTTP get `/restapi/v1.0/account/{accountId}/templates`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListUserTemplatesParameters listUserTemplatesParameters = new ListUserTemplatesParameters {
    //type = 'UserSettings',
    //page = "<ENTER VALUE>",
    //perPage = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Templates().List(listUserTemplatesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Extensions/listUserTemplates) in API Explorer.

## Get User Template

HTTP get `/restapi/v1.0/account/{accountId}/templates/{templateId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string templateId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Templates(templateId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Extensions/readUserTemplate) in API Explorer.

## Get Call Queues

HTTP get `/restapi/v1.0/account/{accountId}/call-queues`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallQueuesParameters listCallQueuesParameters = new ListCallQueuesParameters {
    //page = 1,
    //perPage = 100,
    //memberExtensionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallQueues().Get(listCallQueuesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Queues/listCallQueues) in API Explorer.

## Get Call Queue Members

HTTP get `/restapi/v1.0/account/{accountId}/call-queues/{groupId}/members`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallQueueMembersParameters listCallQueueMembersParameters = new ListCallQueueMembersParameters {
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).CallQueues(groupId).Members().Get(listCallQueueMembersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Queues/listCallQueueMembers) in API Explorer.

## Assign Multiple Call Queue Members

HTTP post `/restapi/v1.0/account/{accountId}/call-queues/{groupId}/bulk-assign`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// POST BODY
CallQueueBulkAssignResource callQueueBulkAssignResource = new CallQueueBulkAssignResource {
    addedExtensionIds = new[] {
        "<ENTER VALUE>",
    },
    removedExtensionIds = new[] {
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
var r = await rc.Restapi().Account(accountId).CallQueues(groupId).BulkAssign().Post(callQueueBulkAssignResource);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Queues/assignMultipleCallQueueMembers) in API Explorer.

## Get Paging Group Users

HTTP get `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/users`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pagingOnlyGroupId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListPagingGroupUsersParameters listPagingGroupUsersParameters = new ListPagingGroupUsersParameters {
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Users().Get(listPagingGroupUsersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Paging-Only-Groups/listPagingGroupUsers) in API Explorer.

## Get Paging Group Devices

HTTP get `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/devices`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pagingOnlyGroupId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListPagingGroupDevicesParameters listPagingGroupDevicesParameters = new ListPagingGroupDevicesParameters {
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).Devices().Get(listPagingGroupDevicesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Paging-Only-Groups/listPagingGroupDevices) in API Explorer.

## Assign Paging Group Users and Devices

HTTP post `/restapi/v1.0/account/{accountId}/paging-only-groups/{pagingOnlyGroupId}/bulk-assign`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string pagingOnlyGroupId = "<ENTER VALUE>";

// POST BODY
EditPagingGroupRequest editPagingGroupRequest = new EditPagingGroupRequest {
    addedUserIds = new[] {
        "<ENTER VALUE>",
    },
    removedUserIds = new[] {
        "<ENTER VALUE>",
    },
    addedDeviceIds = new[] {
        "<ENTER VALUE>",
    },
    removedDeviceIds = new[] {
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
var r = await rc.Restapi().Account(accountId).PagingOnlyGroups(pagingOnlyGroupId).BulkAssign().Post(editPagingGroupRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Paging-Only-Groups/assignMultiplePagingGroupUsersDevices) in API Explorer.

## Create Call Monitoring Group

HTTP post `/restapi/v1.0/account/{accountId}/call-monitoring-groups`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest = new CreateCallMonitoringGroupRequest {
    id = "<ENTER VALUE>",
    name = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups().Post(createCallMonitoringGroupRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Monitoring-Groups/createCallMonitoringGroup) in API Explorer.

## Get Call Monitoring Groups List

HTTP get `/restapi/v1.0/account/{accountId}/call-monitoring-groups`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallMonitoringGroupsParameters listCallMonitoringGroupsParameters = new ListCallMonitoringGroupsParameters {
    //page = 1,
    //perPage = 100,
    //memberExtensionId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups().List(listCallMonitoringGroupsParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Monitoring-Groups/listCallMonitoringGroups) in API Explorer.

## Updates Call Monitoring Group

HTTP put `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// POST BODY
CreateCallMonitoringGroupRequest createCallMonitoringGroupRequest = new CreateCallMonitoringGroupRequest {
    id = "<ENTER VALUE>",
    name = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups(groupId).Put(createCallMonitoringGroupRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Monitoring-Groups/updateCallMonitoringGroup) in API Explorer.

## Delete Call Monitoring Group

HTTP delete `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups(groupId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Monitoring-Groups/deleteCallMonitoringGroup) in API Explorer.

## Get Call Monitoring Group Member List

HTTP get `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/members`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListCallMonitoringGroupMembersParameters listCallMonitoringGroupMembersParameters = new ListCallMonitoringGroupMembersParameters {
    //page = 1,
    //perPage = 100
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups(groupId).Members().Get(listCallMonitoringGroupMembersParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Monitoring-Groups/listCallMonitoringGroupMembers) in API Explorer.

## Update Call Monitoring Group List

HTTP post `/restapi/v1.0/account/{accountId}/call-monitoring-groups/{groupId}/bulk-assign`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string groupId = "<ENTER VALUE>";

// POST BODY
CallMonitoringBulkAssign callMonitoringBulkAssign = new CallMonitoringBulkAssign {
    updatedExtensions = new[] {
        new CallMonitoringExtensionUpdate {
            id = "<ENTER VALUE>",
            permissions = new[] {
                'Monitoring',
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
var r = await rc.Restapi().Account(accountId).CallMonitoringGroups(groupId).BulkAssign().Post(callMonitoringBulkAssign);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Monitoring-Groups/updateCallMonitoringGroupList) in API Explorer.

## Parse Phone Number

HTTP post `/restapi/v1.0/number-parser/parse`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
ParsePhoneNumberParameters parsePhoneNumberParameters = new ParsePhoneNumberParameters {
    //homeCountry = "<ENTER VALUE>",
    //nationalAsPriority = true
};

// POST BODY
ParsePhoneNumberRequest parsePhoneNumberRequest = new ParsePhoneNumberRequest {
    originalStrings = new[] {
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
var r = await rc.Restapi().NumberParser().Parse().Post(parsePhoneNumberRequest, parsePhoneNumberParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Phone-Numbers/parsePhoneNumber) in API Explorer.

## Get Device

HTTP get `/restapi/v1.0/account/{accountId}/device/{deviceId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string deviceId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadDeviceParameters readDeviceParameters = new ReadDeviceParameters {
    //syncEmergencyAddress = true
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
var r = await rc.Restapi().Account(accountId).Device(deviceId).Get(readDeviceParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Devices/readDevice) in API Explorer.

## Update Device

HTTP put `/restapi/v1.0/account/{accountId}/device/{deviceId}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/Devices/updateDevice) in API Explorer.

## Get Extension Device List

HTTP get `/restapi/v1.0/account/{accountId}/extension/{extensionId}/device`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string extensionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ListExtensionDevicesParameters listExtensionDevicesParameters = new ListExtensionDevicesParameters {
    //linePooling = 'Host',
    //feature = 'Intercom'
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
var r = await rc.Restapi().Account(accountId).Extension(extensionId).Device().Get(listExtensionDevicesParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Devices/listExtensionDevices) in API Explorer.

## Check Health

HTTP get `/scim/v2/health`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Scim().Health().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/checkHealth2) in API Explorer.

## Get Service Provider Config

HTTP get `/scim/v2/ServiceProviderConfig`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Scim().ServiceProviderConfig().Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/readServiceProviderConfig2) in API Explorer.

## Search/List Users

HTTP get `/scim/v2/Users`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
SearchViaGet2Parameters searchViaGet2Parameters = new SearchViaGet2Parameters {
    //filter = "<ENTER VALUE>",
    //startIndex = 1,
    //count = 100
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
var r = await rc.Scim().Users().List(searchViaGet2Parameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/searchViaGet2) in API Explorer.

## Create User

HTTP post `/scim/v2/Users`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

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
var r = await rc.Scim().Users().Post(user);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/createUser2) in API Explorer.

## Search/List Users

HTTP post `/scim/v2/Users/.search`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
SearchRequest searchRequest = new SearchRequest {
    count = 000,
    filter = "<ENTER VALUE>",
    schemas = new[] {
        'urn:ietf:params:scim:api:messages:2.0:SearchRequest',
    },
    startIndex = 000
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
var r = await rc.Scim().Users()..search().Post(searchRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/searchViaPost2) in API Explorer.

## Get User

HTTP get `/scim/v2/Users/{id}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string id = "<ENTER VALUE>";

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
var r = await rc.Scim().Users(id).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/readUser2) in API Explorer.

## Update/Replace User

HTTP put `/scim/v2/Users/{id}`

```cs
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
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/replaceUser2) in API Explorer.

## Delete User

HTTP delete `/scim/v2/Users/{id}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string id = "<ENTER VALUE>";

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
var r = await rc.Scim().Users(id).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/deleteUser2) in API Explorer.

## Update/Patch User

HTTP patch `/scim/v2/Users/{id}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string id = "<ENTER VALUE>";

// POST BODY
UserPatch userPatch = new UserPatch {
    Operations = new[] {
        new PatchOperation {
            op = 'add',
            path = "<ENTER VALUE>",
            value = "<ENTER VALUE>"
        },
    },
    schemas = new[] {
        'urn:ietf:params:scim:api:messages:2.0:PatchOp',
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
var r = await rc.Scim().Users(id).Patch(userPatch);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/SCIM/patchUser2) in API Explorer.

## Create CallOut Call Session

HTTP post `/restapi/v1.0/account/{accountId}/telephony/call-out`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
MakeCallOutRequest makeCallOutRequest = new MakeCallOutRequest {
    from = new MakeCallOutCallerInfoRequestFrom {
        deviceId = "<ENTER VALUE>"
    },
    to = new MakeCallOutCallerInfoRequestTo {
        phoneNumber = "<ENTER VALUE>",
        extensionNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().CallOut().Post(makeCallOutRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/createCallOutCallSession) in API Explorer.

## Get Call Session Status

HTTP get `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
ReadCallSessionStatusParameters readCallSessionStatusParameters = new ReadCallSessionStatusParameters {
    //timestamp = "<ENTER VALUE>",
    //timeout = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Get(readCallSessionStatusParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/readCallSessionStatus) in API Explorer.

## Drop Call Session

HTTP delete `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Delete();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/deleteCallSession) in API Explorer.

## Hold Call Party

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/hold`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Hold().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/holdCallParty) in API Explorer.

## Unhold Call Party

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/unhold`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Unhold().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/unholdCallParty) in API Explorer.

## Reject Call Party

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/reject`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Reject().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/rejectParty) in API Explorer.

## Transfer Call Party

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/transfer`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

// POST BODY
TransferTarget transferTarget = new TransferTarget {
    phoneNumber = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    voicemail = "<ENTER VALUE>",
    parkOrbit = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Transfer().Post(transferTarget);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/transferCallParty) in API Explorer.

## Forward Call Party

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/forward`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

// POST BODY
ForwardTarget forwardTarget = new ForwardTarget {
    phoneNumber = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>",
    voicemail = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Forward().Post(forwardTarget);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/forwardCallParty) in API Explorer.

## Call Flip on Party

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/flip`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

// POST BODY
CallPartyFlip callPartyFlip = new CallPartyFlip {
    callFlipId = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Flip().Post(callPartyFlip);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/callFlipParty) in API Explorer.

## Get Call Party Status

HTTP get `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/readCallPartyStatus) in API Explorer.

## Update Call Party

HTTP patch `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

// POST BODY
PartyUpdateRequest partyUpdateRequest = new PartyUpdateRequest {
    party = new PartyUpdateInfo {
        muted = true,
        standAlone = true
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Patch(partyUpdateRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/updateCallParty) in API Explorer.

## Create Recording

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings().Post();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/startCallRecording) in API Explorer.

## Pause/Resume Recording

HTTP patch `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/parties/{partyId}/recordings/{recordingId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";
string partyId = "<ENTER VALUE>";
string recordingId = "<ENTER VALUE>";

// OPTIONAL QUERY PARAMETERS
PauseResumeCallRecordingParameters pauseResumeCallRecordingParameters = new PauseResumeCallRecordingParameters {
    //brandId = '~'
};

// POST BODY
CallRecordingUpdate callRecordingUpdate = new CallRecordingUpdate {
    active = true
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Parties(partyId).Recordings(recordingId).Patch(callRecordingUpdate, pauseResumeCallRecordingParameters);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/pauseResumeCallRecording) in API Explorer.

## Supervise Call

HTTP post `/restapi/v1.0/account/{accountId}/telephony/sessions/{telephonySessionId}/supervise`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string telephonySessionId = "<ENTER VALUE>";

// POST BODY
SuperviseCallSessionRequest superviseCallSessionRequest = new SuperviseCallSessionRequest {
    mode = 'Listen',
    deviceId = "<ENTER VALUE>",
    extensionNumber = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).Telephony().Sessions(telephonySessionId).Supervise().Post(superviseCallSessionRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Call-Control/superviseCallSession) in API Explorer.

## Get Glip Data Archive

HTTP get `/restapi/v1.0/glip/data-export/{taskId}/archive/{archiveId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";
string archiveId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().DataExport(taskId).Archive(archiveId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Compliance-Exports/readComplianceArchive) in API Explorer.

## Create Data Export Task

HTTP post `/restapi/v1.0/glip/data-export`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// POST BODY
CreateDataExportTaskRequest createDataExportTaskRequest = new CreateDataExportTaskRequest {
    dateFrom = "<ENTER VALUE>",
    dateTo = "<ENTER VALUE>",
    userIds = new[] {
        "<ENTER VALUE>",
    },
    chatIds = new[] {
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
var r = await rc.Restapi().Glip().DataExport().Post(createDataExportTaskRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Compliance-Exports/createDataExportTask) in API Explorer.

## Get Data Export Task

HTTP get `/restapi/v1.0/glip/data-export/{taskId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string taskId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Glip().DataExport(taskId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Glip-Compliance-Exports/readDataExportTask) in API Explorer.

## Create Message Store Report

HTTP post `/restapi/v1.0/account/{accountId}/message-store-report`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";

// POST BODY
CreateMessageStoreReportRequest createMessageStoreReportRequest = new CreateMessageStoreReportRequest {
    dateFrom = "<ENTER VALUE>",
    dateTo = "<ENTER VALUE>"
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
var r = await rc.Restapi().Account(accountId).MessageStoreReport().Post(createMessageStoreReportRequest);
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Exports/createMessageStoreReport) in API Explorer.

## Get Message Store Report Task

HTTP get `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string taskId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).MessageStoreReport(taskId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Exports/readMessageStoreReportTask) in API Explorer.

## Get Message Store Report Archive

HTTP get `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string taskId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).MessageStoreReport(taskId).Archive().List();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Exports/readMessageStoreReportArchive) in API Explorer.

## Get Message Store Report Archive Content

HTTP get `/restapi/v1.0/account/{accountId}/message-store-report/{taskId}/archive/{archiveId}`

```cs
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
string accountId = "<ENTER VALUE>";
string taskId = "<ENTER VALUE>";
string archiveId = "<ENTER VALUE>";

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
var r = await rc.Restapi().Account(accountId).MessageStoreReport(taskId).Archive(archiveId).Get();
// PROCESS RESPONSE
```

[Try it out](https://developer.ringcentral.com/api-reference/Message-Exports/readMessageStoreReportArchiveContent) in API Explorer.

