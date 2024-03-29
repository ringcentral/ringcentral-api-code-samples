# https://developers.ringcentral.com/my-account.html#/applications
# Find your credentials at the above url, set them as environment variables, or enter them below

# POST BODY
body = {
    'public': true,
    'name': '<ENTER VALUE>',
    'description': '<ENTER VALUE>',
    'members': [
        {
            'id': '<ENTER VALUE>',
            'email': '<ENTER VALUE>'
        }
    ]
}

import os
from ringcentral import SDK
rcsdk = SDK(os.environ['clientId'], os.environ['clientSecret'], os.environ['serverURL'])
platform = rcsdk.platform()
platform.login(os.environ['username'], os.environ['extension'], os.environ['password'])
r = platform.post('/restapi/v1.0/glip/teams', body)
# PROCESS RESPONSE