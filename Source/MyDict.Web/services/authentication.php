<?php
    namespace Authentication;

    require_once('configure.php');
    require_once('database.php');

    use Database\Connection;

    class Authenticator {
        private function __construct() {
            
        }
        
        private function __clone() {
            
        }

        public static function getInstance() {
            static $instance = null;
            if(null === $instance) {
                $instance = new Authenticator();
            }

            return $instance;
        }

        public function validate($user,$pwd) {
            require_once('database.php');
            $conn = Connection::getInstance();
            if(is_null($conn)) {
                return false;
            }
            
            $cmd = "SELECT name FROM ".\Tables::User." WHERE name='".$user."' AND password='".hash("sha256", $pwd)."'";
            $query = $conn->createQuery($cmd);
            if(is_null($query))  {
                return false;
            }
    
            $result = $query->execute();
            if($result->getRowCount() <= 0) {
                $result->free();
                return false;
            }

            $name = $result->get("name");
            
            if(strcmp($name, $user) == 0) {
                return true;
            }

            return false;
        }
    }
?>