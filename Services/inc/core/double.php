<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class Double extends datatype{
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function Double(){
        parent::setName('DOUBLE');
        parent::setID(typeid::DOUBLE);
    }
}

?>