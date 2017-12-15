<?php
namespace MyDict\Services;
use MyDict\Services\Http\HttpStatusCode;
use MyDict\Services\Http\Response;

define("__MAGIC__", 1);
require_once("../configure.php");
require_once(INC.'response.php');

global $_RESPONSE;
$_RESPONSE = new Response(500);
$method = $_SERVER['REQUEST_METHOD'];

if(strcmp(strtoupper($method), GET_METHOD) == 0) {
    require_once(strtolower($method).'.php');
}
else if(strcmp(strtoupper($method), POST_METHOD) == 0) {
    if(array_key_exists('method', $_POST)) {
        $sub_method = $_POST['method'];
        if(strcmp(strtoupper($sub_method), PUT_METHOD) == 0) {
            global $_PUT;
            $_PUT = $_POST;
            require_once(strtolower($sub_method).'.php');
        }
        else if(strcmp(strtoupper($sub_method), DELETE_METHOD) == 0) {
            global $_DELETE;
            $_DELETE = $_POST;
            require_once(strtolower($sub_method).'.php');
        }
        else {
            $sub_method = POST_METHOD;
            require_once(strtolower($sub_method).'.php');
        }
    }
    else {
        $sub_method = POST_METHOD;
        require_once(strtolower($sub_method).'.php');
    }
}
else {
    $_RESPONSE->error(HttpStatusCode::MethodNotAllowed);
}

?>