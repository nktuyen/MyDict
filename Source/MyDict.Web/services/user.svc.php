<?php
namespace Services;

require_once('service_base.php');
require_once('database.php');

class User {
    public $id = 0;
    public $name = '';
    public $password = '';
    public $email = '';
    public $first_name = '';
    public $last_name = '';
    public $birth_day = 0;
    public $birth_month = 0;
    public $birth_year = 0;
    public $gender = 0;
    public $registered_date = '';

    public function __construct(
        $uid = 0, 
        $name = '', 
        $password = '', 
        $email = '', 
        $first_name = '', 
        $last_name = '',
        $birth_day = 0,
        $birth_month = 0,
        $birth_year = 0,
        $gender = 0,
        $registered_date = '') {
            $this->id = $uid;
            $this->name = $name;
            $this->password = $password;
            $this->email = $email;
            $this->first_name = $first_name;
            $this->last_name = $last_name;
            $this->birth_day = $birth_day;
            $this->birth_month = $birth_month;
            $this->birth_year = $birth_year;
            $this->gender = $gender;
            $this->registered_date = $registered_date;
    }
}

final class UserService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $command = $request[\CMD_KEY];
        if(!isset($command)) {
            $response->status = \HttpStatus::BadRequest;
            $response->write();
            return;
        }
        
        if(strcmp(strtoupper($command), \HttpCommand::GET ) == 0) {
            
            $criteria = $request[CRITE_KEY];
            $value = null;
            if(strcmp(strtolower($criteria), "name") == 0) {
                $value = $request[VAL_KEY];
                $this->getUserByName($value, $response);
            }
            else {
                $value = $request[VAL_KEY];
                $this->getUserByID($value, $response);
            }
        }
        else if(strcmp(\strtoupper($command), \HttpCommand::DELETE ) == 0) {

        }
        else if(strcmp(\strtoupper($command), \HttpCommand::INSERT ) == 0) {

        }
        else if(strcmp(\strtoupper($command), \HttpCommand::UPDATE ) == 0) {
            
        }
        else {
            $response->status = \HttpStatus::BadRequest;
            $response->write();
            return;
        }
    }

    private function getUserByID($uid, $response) {
        $query = '';
        if( is_numeric($uid) ){
            $query = "SELECT * FROM ".\Tables::User." WHERE id=$uid";
        }
        else if(strcmp(\strtolower($uid), "all") == 0) {
            $query = "SELECT * FROM ".\Tables::User;
        }
        
        $conn = \Database\Connection::getInstance();
        if(is_null($conn)) {
            $response->status = \HttpStatus::NotFound;
            $response->write();
            return;
        }
        $res = $conn->createQuery()->execute($query);
        if($res->getRowCount() > 0) {
            unset($response->data);
            $response->data = array();
            do {
                array_push($response->data, new User(
                    $res->get("id"),
                    $res->get("name"),
                    $res->get("password"),
                    $res->get("email"),
                    $res->get("first_name"),
                    $res->get("last_name"),
                    $res->get("birth_day"),
                    $res->get("birth_month"),
                    $res->get("birth_year"),
                    $res->get("gender"),
                    $res->get("registered_date")
                ));
            }
            while($res->moveNext());
        }
        $response->write();
    }

    private function getUserByName($uname, $response) {
        $query = "SELECT * FROM ".\Tables::User." WHERE name='$uname'";
        $conn = \Database\Connection::getInstance();

        if(is_null($conn)) {
            $response->status = \HttpStatus::NotFound;
            $response->write();
            return;
        }
        $res = $conn->createQuery()->execute($query);
        if($res->getRowCount() > 0) {
            unset($response->data);
            $response->data = array();
            do {
                array_push($response->data, new User(
                    $res->get("id"),
                    $res->get("name"),
                    $res->get("password"),
                    $res->get("email"),
                    $res->get("first_name"),
                    $res->get("last_name"),
                    $res->get("birth_day"),
                    $res->get("birth_month"),
                    $res->get("birth_year"),
                    $res->get("gender"),
                    $res->get("registered_date")
                ));
            }
            while($res->moveNext());
        }
        $response->write();
    }
};

ServiceManager::getInstance()->addService('user', new UserService('user'));
?>