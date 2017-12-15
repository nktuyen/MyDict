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
global $_PUT;

if(! array_key_exists(TOKEN_KEY, $_PUT) ){
    $_RESPONSE->error(HttpStatusCode::Unauthorized);
}

$token = $_PUT[TOKEN_KEY];
if(strcmp($token, HTTP_TOKEN) != 0) {
    $_RESPONSE->error(HttpStatusCode::Unauthorized);
}

if( (! array_key_exists("name", $_PUT)) || (! array_key_exists("title", $_PUT))) {
    $_RESPONSE->error(HttpStatusCode::BadRequest);
}

$language_name = $_PUT['name'];
$conn = Connection::getInstance();
$query = $conn->createQuery("SELECT * FROM tbl_language WHERE UPPER(name)='". strtoupper($language_name)."'");
$result = $query->execute();
if($result->getRowCount() > 0) {
    $_RESPONSE->error(HttpStatusCode::Conflict);
}

$language_title = $_PUT['title'];
$query = $conn->createQuery("INSERT INTO tbl_language(name,title) VALUES('".$language_name."','".$language_title."')");
$result = $query->execute();
if($result->getArray()) {
    $_RESPONSE->OK();
}

else {
    $_RESPONSE->error(HttpStatusCode::InternalServerError);
}
?>