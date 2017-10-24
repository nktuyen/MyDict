<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class Decimal extends datatype{
    private $m = 1;
    private $d = 1;
    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function Decimal($m=1,$d=1){
        parent::setName('FLOAT');
        parent::setID(typeid::FLOAT);
        $this->m=$m;
        $this->d = $d;
    }
}

?>