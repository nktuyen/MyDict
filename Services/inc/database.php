<?php
namespace MyDict;

defined('__MAGIC__') or exit();

require_once './core/database.php';
require_once './core/connection.php';

class Database extends \MySQL\Database {
    private static $instance = null;
    private $conn = null;


    private function __construct() {
        
    }
    
    private function __clone() {
        
    }
    
    private function Database($name, $desc) {
        parent::Database($name, $desc);
    }
    
    public static function getInstance() {
        if(null === self::$instance){
            self::$instance = new Database(DB::NAME, DB::DESC);
        }
        
        return self::$instance;
    }
    
    public function close() {
        if(!is_null($this->conn)) {
            $this->conn->close();
        }
    }
    
    public function isOpen() {
        if(null !== $this->conn)
            return true;
        else
            return false;
    }

    public function open() {
        if(null === $this->conn) {
            $this->conn = new \MySQL\Connection(DB::HOST, DB::USER, DB::PWD, DB::NAME);
        }
    }
}

$g_Database = \MyDict\Database::getInstance();

?>