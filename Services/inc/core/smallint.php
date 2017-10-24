<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './integer.php.php';

class SmallInt extends Integer{
    private function __construct() {
        
    }
    private function __clone() {
        
    }

    public function SmallInt($unsigned = false){
        parent::setName('SMALLINT');
        parent::setID(typeid::SMALLINT);
        parent::setUnsigned($unsigned);
    }
}

?>