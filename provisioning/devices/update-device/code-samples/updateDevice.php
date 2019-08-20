<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$deviceId = '<ENTER VALUE>';
$accountId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'emergencyServiceAddress' => array(
        'street' => '<ENTER VALUE>',
        'street2' => '<ENTER VALUE>',
        'city' => '<ENTER VALUE>',
        'zip' => '<ENTER VALUE>',
        'customerName' => '<ENTER VALUE>',
        'state' => '<ENTER VALUE>',
        'stateId' => '<ENTER VALUE>',
        'stateIsoCode' => '<ENTER VALUE>',
        'stateName' => '<ENTER VALUE>',
        'countryId' => '<ENTER VALUE>',
        'countryIsoCode' => '<ENTER VALUE>',
        'country' => '<ENTER VALUE>',
        'countryName' => '<ENTER VALUE>'
    ),
    'extension' => array(
        'id' => '<ENTER VALUE>'
    ),
    'phoneLines' => array(
        'phoneLines' => array(
            array(
                'id' => '<ENTER VALUE>'
            )  
        )
    ),
    'useAsCommonPhone' => true
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->put("/restapi/v1.0/account/{$accountId}/device/{$deviceId}", $body);
// PROCESS RESPONSE
?>
