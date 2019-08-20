<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';

// OPTIONAL QUERY PARAMETERS
$queryParams = array(
    //'syncType' => 'FSync',
    //'syncToken' => '<ENTER VALUE>',
    //'dateFrom' => '<ENTER VALUE>',
    //'recordCount' => 000,
    //'statusGroup' => 'Missed',
    //'view' => 'Simple',
    //'showDeleted' => true
)

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->get("/restapi/v1.0/account/{$accountId}/call-log-sync", $queryParams);
// PROCESS RESPONSE
?>
