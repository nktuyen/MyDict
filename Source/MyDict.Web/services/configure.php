<?php
    define("DBHost", "localhost");
    define("DBName", "mydict");
    define("DBUser", "root");
    define("DBPwd", "Tunk.1988");

    define("USER_KEY", "__usr__");
    define("PWD_KEY", "__pwd__");
    define("SVC_KEY", "__svc__");

    abstract class DataTables {
        const   UserTable = 'tbl_user';
        const   Country = 'tbl_country';
    }


    abstract class HttpStatus {
            const OK = 200;
            const NotFound = 404;
    }
?>