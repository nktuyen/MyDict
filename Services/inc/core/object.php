<?php

namespace MySQL;

defined('__MAGIC__') or exit();


abstract class Object{
    private $name = '';
    
    public function getName(){
        return $this->name;
    }
    
    protected function setName($newName){
        $this->name = $newName;
    }
    
    public function toString(){
        return $this->name;
    }
}

?>