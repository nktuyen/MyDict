<?php
namespace Services;

use Services\Category;


require_once('service_base.php');
require_once('database.php');

class WordClass {
    public $id = 0;
    public $name = '';
    public $title = '';

    public function __construct(
        $uid = 0, 
        $name = '', 
        $title = '') {
            $this->id = $uid;
            $this->name = $name;
            $this->title = $title;
    }
}

final class ClassService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $class_id = $request['id'];
        $query = '';
        if( is_numeric($class_id) ){
            $query = "SELECT * FROM ".\Tables::WordClass." WHERE id=$class_id";
        }
        else if(strcmp(\strtolower($class_id), "all") == 0) {
            $query = "SELECT * FROM ".\Tables::WordClass;
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
                array_push($response->data, new WordClass(
                    $res->get("id"),
                    $res->get("name"),
                    $res->get("title")
                ));
            }
            while($res->moveNext());
        }
        $response->write();
    }
}

ServiceManager::getInstance()->addService('class', new ClassService('class'));
?>