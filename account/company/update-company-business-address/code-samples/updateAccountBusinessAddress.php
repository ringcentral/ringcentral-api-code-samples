<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'company' => '<ENTER VALUE>',
    'email' => '<ENTER VALUE>',
    'businessAddress' => array(
        'country' => '<ENTER VALUE>',
        'state' => '<ENTER VALUE>',
        'city' => '<ENTER VALUE>',
        'street' => '<ENTER VALUE>',
        'zip' => '<ENTER VALUE>'
    )
)

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->put("/restapi/v1.0/account/{$accountId}/business-address", $body);
?>