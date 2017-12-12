<?php
namespace Services;

require_once('service_base.php');
require_once('database.php');

class Country {
    public $id = 0;
    public $country_code = '';
    public $iso_code = '';
    public $name = '';
    public $title = '';

    public function __construct($id = 0, $country_code = '', $iso_code = '', $name='', $title = '') {
        $this->id = $id;
        $this->country_code = $country_code;
        $this->iso_code = $iso_code;
        $this->name = $name;
        $this->title = $title;
    }
}

final class CountryService  extends Service {

    public function __construct($nnn) {
        $this->setName($nnn);
    }

    public function serv($request, $response)
    {
        $country_id = $request['id'];
        $query = '';
        if( is_numeric($country_id) ){
            $query = "SELECT * FROM ".\Tables::Country." WHERE id=$country_id";
        }
        else if(strcmp(\strtolower($country_id), "all") == 0) {
            $query = "SELECT * FROM ".\Tables::Country;
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
                array_push($response->data, new Country(
                    $res->get("id"),
                    $res->get("country_code"),
                    $res->get("iso_code"),
                    $res->get("name"),
                    $res->get("title")
                ));
            }
            while($res->moveNext());
        }
        $response->write();
    }
}

ServiceManager::getInstance()->addService('country', new CountryService('country'));
?>