<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';
$extensionId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'from' => array(
        'phoneNumber' => '<ENTER VALUE>',
        'forwardingNumberId' => '<ENTER VALUE>'
    ),
    'to' => array(
        'phoneNumber' => '<ENTER VALUE>'
    ),
    'callerId' => array(
        'phoneNumber' => '<ENTER VALUE>'
    ),
    'playPrompt' => true,
    'country' => array(
        'id' => '<ENTER VALUE>'
    )
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->post("/restapi/v1.0/account/{$accountId}/extension/{$extensionId}/ring-out", $body);
// PROCESS RESPONSE
?>
