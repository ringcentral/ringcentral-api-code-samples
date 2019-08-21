<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';

// OPTIONAL QUERY PARAMETERS
$queryParams = array(
    //'type' => 'User',
    //'searchString' => '<ENTER VALUE>',
    //'department' => '<ENTER VALUE>',
    //'siteId' => '<ENTER VALUE>',
    //'featureEnabled' => true,
    //'orderBy' => 'name',
    //'perPage' => 000,
    //'page' => 1
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->get("/restapi/v1.0/account/{$accountId}/emergency-address-auto-update/users", $queryParams);
// PROCESS RESPONSE
?>
