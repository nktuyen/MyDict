<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class Integer extends datatype{
    private $unsigned = false;
    
    public function isUnsigned(){
        return $this->unsigned;
    }
    
    protected function setUnsigned($uns){
        $this->unsigned = $uns;
    }

    private function __construct() {
        
    }
    private function __clone() {
        
    }
    public function Integer($unsigned = false){
        parent::setName('INT');
        parent::setID(typeid::INTEGER);
        $this->unsigned = $unsigned;
    }
    
    public function toString() {
        $str = parent::toString();
        if($this->isUnsigned()){
            $str .= ' UNSIGNED';
        }
        return $str;
    }
}

?>