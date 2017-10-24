<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './integer.php';

class BigInt extends Integer{
    private function __construct() {
        
    }
    private function __clone() {
        
    }

    
    public function BigInt($unsigned = false){
        parent::setName('BIGINT');
        parent::setID(typeid::BIGINT);
        parent::setUnsigned($unsigned);
    }
}

?>