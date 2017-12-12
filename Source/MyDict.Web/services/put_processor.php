<?php

require_once('./http_processor.php');

class HttpPUTProcessor extends HttpProcessor {
    protected function __constructor() {

    }

    private function __clone() {

    }

    private function HttpPUTProcessor() {

    }

    public static function getInstance() {
        static $instance = null;
        if($instance === null) {
            $instance = new HttpPUTProcessor();
        }

        return $instance;
    }

    public function process($request) {
        echo __CLASS__.'::'.__FUNCTION__."()\n";
    }
};
?>