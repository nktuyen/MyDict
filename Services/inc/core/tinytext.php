<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class TinyText extends datatype{
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function TinyText(){
        parent::setName('TINYTEXT');
        parent::setID(typeid::TINYTEXT);
    }
}

?>