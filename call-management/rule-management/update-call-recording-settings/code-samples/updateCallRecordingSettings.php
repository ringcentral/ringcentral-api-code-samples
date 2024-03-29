<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'onDemand' => array(
        'enabled' => true
    ),
    'automatic' => array(
        'enabled' => true,
        'outboundCallTones' => true,
        'outboundCallAnnouncement' => true,
        'allowMute' => true,
        'extensionCount' => 000
    ),
    'greetings' => array(
        array(
            'type' => 'StartRecording',
            'mode' => 'Default'
        )  
    )
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->put("/restapi/v1.0/account/{$accountId}/call-recording", $body);
// PROCESS RESPONSE
?>
