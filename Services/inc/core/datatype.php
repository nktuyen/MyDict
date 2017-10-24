<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './object.php';

abstract class typeid{
    const NONE = 0;
    const VARCHAR = 1;
    const TINYTEXT = 2;
    const TEXT = 3;
    const MEDIUMTEXT = 4;
    const LONGTEXT = 5;
    const TINYINT = 6;
    const SMALLINT = 7;
    const MEDIUMINT = 8;
    const INTEGER = 9;
    const BIGINT = 10;
    const FLOAT = 11;
    const DOUBLE = 12;
    const DECIMAL = 13;
}

abstract class datatype extends object{
    private $id = '';
    
    public function getID(){
        return $this->id;
    }
    
    protected function setID($new_id){
        $this->id = $new_id;
    }
    
    private function __construct() {
        
    }
    
    private function __clone() {
        
    }
   
}

?>