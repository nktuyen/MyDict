<?php
define('__SIGNAL__', 1);
define('__DEBUG__', true);
?>

<?php
require_once('..\inc\configure.php');
require_once('..\inc\httpstatus.php');
require_once('..\inc\database.php');
require_once('..\inc\service.php');
require_once('..\inc\authenticate.php');
?>

<?php
    if(!isset($_SERVER['REQUEST_METHOD'])) {
        die(HttpResponse::createInstance((HttpStatus400::getInstance()))->toJSON());
    }
    $method = $_SERVER['REQUEST_METHOD'];
    $service = "";
    $user = "";
    $pwd = "";
    if($method == "POST") {
        if(isset($_POST['__s__']))
            $service = $_POST['__s__'];

        if(isset($_POST['__u__']))
            $user = $_POST['__u__'];

        if(isset($_POST['__p__']))
            $pwd = $_POST['__p__'];
    }
    else if($method == "GET") {
        if(isset($_GET['__s__']))
            $service = $_GET['__s__'];

        if(isset($_GET['__u__']))
            $user = $_GET['__u__'];

        if(isset($_GET['__p__']))
            $pwd = $_GET['__p__'];
    }
    else {
        die(HttpResponse::createInstance((HttpStatus405::getInstance()))->toJSON());
    }
    if("" == $service) {
        die(HttpResponse::createInstance((HttpStatus400::getInstance()))->toJSON());
    }

    $_CONFIG = SystemSetting::getInstance();

    $auth = Authenticator::authen($_CONFIG, $service, $user, $pwd);
    if(AuthenticationResult::authSuccess != $auth) {
        die(HttpResponse::createInstance((HttpStatus401::getInstance()))->toJSON());
    }

    file_exists($service.'.svc.php') or die(HttpResponse::createInstance((HttpStatus503::getInstance()))->toJSON());
    require_once($service.'.svc.php');
    
    
    $_DB = $_CONFIG->DB;
    $_CONN = MySql\Connection::getInstance();
    $_SVC = Service::getInstance();

    if($_SVC->getKind() == ServiceType::svcDatabase)
        $_SVC->initialize($_CONN, $_DB);
    else
        $_SVC->initialize(null, null);
        
    $_RESP = $_SVC->serv();
    echo $_RESP->toJSON();
?>