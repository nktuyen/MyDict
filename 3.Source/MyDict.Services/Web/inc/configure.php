<?php
defined('__SIGNAL__') or die('Access restricted.');
?>

<?php
$_GLOBAL = array(
	'SYS'=>array(
		'DB' => array(
			'HOST'=>'localhost',
			'NAME'=>'mydict',
			'USER'=>'root',
			'PWD' => 'cefb242b79b8a158723eaeb6cbfeeb9844a0c07c',
			'TABLES'=>array(
				'language'=>'tbl_language',
				'country'=>'tbl_country',
				'gender'=>'tbl_gender',
				'user'=>'tbl_user',
				'dictionary'=>'tbl_dictionary',
				'class'=>'tbl_class',
				'category'=>'tbl_category',
				'mediatype'=>'tbl_mediatype',
				'media'=>'tbl_media',
				'vocabulary'=>'tbl_vocabulary',
				'relationtype'=>'tbl_relationtype',
				'related'=>'tbl_related',
				'categorization'=>'tbl_categorization',
				'entitytype'=>'tbl_entitytype',
				'entity'=>'tbl_entity',
				'permission'=>'tbl_permission',
				'right'=>'tbl_right',
				'phonetic'=>'tbl_phonetic',
				'description'=>'tbl_description',
				'example'=>'tbl_example',
				'currency'=>'tbl_currency',
			)
		),
		'AUTH'=>array(
			'USER'=>'nktuyen@hotmail.com',
			'PWD'=>'cefb242b79b8a158723eaeb6cbfeeb9844a0c07c'
		)
	),
	'APP'=>array(
		'DB' => array(
			'HOST'=>'localhost',
			'NAME'=>'mydict',
			'USER'=>'root',
			'PWD'=>'cefb242b79b8a158723eaeb6cbfeeb9844a0c07c',
			'TABLES'=>array(
				'language'=>'tbl_language',
				'country'=>'tbl_country',
				'gender'=>'tbl_gender',
				'user'=>'tbl_user',
				'dictionary'=>'tbl_dictionary',
				'class'=>'tbl_class',
				'category'=>'tbl_category',
				'mediatype'=>'tbl_mediatype',
				'media'=>'tbl_media',
				'vocabulary'=>'tbl_vocabulary',
				'relationtype'=>'tbl_relationtype',
				'related'=>'tbl_related',
				'categorization'=>'tbl_categorization',
				'entitytype'=>'tbl_entitytype',
				'entity'=>'tbl_entity',
				'permission'=>'tbl_permission',
				'right'=>'tbl_right',
				'phonetic'=>'tbl_phonetic',
				'description'=>'tbl_description',
				'example'=>'tbl_example',
				'currency'=>'tbl_currency',
			)
		),
		'AUTH'=>array(
			'USER'=>'nktuyen@hotmail.com',
			'PWD'=>'cefb242b79b8a158723eaeb6cbfeeb9844a0c07c'
		)
	),
);
?>

<?php
class SettingItem {
	private $mName = "";
	private $mValue = null;

	public function getname() {
		return $this->mName;
	}

	public function getValue() {
		return $this->mValue;
	}

	public function __construct($name = "", $parent = null) {
		$this->mName = $name;

		if(null != $parent) {
			$ary = $parent->getValue();
			if(null != $ary) {
				$this->mValue = $ary[$this->getName()];
			}
		}
		else {
			global $_GLOBAL;
			$this->mValue = $_GLOBAL[$this->getName()];
		}
	}
}

class DatabaseSetting  extends SettingItem
{
	public $HOST = null;
	public $NAME = null;
	public $USER = null;
	public $PASSWORD = null;
	public $TABLES = null;

	protected function __construct($parent) {
		parent::__construct('DB', $parent);

		$this->HOST = new SettingItem('HOST', $this);
		$this->NAME = new SettingItem('NAME', $this);
		$this->USER = new SettingItem('USER', $this);
		$this->PASSWORD = new SettingItem('PWD', $this);
		$this->TABLES = new SettingItem('TABLES', $this);
	}

	public static function createInstance($parent) {
		$instance = new DatabaseSetting($parent);
		return $instance;
	}
}

class AuthenticationSetting extends SettingItem {
	public $USER= null;
	public $PASSWORD = null;

	protected function __construct($parent) {
		parent::__construct('AUTH', $parent);

		$this->USER = new SettingItem('USER', $this);
		$this->PASSWORD = new SettingItem('PWD', $this);
	}

	public static function createInstance($parent) {
		$instance = new AuthenticationSetting($parent);
		return $instance;
	}
}

class AppSetting
{
	private $APP = null;
	public $DB = null;
	public $AUTHEN = null;

	private function __construct() {
		$this->APP =  new SettingItem('APP');
		$this->DB = DatabaseSetting::createInstance($this->APP);
		$this->AUTHEN = AuthenticationSetting::createInstance($this->APP);
	}

	private function __clone() {

	}

	private function __wakeup() {

	}

	public static function getInstance() {
		static $instance = null;
		if(null == $instance)
			$instance = new AppSetting();
		return $instance;
	}
}

class SystemSetting {
	private $SYS = null;
	public $DB = null;
	public $AUTH = null;

	private function __construct() {
		$this->SYS = new SettingItem('SYS');
		$this->DB = DatabaseSetting::createInstance($this->SYS);
		$this->AUTH = AuthenticationSetting::createInstance($this->SYS);
	}

	private function __clone() {

	}

	private function __wakeup() {

	}

	public static function getInstance() {
		static $instance = null;
		if(null == $instance) 
			$instance = new SystemSetting();
		return $instance;
	}
}


?>