<?php
namespace Services;

require_once('service_base.php');
require_once('database.php');

class Vocabulary {
    public $id = 0;
    public $name = '';
    public $dictionary_id = 0;
    public $user_id = 0;

    public function __construct(
        $uid = 0, 
        $name = '', 
        $dictionary_id = 0,
        $user_id = 0) {
            $this->id = $uid;
            $this->name = $name;
            $this->dictionary_id = $dictionary_id;
            $this->user_id = $user_id;
    }
}

final class VocabularyService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $voc_id = $request['id'];
        $query = '';
        if( is_numeric($voc_id) ){
            $query = "SELECT * FROM ".\Tables::Vocabulary." WHERE id=$voc_id";
        }
        else if(strcmp(\strtolower($voc_id), "all") == 0) {
            $query = "SELECT * FROM ".\Tables::Vocabulary;
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
                array_push($response->data, new Vocabulary(
                    $res->get("id"),
                    $res->get("name"),
                    $res->get("dictinary_id"),
                    $res->get("user_id")
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

ServiceManager::getInstance()->addService('vocabulary', new VocabularyService('vocabulary'));
?>