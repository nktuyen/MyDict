<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class MediumText extends datatype{
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function MediumText(){
        parent::setName('MEDIUMTEXT');
        parent::setID(typeid::MEDIUMTEXT);
    }
}

?>