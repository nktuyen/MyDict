<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './table.php';

abstract class Database extends Object{
    private $desc = '';
    private $tables = null;


    public function getDesc(){
        return $this->desc;
    }
    
    protected function setDesc($desc){
        $this->desc = $desc;
    }
    
    public function Tables(){
        return $this->tables;
    }

    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function Database($name,$desc){
        parent::setName($name);
        $this->desc = $desc;
        $this->tables = new Tables();
    }
}

?>