# https://developers.ringcentral.com/my-account.html#/applications
# Find your credentials at the above url, set them as environment variables, or enter them below

# PATH PARAMETERS
deviceId = '<ENTER VALUE>'
accountId = '<ENTER VALUE>'

# POST BODY
body = {
    'emergencyServiceAddress': {
        'street': '<ENTER VALUE>',
        'street2': '<ENTER VALUE>',
        'city': '<ENTER VALUE>',
        'zip': '<ENTER VALUE>',
        'customerName': '<ENTER VALUE>',
        'state': '<ENTER VALUE>',
        'stateId': '<ENTER VALUE>',
        'stateIsoCode': '<ENTER VALUE>',
        'stateName': '<ENTER VALUE>',
        'countryId': '<ENTER VALUE>',
        'countryIsoCode': '<ENTER VALUE>',
        'country': '<ENTER VALUE>',
        'countryName': '<ENTER VALUE>'
    },
    'extension': {
        'id': '<ENTER VALUE>'
    },
    'phoneLines': {
        'phoneLines': [
            {
                'id': '<ENTER VALUE>'
            }
        ]
    },
    'useAsCommonPhone': true
}

import os
from ringcentral import SDK
rcsdk = SDK(os.environ['clientId'], os.environ['clientSecret'], os.environ['serverURL'])
platform = rcsdk.platform()
platform.login(os.environ['username'], os.environ['extension'], os.environ['password'])
r = platform.put(f'/restapi/v1.0/account/{accountId}/device/{deviceId}', body)
# PROCESS RESPONSE