<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './object.php';

class Connection extends Object{
    private $host = '';
    private $port = 0;
    private $user = '';
    private $pwd = '';
    private $db = '';
    private $link = null;

    private function __construct() {
        
    }
    private function __clone() {
        
    }

    
    public function Connection($host,$user,$pwd,$db=null,$port=null){
        $this->host = $host;
        $this->user = $user;
        $this->port = $port;
        $this->pwd = $pwd;
        $this->db = $db;
        
        $this->link = new \mysqli($this->host, $this->user, $this->pwd, $this->db);
    }
    
    public function close() {
        if(!is_null($this->link)) {
            $this->link->close();
        }
    }
}

?>