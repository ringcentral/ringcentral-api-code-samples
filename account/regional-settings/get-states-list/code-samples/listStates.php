<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// OPTIONAL QUERY PARAMETERS
$queryParams = array(
    //'allCountries' => true,
    //'countryId' => 000,
    //'page' => 1,
    //'perPage' => 100,
    //'withPhoneNumbers' => true
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->get("/restapi/v1.0/dictionary/state", $queryParams);
// PROCESS RESPONSE
?>
