<?php
// https://developers.ringcentral.com/my-account.html#/applications
// Find your credentials at the above url, set them as environment variables, or enter them below

// PATH PARAMETERS
$accountId = '<ENTER VALUE>';

// POST BODY
$body = array(
    'searchString' => '<ENTER VALUE>',
    'showFederated' => true,
    'extensionType' => 'User',
    'orderBy' => array(
        array(
            'index' => 000,
            'fieldName' => 'firstName',
            'direction' => 'Asc'
        )  
    ),
    'page' => 000,
    'perPage' => 000
);

require('vendor/autoload.php');
$rcsdk = new RingCentral\SDK\SDK(getenv('clientId'), getenv('clientSecret'), getenv('serverURL'));
$platform = $rcsdk->platform();
$platform->login(getenv('username'), getenv('extension'), getenv('password'));
$r = $platform->post("/restapi/v1.0/account/{$accountId}/directory/entries/search", $body);
// PROCESS RESPONSE
?>
