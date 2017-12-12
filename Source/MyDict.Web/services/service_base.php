<?php
namespace Services;

abstract class Service {
    private $name = '';

    public function getName() { return $this->name;}
    public function setName($name) { $this->name = $name;}
    

    abstract function serv($request, $response);    
}

class ServiceManager {
    private $services = null;


    protected function checkCreateServices() {
        if(is_null($this->services)) {
            $this->services = array();
            $this->services['country'] = './country.svc.php';
            $this->services['user'] = './user.svc.php';
            $this->services['language'] = './language.svc.php';
            $this->services['class'] = './class.svc.php';
            $this->services['category'] = './category.svc.php';
            $this->services['dictionary'] = './dictionary.svc.php';
            $this->services['vocabulary'] = './vocabulary.svc.php';
        }
    }
    
    public function __construct() {
        $this->checkCreateServices();
    }

    private function __clone() {
        
    }

    public static function getInstance() {
        static $inst = null;
        if(null === $inst) {
            $inst = new ServiceManager();
        }

        return $inst;
    }

    public function addService($name, $svc) {
        $this->checkCreateServices();
        if(array_key_exists($name, $this->services)) {
            unset($this->services[$name]);
        }

        $this->services[$name] = $svc;
        return $svc;
    }

    public function getService($name) {
        if(! array_key_exists($name, $this->services))  {
            return null;
        }

        $svc = $this->services[$name];
        if(gettype($svc) == "string") {
            require_once($svc);
            $svc = $this->services[$name];
        }

        return $svc;
    }
}

?>