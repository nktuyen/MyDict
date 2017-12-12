<?php
    define("DBHost", "localhost");
    define("DBName", "mydict");
    define("DBUser", "root");
    define("DBPwd", "Tunk.1988");

    define("USER_KEY", "__usr__");
    define("PWD_KEY", "__pwd__");
    define("SVC_KEY", "__svc__");
    define("CMD_KEY", "__cmd__");
    define("CRITE_KEY", "__cri__");
    define("VAL_KEY", "__val__");

    abstract class HttpCommand {
        const GET = 'GET';
        const INSERT = 'INSERT';
        const DELETE = 'DELETE';
        const UPDATE = 'UPDATE';
    }

    abstract class Tables {
        const   User = 'tbl_user';
        const   Country = 'tbl_country';
        const   Category = 'tbl_category';
        const   WordClass = 'tbl_class';
        const   Vocabulary = 'tbl_vocabulary';
        const   Dictionary = 'tbl_dictionary';
        const   Description = 'tbl_description';
        const   Entity = 'tbl_entity';
        const   UserType = 'tbl_usertype';
        const   EntityType = 'tbl_entitytype';
        const   Example = 'tbl_example';
        const   Language = 'tbl_language';
        const   Favorite = 'tbl_favorite';
        const   Permission = 'tbl_permission';
        const   Phonetic = 'tbl_phonetic';
        const   Translation = 'tbl_translation';
        const   Gender = 'tbl_gender';
        const   Categorization = 'tbl_categorization';
    }


    abstract class HttpStatus {
        const Continue = 100;
        const OK = 200;
        const Created = 201;
        const Accepted = 202;
        const NoContent = 204;
        const Found = 302;
        const BadRequest = 400;
        const Unauthorized = 401;
        const Forbidden = 403;
        const NotFound = 404;
        const MethodNotAllowed = 405;
        const NotAcceptable = 406;
        const RequestTimeout = 408;

        const  InternalServerError = 500;
        const ServiceUnavailable = 503;
    }
?>