<?php
    namespace System;

    use System\Authenticator;

    require_once('./configure.php');

    class Authenticator {
        private function __constructor() {;}
        private function __clone() {;}
        private function __destructor(){;}

        private function Authenticator() {

        }

        public static function getInstance() {
            static $instance = null;
            if(null === $instance) {
                $instance = new Authenticator();
            }

            return $instance;
        }

        public function authenticate($user,$pwd) {
            $mysqli = new \mysqli(\DBHost, \DBUser, \DBPwd, \DBName);
            if($mysqli) {
                $q = "SELECT * FROM ".\DataTables::UserTable." WHERE name='".$user."' AND password='". hash("sha256",$pwd)."'";
                
                $result = $mysqli->query($q);
                if($result) {
                    $arr = $result->fetch_assoc();
                    if($arr) {
                        $out_user = $arr['name'];
                        if(strcmp($out_user, $user) == 0) {
                            $result->free();
                            return true;
                        }
                    }
                    $result->free();
                    return false;
                }
            }
            return false;
        }
    }
?>