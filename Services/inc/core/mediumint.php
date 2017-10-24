<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './integer.php.php';

class MediumInt extends Integer{
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function MediumInt($unsigned = false){
        parent::setName('MEDIUMINT');
        parent::setID(typeid::MEDIUMINT);
        parent::setUnsigned($unsigned);
    }
}

?>