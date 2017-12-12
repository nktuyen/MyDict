<?php
    define('__MAGIC__', 'MyDict');

    require_once('./configure.php');
    require_once('./country.php');
    require_once('./post_processor.php');
    require_once('./get_processor.php');
    require_once('./put_processor.php');
    require_once('./delete_processor.php');

    $method = $_SERVER['REQUEST_METHOD'];
    $processor = null;
    $params = '';
    if($method === 'POST') {
        $processor = HttpPOSTProcessor::getInstance();
        $params = $_POST;
    }
    else if($method === 'GET') {
        $processor = HttpGETProcessor::getInstance();
        $params = $_GET;
    }
    else if($method === 'PUT') {
        $processor = HttpPUTProcessor::getInstance();
    }
    else if($method === 'DELETE') {
        $processor = HttpDELETEProcessor::getInstance();
    }

    if($processor) {
        $processor->process($params);
    }
?>