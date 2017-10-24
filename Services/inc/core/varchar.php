<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './datatype.php';

class VarChar extends datatype{
    private $count = 0;
    
    public function getCount(){
        return $this->count;
    }
    
    protected function setCount($count){
        $this->count = $count;
    }

    private function __construct() {
        
    }
    private function __clone() {
        
    }

    public function VarChar($count = 255){
        parent::setName('VARCHAR');
        parent::setID(typeid::VARCHAR);
        
        $this->count = $count;
    }
    
    public function toString() {
        return $this->getName().'('.$this->getCount().')';
    }
}

?>