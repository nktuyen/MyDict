<?php
    namespace MySql;
    defined('__SIGNAL__') or die('Access restricted.');
?>

<?php
    define('MYSQL_CONNECTION_DEFAULT_PORT', 3306);

    class Result {
        private $res = null;

        protected function __construct($res) {
            $this->res = $res;
        }

        public static function createInstance($res = null) {
            $instance = new Result($res);

            return $instance;
        }

        public function free() {
            if(null == $this->res)
                return false;
            $this->res->free();
            unset($this->res);
            $this->res = null;
            return true;
        }


        public function isValid() {
            return ($this->res);
        }

        public function fetchArray() {
            if(!$this->isValid())
                return null;
            return $this->res->fetch_array();
        }

        public function fetchAll() {
            if(!$this->isValid())
                return null;
            return $this->res->fetch_all();
        }
    }

    class Command {
        private $cmd = "";
        private $conn = null;
        
        public function __construct($conn, $cmd = "") {
            $this->cmd = $cmd;
            $this->conn = $conn;
        }

        public function execute($query = null) {
            if(null == $this->conn)
                return false;

            $sql = "";
            if( (null == $query) || (!isset($query)) ) {
                $sql = $this->cmd;
            }
            else {
                $sql = $query;
            }

            $mysqli = $this->conn->getHandle();
            if(null != $mysqli) {
                $stmt = $mysqli->prepare($sql);
                if(null != $stmt) {
                    if($stmt->execute()) {
                        return Result::createInstance($stmt->get_result());
                    }
                }
            }

            return false;
        }
    }

    class Connection {
        private $db_engine = null;
        private $db_host = "";
        private $db_name = "";
        private $db_user = "";
        private $db_pwd = "";
        private $db_port = MYSQL_CONNECTION_DEFAULT_PORT;
        
        protected function __construct($host = null, $user = null, $pwd = null, $db = null, $port = MYSQL_CONNECTION_DEFAULT_PORT) {
            if(isset($host))
                $this->db_host = $host;

            if(isset($user))
                $this->db_user = $user;

            if(isset($pwd))
                $this->db_pwd = $pwd;

            if(isset($db))
                $this->db_name = $db;

            if(isset($port))
                $this->db_port = $port;
        }

        public function __destructor() {
            $this->close();
        }

        private function __clone() {}
        private function __wakeup() {}

        public static function getInstance() {
            static $instance = null;
            if(null == $instance)
                $instance = new Connection();

            return $instance;
        }

        public function getHandle() {
            return $this->db_engine;
        }

        public function isOpen() {
            if(null == $this->db_engine)
                return false;
            
            return true;
        }

        public function connect($host, $user, $pwd, $db, $port = MYSQL_CONNECTION_DEFAULT_PORT) {
            if($this->isOpen())
                return false;

            $this->db_engine = new \mysqli($host, $user, $pwd, $db, $port);
            if($this->db_engine == null)
                return false;

            $this->db_host = $host;
            $this->db_name = $db;
            $this->db_user = $user;
            $this->db_pwd = $pwd;
            $this->db_port = $port;

            return (!$this->db_engine->connect_errno);
        }

        public function close() {
            if(null == $this->db_engine)
                return true;

            if($this->db_engine->close()) {
                unset($this->db_engine);
                $this->db_engine = null;
            }
        }

        public function createCommand($newComand = "") {
            $cmd = new Command($this, $newComand);
            return $cmd;
        }

        public function lastErrorDesc() {
            if(null == $this->db_engine)
                return "";
            return $this->db_engine->error;
        }
    }
?>