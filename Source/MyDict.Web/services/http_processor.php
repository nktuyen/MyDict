<?php

require_once('./service_base.php');

abstract class HttpProcessor {
    abstract function process($request) ;

    public function writeJSON($json) {
        header('Content-type : application/json');
        echo(json_encode($json));
    }

    public function writeHtml($html) {
        header('Content-type: application/html');
        echo $html;
    }
};

class HttpResponse {
    public $status = 200;
    public $data = null;    
}

?>