<?php
namespace Services;

use Services\Category;


require_once('service_base.php');
require_once('database.php');

class Category {
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

final class CategoryService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $catid = $request['id'];
        $query = '';
        if( is_numeric($catid) ){
            $query = "SELECT * FROM ".\Tables::Category." WHERE id=$catid";
        }
        else if(strcmp(\strtolower($catid), "all") == 0) {
            $query = "SELECT * FROM ".\Tables::Category;
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
                array_push($response->data, new Category(
                    $res->get("id"),
                    $res->get("name"),
                    $res->get("title")
                ));
            }
            while($res->moveNext());
        }
        else {
            $response->status = \HttpStatus::NotFound;
        }
        $response->write();
    }
}

ServiceManager::getInstance()->addService('category', new CategoryService('category'));
?>