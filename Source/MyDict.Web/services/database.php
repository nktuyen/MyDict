<?php
namespace Database;

    require_once('configure.php');

    class Result {
        private $result = null;
        private $arr = null;
        public function __construct($result) {
            if($result) {
                $this->result = $result;
                if($this->result) {
                    $this->arr = $this->result->fetch_all(MYSQLI_ASSOC);
                }
            }
        }

        public function getRowCount() {
            if(is_null($this->result)) {
                return 0;
            }

            return $this->result->num_rows;
        }

        public function getFieldCount() {
            if(is_null($this->result)) {
                return 0;
            }

            return $this->result->field_count;
        }

        public function free() {
            if( ($this->result) ) {
                $this->result->free();
                unset($this->result);
                $this->result = null;
            }
            unset($this->arr);
        }

        public function get($field) {
            if(is_null($this->arr)) {
                return false;
            }

            $record = current($this->arr);
            return $record[$field];
        }

        public function moveFirst() {
            if(is_null($this->arr)) {
                return false;
            }

            return reset($this->arr);
        }

        public function moveNext() {
            if(is_null($this->arr)) {
                return false;
            }

            return next($this->arr);
        }
    };

    class Query {
        private $mysql = null;
        private $query = '';
        public function __construct($query, $mysql) {
            $this->mysql = $mysql;
            $this->query = $query;
        }

        public function execute($cmd = null) {
            if(is_null($this->mysql)) {
                return false;
            }
            $command = $cmd;
            if(is_null($cmd)) {
                $command = $this->query;
            }
            return new Result( $this->mysql->query($command));
        }
    };

    class Connection {
        private $mysql = null;

        private function __construct() {
            $this->mysql = new \mysqli(\DBHost, \DBUser, \DBPwd, \DBName);
            
        }

        private function __clone() {

        }

        public static function getInstance() {
            static $instance = null;
            if(null === $instance) {
                $instance = new Connection();
            }
            return $instance;
        }

        public function close() {
            $this->mysql->close();
        }

        public function createQuery($query = null) {
            return new Query($query, $this->mysql);
        }
    }
?>