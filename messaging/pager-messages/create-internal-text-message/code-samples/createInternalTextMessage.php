<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';
$extensionId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'from' => array(
        'extensionId' => '<ENTER VALUE>'
    ),
    'replyOn' => 000,
    'text' => '<ENTER VALUE>',
    'to' => array(
        array(
            'extensionId' => '<ENTER VALUE>'
        )  
    )
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->post("/restapi/v1.0/account/{$accountId}/extension/{$extensionId}/company-pager", $body);
// PROCESS RESPONSE
?>
