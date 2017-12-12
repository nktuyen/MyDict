<?php
namespace Processors;

require_once('http_processor.php');

class HttpPUTProcessor extends HttpProcessor {
    protected function __construct() {

    }

    private function __clone() {

    }

    public static function getInstance() {
        static $instance = null;
        if($instance === null) {
            $instance = new HttpPUTProcessor();
        }

        return $instance;
    }

    public function process($request) {
        var_dump($request);
    }
};
?>