<?php
namespace Services;

use Services\Category;


require_once('service_base.php');
require_once('database.php');

class Language {
    public $id = 0;
    public $code = '';
    public $name = '';
    public $title = '';

    public function __construct(
        $uid = 0, 
        $code = '',
        $name = '', 
        $title = '') {
            $this->id = $uid;
            $this->code = $code;
            $this->name = $name;
            $this->title = $title;
    }
}

final class LanguageService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $lang_id = $request['id'];
        $query = '';
        if( is_numeric($lang_id) ){
            $query = "SELECT * FROM ".\Tables::Language." WHERE id=$lang_id";
        }
        else if(strcmp(\strtolower($lang_id), "all") == 0) {
            $query = "SELECT * FROM ".\Tables::Language;
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
                array_push($response->data, new Language(
                    $res->get("id"),
                    $res->get("code"),
                    $res->get("name"),
                    $res->get("title")
                ));
            }
            while($res->moveNext());
        }
        $response->write();
    }
}

ServiceManager::getInstance()->addService('language', new LanguageService('language'));
?>