<?php
namespace Services;

use Services\Service;
use Services\Country;


    require_once('./configure.php');
    require_once('./service_base.php');

    class Country  extends Service {

        public function __constructor($n) {
            parent::__constructor($n);
        }

        public function Country($n) {
            parent::__constructor($n);
        }

        public function serv($request)
        {
            echo(__CLASS__.'::'.__FUNCTION__.'('.$request.')\n');
        }
    }

    ServiceManager::getInstance()->addService('country', new Country('country'));
?>