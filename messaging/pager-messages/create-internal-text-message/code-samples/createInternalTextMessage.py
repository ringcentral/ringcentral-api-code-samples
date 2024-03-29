# https://developers.ringcentral.com/my-account.html#/applications
# Find your credentials at the above url, set them as environment variables, or enter them below

# PATH PARAMETERS
accountId = '<ENTER VALUE>'
extensionId = '<ENTER VALUE>'

# POST BODY
body = {
    'from': {
        'extensionId': '<ENTER VALUE>'
    },
    'replyOn': 000,
    'text': '<ENTER VALUE>',
    'to': [
        {
            'extensionId': '<ENTER VALUE>'
        }
    ]
}

import os
from ringcentral import SDK
rcsdk = SDK(os.environ['clientId'], os.environ['clientSecret'], os.environ['serverURL'])
platform = rcsdk.platform()
platform.login(os.environ['username'], os.environ['extension'], os.environ['password'])
r = platform.post(f'/restapi/v1.0/account/{accountId}/extension/{extensionId}/company-pager', body)
# PROCESS RESPONSE