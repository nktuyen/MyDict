<?php
namespace Services;

abstract class Service {
    private $name = '';

    public function getName() { return $this->name;}
    public function setName($name) { $this->name = $name;}
    
    abstract function serv($request);
}

class ServiceManager {
    private $services = null;


    private function checkCreateServices() {
        echo __CLASS__.'::'.__FUNCTION__.'()\n';
        if(null === $this->services) {
            $this->services = array();
            $this->services['country'] = './country.svc.php';
            $this->services['user'] = './user.svc.php';
        }
    }
    
    public function __constructor($n) {
        $this->name = $n;
        checkCreateServices();
    }

    private function __clone() {
        
    }
    private function ServiceManager($n) {
        $this->name = $n;
        $this->checkCreateServices();
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
        if(array_key_exists($name)) {
            return false;
        }

        $this->services[$name] = $svc;
        return $svc;
    }

    public function getService($name) {
        $this->checkCreateServices();
        echo __CLASS__.'::'.__FUNCTION__.'('.$name.')\n';
        if(! array_key_exists($name, $this->services))  {
            return null;
        }
        
        $svc = $this->services[$name];
        if(gettype($svc) === "string") {
            echo "require_once($svc);\n";
            require_once($svc);
            if(array_key_exists($name)) {
                echo 'return $this->services[$anme];';
                return $this->services[$anme];
            }
            else {
                echo 'return null;';
                return null;
            }
        }
        else {
            return $svc;
        }
    }
}

?>