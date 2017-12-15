<?php
namespace MyDict\Services\DB;

require_once(INC.'db'.DS.'result.php');

class Query {
    private $query = '';
    private $conn = null;

    public function __construct($query = '', &$conn = null) {
        $this->query = $query;
        $this->conn = $conn;
    }

    public function execute($query = '') {
        if(is_null($this->conn)) {
            return false;
        }

        $cmd = $query;
        if(strlen($cmd) == 0) {
            $cmd = $this->query;
        }
       
        return new Result($this->conn->query($cmd));
    }
}
?>