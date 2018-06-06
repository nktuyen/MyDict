<?php
defined('__SIGNAL__') or die('Access restricted.');
?>

<?php
class CountryService extends Service {
    protected function __construct() {
        parent::__construct(ServiceType::svcDatabase, "language");
    }

    public static function getInstance() {
        if(null == self::$instance)
        self::$instance = new CountryService();
        
        return self::$instance;
    }

    protected function servGET() {
        if(!isset($_GET['query']))
            return HttpResponse::createInstance(HttpStatus400::getInstance());
        $query = $_GET['query'];

        if(null == $this->conn)
            return HttpResponse::createInstance(HttpStatus500::getInstance());

        if(null == $this->db)
            return HttpResponse::createInstance(HttpStatus500::getInstance());

        if(!$this->conn->isOpen())
            $this->conn->connect($this->db->HOST->getValue(), $this->db->USER->getValue(), $this->db->PASSWORD->getValue(), $this->db->NAME->getValue());

        if(null == $this->conn->getHandle())
            return HttpResponse::createInstance(HttpStatus500::getInstance());

        $cmd = $this->conn->createCommand($query);
        if(null == $cmd)
            return HttpResponse::createInstance(HttpStatus500::getInstance());

        $res = $cmd->execute();
        if(!$res->isValid())
            return HttpResponse::createInstance(HttpStatus500::getInstance());

        return Httpresponse::createInstance(HttpStatus200::getInstance(), $res->fetchAll());
    }

    protected function servPOST() {
        return HttpResponse::createInstance(HttpStatus200::getInstance());
    }
}

CountryService::getInstance();
?>