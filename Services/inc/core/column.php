<?php
namespace MySQL;

defined('__MAGIC__') or exit();

require_once './bigint.php';
require_once './smallint.php';
require_once './tinyint.php';
require_once './integer.php';
require_once './mediumint.php';
require_once './float.php';
require_once './double.php';
require_once './tinytext.php';
require_once './text.php';
require_once './mediumtext.php';
require_once './longtext.php';


class Column extends Object{
    private $datatype = null;
    private $is_primary = false;
    private $notnull = false;
    private $unique = false;
    private $autonumber = false;


    public function getType(){
        return $this->datatype;
    }
    
    protected function setType($datatype){
        $this->datatype = $datatype;
    }
    
    public function isPrimary(){
        return $this->$is_primary;
    }
    
    protected function setPrimary($primary){
        $this->is_primary = $primary;
    }
    
    public function isUnique(){
        return $this->unique;
    }
    
    protected function setUnique($unique){
        $this->unique = $unique;
    }
    
    public function isNotNullable(){
        return $this->notnull;
    }
    
    protected function setNotNullable($notnull){
        $this->notnull = $notnull;
    }
    
    public function isAutoIncrement(){
        return $this->autonumber;
    }
    
    public function setAutoIncrement($auto_increment){
        $this->autonumber = $auto_increment;
    }

    private function __construct() {
        
    }
    private function __clone() {
        
    }

    public function Column($name, typeid $type, $count = 0, $primary=false,$unique=false,$notnull=false){
        parent::setName($name);
        $this->setPrimary($primary);
        $this->setUnique($unique);
        $this->setNotNullable($notnull);
        
        switch ($type) {
            case typeid::BIGINT:
                $this->datatype = new BigInt();
                break;
            case typeid::DOUBLE:
                $this->datatype = new Double();
                break;
            case typeid::FLOAT:
                $this->datatype = new Float();
                break;
            case typeid::INTEGER:
                $this->datatype = new Integer();
                break;
            case typeid::LONGTEXT:
                $this->datatype = new LongText();
                break;
            case typeid::MEDIUMINT:
                $this->datatype = new MediumText();
                break;
            case typeid::SMALLINT:
                $this->datatype = new SmallInt();
                break;
            case typeid::TEXT:
                $this->datatype = new Text();
                break;
            case typeid::TINYINT:
                $this->datatype = new TinyInt();
                break;
            case typeid::TINYTEXT:
                $this->datatype = new TinyText();
                break;
            case typeid::VARCHAR:
                $this->datatype = new VarChar($count);
                break;
            case typeid::DECIMAL:
                $this->datatype = new Decimal($count,0);
                break;

            default:
                break;
        }
    }
    
    public function toString() {
        $str = $this->getName().' '.$this->getType()->toString();
        if($this->isPrimary()) {
            $str .= ' PRIMARY KEY';
        }
        
        if($this->isAutoIncrement()) {
            $str .= ' AUTO_INCREMENT';
        }
        
        if($this->isUnique()) {
            $str .= ' UNIQUE';
        }
        
        if($this->isNotNullable()) {
            $str .= ' NOT NULL';
        }
        
        return $str;
    }
}

class Columns extends Object{
    private $cols = null;
    
    private function __construct() {
        
    }
    
    private function __clone() {
        
    }

    public function count(){
        if(is_null($this->cols))
            return 0;
        
        return count($this->cols);
    }
    
    public function add($name, typeid $type, $count = 0, $primary=false,$unique=false,$notnull=false){
        if($this->count() > 0) {
            if(array_key_exists($name, $this->cols))
                return false;
        }
        
        $this->cols[$name] = new Column($name, $type, $count, $primary, $unique, $notnull);
        return true;
    }
    
    public function exist($name){
        if($this->count() == 0)
            return false;
        
        return array_key_exists($name, $this->cols);
    }
    
    public function remove($name){
        if($this->exist($name)){
            unset($this->cols[$name]);
            return true;
        }
        
        return false;
    }
    
    public function clear(){
        unset($this->cols);
        $this->cols = array();
    }
    
    public function toString() {
        $str = '';
        foreach ($this->cols as $key => $value) {
            if(strlen($str) > 0){
                $str .= ',';
            }
            
            $str .= $value->toString();
        }
        
        return $str;
    }
}

?>