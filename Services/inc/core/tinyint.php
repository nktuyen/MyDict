<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './integer.php';

class TinyInt extends Integer{
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function TinyInt($unsigned = false){
        parent::setName('TINYINT');
        parent::setID(typeid::TINYINT);
        parent::setUnsigned($unsigned);
    }
}

?>