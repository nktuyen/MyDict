<?php
namespace MyDict\Services\DB;

require_once(INC.'db'.DS.'query.php');

class Connection {
    private $link = null;

    private function __clone() {

    }

    private function __construct() {
        $this->link = new \mysqli(DBHost, DBUser, DBPwd, DBName);
    }

    public static function getInstance() {
        static $instance = null;

        if(null === $instance) {
            $instance = new Connection();
        }

        return $instance;
    }


    public function createQuery($query) {
        return new Query($query, $this->link);
    }

    public function getLastError() {
        if($this->link) {
            return $this->link->error;
        }
        else {
            return 0;
        }
    }
}

$conn = Connection::getInstance();
?>