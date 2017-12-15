<?php
namespace MyDict\Services\Entity;

defined("__MAGIC__") or die();

class Language {
    public $id = 0;
    public $name = '';
    public $title = '';

    public function __construct($id, $name, $title) {
        $this->id = $id;
        $this->name = $name;
        $this->title = $title;
    }
}
?>