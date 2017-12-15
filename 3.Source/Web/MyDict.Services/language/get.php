<?php
namespace MyDict\Services;

require_once(INC.'db'.DS.'helper.php');
require_once('language.php');

use MyDict\Services\Http\Response;
use MyDict\Services\Http\HttpStatusCode;
use MyDict\Services\Entity;
use MyDict\Services\DB\Connection;
use MyDict\Services\DB\Query;
use MyDict\Services\DB\Result;

defined("__MAGIC__") or die();


global $_RESPONSE;

if(! array_key_exists(TOKEN_KEY, $_GET) ){
    $_RESPONSE->error(HttpStatusCode::Unauthorized);
}

$token = $_GET[TOKEN_KEY];
if(strcmp($token, HTTP_TOKEN) != 0) {
    $_RESPONSE->error(HttpStatusCode::Unauthorized);
}

if (! array_key_exists("fields", $_GET))  {
    $_RESPONSE->error(HttpStatusCode::BadRequest);
}

$get_fields = $_GET['fields'];
$where = " 1";
if(array_key_exists("where", $_GET)) {
    $where = $_GET['where'];
}

$conn = Connection::getInstance();
$query = $conn->createQuery("SELECT ".$get_fields." FROM tbl_language WHERE ".$where);
$result = $query->execute();

if($result->getArray()) {
    $_RESPONSE->data = $result->getArray();
    $_RESPONSE->OK();
}

else {
    $_RESPONSE->error(HttpStatusCode::InternalServerError);
}
?>