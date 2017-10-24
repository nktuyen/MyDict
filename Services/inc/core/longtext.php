<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class LongText extends datatype{
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function LongText(){
        parent::setName('LONGTEXT');
        parent::setID(typeid::LONGTEXT);
    }
}

?>