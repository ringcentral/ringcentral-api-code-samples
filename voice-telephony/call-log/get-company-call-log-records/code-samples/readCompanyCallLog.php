<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';

// OPTIONAL QUERY PARAMETERS
$queryParams = array(
    //'extensionNumber' => '<ENTER VALUE>',
    //'phoneNumber' => '<ENTER VALUE>',
    //'direction' => array( 'Inbound', 'Outbound' ),
    //'type' => array( 'Voice', 'Fax' ),
    //'view' => 'Simple',
    //'withRecording' => true,
    //'recordingType' => 'Automatic',
    //'dateFrom' => '<ENTER VALUE>',
    //'dateTo' => '<ENTER VALUE>',
    //'page' => 1,
    //'perPage' => 100,
    //'sessionId' => '<ENTER VALUE>'
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->get("/restapi/v1.0/account/{$accountId}/call-log", $queryParams);
// PROCESS RESPONSE
?>
