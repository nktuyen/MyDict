<?php
namespace Processors;

require_once('http_processor.php');

class HttpPOSTProcessor extends HttpProcessor {
    protected function __construct() {

    }

    private function __clone() {

    }

    public static function getInstance() {
        static $instance = null;
        if($instance === null) {
            $instance = new HttpPOSTProcessor();
        }

        return $instance;
    }

    public function process($request) {
        var_dump($request);
    }
};
?>