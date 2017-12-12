<?php

require_once('./configure.php');
require_once('./http_processor.php');
require_once('./authentication.php');

use System\Authenticator;
use Services\ServiceManager;

class HttpGETProcessor extends HttpProcessor {
    protected function __constructor() {

    }

    private function __clone() {

    }

    private function HttpGETProcessor() {

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
                parent::writeJSON($response);
                return;
            }
            else {
                if($authenticator->authenticate($user, $pwd)) {
                    $service = Services\ServiceManager::getInstance()->getService($svc);
                    
                    echo "service=$service";
                }
                else {
                    $response->status = HttpStatus::NotFound;
                    parent::writeJSON($response);
                    return;
                }
            }
        }
        else {
            $response->status = HttpStatus::NotFound;
            parent::writeJSON($response);
            return;
        }
    }
};
?>