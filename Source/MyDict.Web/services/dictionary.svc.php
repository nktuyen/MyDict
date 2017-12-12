<?php
namespace Services;


require_once('service_base.php');
require_once('database.php');

class Dictionary {
    public $id = 0;
    public $name = '';
    public $title = '';
    public $source_language = 0;
    public $dest_language = 0;

    public function __construct(
        $uid = 0, 
        $name = '', 
        $title = '',
        $source_language = 0,
        $dest_language = 0) {
            $this->id = $uid;
            $this->name = $name;
            $this->title = $title;
            $this->source_language = $source_language;
            $this->dest_language = $dest_language;
    }
}

final class DictionaryService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $dic_id = $request['id'];
        $query = '';
        if( is_numeric($dic_id) ){
            $query = "SELECT * FROM ".\Tables::Dictionary." WHERE id=$dic_id";
        }
        else if(strcmp(\strtolower($dic_id), "all") == 0) {
            $query = "SELECT * FROM ".\\Tables::Dictionary;
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
                array_push($response->data, new Dictionary(
                    $res->get("id"),
                    $res->get("name"),
                    $res->get("title"),
                    $res->get("source_language"),
                    $res->get("dest_language")
                ));
            }
            while($res->moveNext());
        }
        $response->write();
    }
}

ServiceManager::getInstance()->addService('dictionary', new DictionaryService('dictionary'));
?>