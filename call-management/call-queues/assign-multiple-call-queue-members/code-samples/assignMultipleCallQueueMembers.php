<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';
$groupId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'addedExtensionIds' => array(
        '<ENTER VALUE>'  
    ),
    'removedExtensionIds' => array(
        '<ENTER VALUE>'  
    )
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->post("/restapi/v1.0/account/{$accountId}/call-queues/{$groupId}/bulk-assign", $body);
// PROCESS RESPONSE
?>
