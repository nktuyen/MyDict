<?php

require_once('./http_processor.php');

class HttpDELETEProcessor extends HttpProcessor {
    protected function __constructor() {

    }

    private function __clone() {

    }

    private function HttpDELETEProcessor() {

    }

    public static function getInstance() {
        static $instance = null;
        if($instance === null) {
            $instance = new HttpDELETEProcessor();
        }

        return $instance;
    }

    public function process($request) {
        echo __CLASS__.'::'.__FUNCTION__."()\n";
    }
};
?>