<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class Text extends datatype{
    private function __construct() {
        
    }
    private function __clone() {
        
    }

    public function Text(){
        parent::setName('TEXT');
        parent::setID(typeid::TEXT);
    }
}

?>