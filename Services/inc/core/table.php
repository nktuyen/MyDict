<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './object.php';

abstract class Table extends Object{
    private $cols = null;
    private $desc = '';


    public function Columns(){
        return $this->cols;
    }
    
    public function getDesc(){
        return $this->desc;
    }
    
    protected function setDesc($desc){
        $this->desc = $desc;
    }

    private function __construct() {
        
    }
    private function __clone() {
        
    }
    
    public function Table($name,$desc){
        parent::setName($name);
        $this->cols = new Columns();
    }
    
    public function toString() {
        $str = $this->getName() . '('.$this->Columns()->toString().')';
        
        return $str;
    }
}

class Tables extends Object{
    private $tbls = null;
    private $position = null;


    private function __construct() {
        
    }
    
    private function __clone() {
        
    }

    public function count(){
        if(is_null($this->tbls))
            return 0;
        
        return count($this->tbls);
    }
    
    public function add($name, $desc){
        if($this->count() > 0) {
            if(array_key_exists($name, $this->tbls))
                return false;
        }
        
        $this->tbls[$name] = new Tables($name, $desc);
        return true;
    }
    
    public function exist($name){
        if($this->count() == 0)
            return false;
        
        return array_key_exists($name, $this->tbls);
    }
    
    public function remove($name){
        if($this->exist($name)){
            unset($this->tbls[$name]);
            return true;
        }
        
        return false;
    }
    
    public function clear(){
        unset($this->tbls);
        $this->tbls = array();
    }
    
    public function at($name){
        if($this->exist($name)){
            return $this->tbls[$name];
        }
        
        return null;
    }
    
    public function first(){
        if($this->count() > 0){
            reset($this->tbls);
            return current($this->tbls);
        }
        
        return null;
    }
    
    public function next(){
        if($this->count() > 0){
            next($this->tbls);
            return current($this->tbls);
        }
        
        return null;
    }
    
    public function prev(){
        if($this->count() > 0){
            prev($this->tbls);
            return current($this->tbls);
        }
        
        return null;
    }
    
    public function last(){
        if($this->count() > 0){
            end($this->tbls);
            return current($this->tbls);
        }
        
        return null;
    }
}

?>

