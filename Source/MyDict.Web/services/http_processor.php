<?php
namespace Processors;

require_once('service_base.php');

abstract class HttpProcessor {
    abstract function process($request) ;
};

class HttpResponse {
    public $status = 200;
    public $data = null;

    public function write() {
        echo(json_encode($this));
    }
}
?>