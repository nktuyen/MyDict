<?php
namespace Processors;

use Authentication\Authenticator;
use Services\ServiceManager;


require_once('configure.php');
require_once('http_processor.php');
require_once('authentication.php');

class HttpGETProcessor extends HttpProcessor {
    protected function __construct() {
        
    }

    private function __clone() {

    }

    public static function getInstance() {
        static $instance = null;
        if($instance === null) {
            $instance = new HttpGETProcessor();
        }

        return $instance;
    }

    public function process($request) {
        $authenticator = Authenticator::getInstance();
        $response = new HttpResponse();
        
        if($authenticator) {
            $user = $request[USER_KEY];
            $pwd = $request[PWD_KEY];
            $svc = $request[SVC_KEY];
            if( (is_null($user)) || (is_null($pwd)) ) {
                $response->status = HttpStatus::NotFound;
                $response->write();
                return;
            }
            else {
                if($authenticator->validate($user, $pwd)) {
                    $serviceManager = ServiceManager::getInstance();
                    $service = null;
                    if(!is_null(serviceManager)) {
                        $service = $serviceManager->getService($svc);
                    }
                    if(is_null($service)) {
                        $response->status = \HttpStatus::ServiceUnavailable;
                        $response->write();
                        return;    
                    }
                    else {
                        unset( $request[USER_KEY] );
                        unset( $request[PWD_KEY] );
                        unset( $request[SVC_KEY] );
                        $request[CMD_KEY] = \HttpCommand::GET;
                        $service->serv($request, $response);
                    }
                }
                else {
                    $response->status = \HttpStatus::Unauthorized;
                    $response->write();
                    return;
                }
            }
        }
        else {
            $response->status = \HttpStatus::InternalServerError;
            $response->write();
            return;
        }
    }
};
?>