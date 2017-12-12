<?php


    define('__MAGIC__', 'MyDict');

    set_include_path('.');
    require_once('configure.php');
    require_once('post_processor.php');
    require_once('get_processor.php');
    require_once('put_processor.php');
    require_once('delete_processor.php');
    
    use Processors\HttpPOSTProcessor;
    use Processors\HttpGETProcessor;
    use Processors\HttpPUTProcessor;
    use Processors\HttpDELETEProcessor;
    
    $method = $_SERVER['REQUEST_METHOD'];
    $processor = null;
    $params = '';
    if($method === 'POST') {
        $processor = Processors\HttpPOSTProcessor::getInstance();
        $params = $_POST;
    }
    else if($method === 'GET') {
        $processor = Processors\HttpGETProcessor::getInstance();
        $params = $_GET;
    }
    else if($method === 'PUT') {
        $processor = Processors\HttpPUTProcessor::getInstance();
    }
    else if($method === 'DELETE') {
        $processor = Processors\HttpDELETEProcessor::getInstance();
    }

    if($processor) {
        $processor->process($params);
    }
?>