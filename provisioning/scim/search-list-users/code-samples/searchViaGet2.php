<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
$queryParams = array(
    //'filter' => '<ENTER VALUE>',
    //'startIndex' => 1,
    //'count' => 100
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->get("/scim/v2/Users", $queryParams);
// PROCESS RESPONSE
?>
