<?php
define("DS", DIRECTORY_SEPARATOR);
define("ROOT", $_SERVER['DOCUMENT_ROOT'].DS);
require_once(ROOT."configure.php");

$method = $_SERVER['REQUEST_METHOD'];

if(strcmp(strtoupper($method), GET_METHOD) == 0) {
    require_once(strtolower($method).'.php');
}
else if(strcmp(strtoupper($method), POST_METHOD) == 0) {
    if(array_key_exists('method', $_SERVER)) {
        $method = $_POST['method'];
        if(strcmp(strtoupper($method), PUT_METHOD) == 0) {
            global $_PUT;
            $_PUT = $_POST;
            require_once(strtolower($method).'.php');
        }
        else if(strcmp(strtoupper($method), DELETE_METHOD) == 0) {
            global $_DELETE;
            $_DELETE = $_POST;
            require_once(strtolower($method).'.php');
        }
        else {
            $method = POST_METHOD;
            require_once(strtolower($method).'.php');
        }
    }
    else {
        $method = POST_METHOD;
        require_once(strtolower($method).'.php');
    }
}
else {
    die('{status:405, data:"Method Not Allowed"}');
}

?>