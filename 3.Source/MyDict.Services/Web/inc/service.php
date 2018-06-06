<?php
defined('__SIGNAL__') or die('Access restricted.');
?>

<?php
abstract class ServiceType {
    const svcUnknown = 0;
    const svcUtil = 1;
    const svcDatabase = 2;
    const svcStream = 3;
}

class Service {
    protected $name = "";
    protected $kind = ServiceType::svcUnknown;
    protected $conn = null;
    protected $db = null;
    protected static $instance = null;

    public function getName() { return $this->name;}
    public function getKind() { return $this->kind;}
    protected function __construct($kind, $name = "") {
        $this->kind = $kind;
        $this->name = $name;
    }

    public static function getInstance() {
        return self::$instance;
    }

    public function initialize($connection, $database) {
        $this->conn = $connection;
        $this->db = $database;

        return true;
    }

    protected  function servGET() {
        return HttpResponse::create(HttpStatus405::getInstance());
    }

    protected  function servPOST() {
        return HttpResponse::create(HttpStatus405::getInstance());
    }

    final public function serv() {
        if(!isset($_SERVER))
            return HttpResponse::create(HttpStatus500::getInstance());

        if(!isset($_SERVER['REQUEST_METHOD']))
            return HttpResponse::create(HttpStatus400::getInstance());

        $method = $_SERVER['REQUEST_METHOD'];
        if($method == "POST")
            return $this->servPOST();
        else if($method == "GET")
            return $this->servGET();
        else
            return HttpResponse::create(HttpStatus400::getInstance()); 
    }
}

?>