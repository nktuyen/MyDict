<?php

require_once('./http_processor.php');

class HttpPOSTProcessor extends HttpProcessor {
    protected function __constructor() {

    }

    private function __clone() {

    }

    private function HttpPOSTProcessor() {

    }

    public static function getInstance() {
        static $instance = null;
        if($instance === null) {
            $instance = new HttpPOSTProcessor();
        }

        return $instance;
    }

    public function process($request) {
        echo __CLASS__.'::'.__FUNCTION__."()\n";
        var_dump($request);
    }
};
?>