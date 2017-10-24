<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class Float extends datatype{
    private $d = 0;
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function Float(){
        parent::setName('FLOAT');
        parent::setID(typeid::FLOAT);
    }
}

?>