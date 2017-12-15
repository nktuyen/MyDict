<?php
namespace MyDict\Services\DB;

class Result {
    private $result = null;
    private $arr = null;


    public function __construct($res) {
        $this->result = $res;
        if( $this->result) {
            if("object" === gettype($this->result)){
                $this->arr = $this->result->fetch_all();
            }
        }
    }

    public function getRowCount() {
        if($this->result) {
            return $this->result->num_rows;
        }
        else {
            return 0;
        }
    }

    public function getFieldCount() {
        if($this->result) {
            return $this->resul->field_count;;
        }
        else {
            return 0;
        }
    }

    public function getArray() {
        return $this->arr;
    }

    public function free() {
        if($this->result) {
            $this->result->free();
        }
    }
}
?>