<?php
defined('__SIGNAL__') or die('Access restricted.');
?>

<?php
    class HttpStatus {
        private $code = 0;
        private $name = "";
        private $desc = "";

        public function getCode() { return $this->code; }
        public function getName() { return $this->name;}
        public function getDescription() { return $this->desc; }

        protected function __construct($code, $name, $desc = "") {
            $this->code = $code;
            $this->name = $name;
            $this->desc = $desc;
        }

        public function equal($code) {
            return ($this->code == $code);
        }
    }


    class HttpResponse {
        private $status = null;
        private $data = null;

        public function getStatus() {
            return $this->status;
        }

        public function getData() {
            return $this->data;
        }

        public function setStatus($status) {
            $this->status = $status;
        }

        public function setData($data) {
            $this->data = $data;
        }

        protected function __construct($status, $data) {
            $this->status = $status;
            $this->data = $data;
        }

        public static function createInstance($s, $d = null) {
            return new HttpResponse($s, $d);
        }

        public function toJSON() {
            $ary = array('status'=>$this->status->getCode(), 'data'=>$this->data);
            return json_encode($ary);
        }
    }
?>

<?php
    //100
    class HttpStatus100 extends HttpStatus {
        protected function __construct() {
            parent::__construct(100, "Continue", "The server has received the request headers and the client should proceed to send the request body.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus100();
            return $instance;
        }
    }

    //200
    class HttpStatus200 extends HttpStatus {
        protected function __construct() {
            parent::__construct(200, "OK", "Standard response for successful HTTP requests.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus200();
            return $instance;
        }
    }

    //201
    class HttpStatus201 extends HttpStatus {
        protected function __construct() {
            parent::__construct(201, "Created", "The request has been fulfilled, resulting in the creation of a new resource.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus201();
            return $instance;
        }
    }

    //202
    class HttpStatus202 extends HttpStatus {
        protected function __construct() {
            parent::__construct(202, "Accepted", "The request has been accepted for processing, but the processing has not been completed.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus202();
            return $instance;
        }
    }
    
    //203
    class HttpStatus203 extends HttpStatus {
        protected function __construct() {
            parent::__construct(203, "Non-Authoritative Information", "The server is a transforming proxy that received a 200 OK from its origin, but is returning a modified version of the origin's response.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus203();
            return $instance;
        }
    }

    //204
    class HttpStatus204 extends HttpStatus {
        protected function __construct() {
            parent::__construct(204, "No Content", "The server successfully processed the request and is not returning any content.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus204();
            return $instance;
        }
    }

    //205
    class HttpStatus205 extends HttpStatus {
        protected function __construct() {
            parent::__construct(205, "Reset Content", "The server successfully processed the request, but is not returning any content.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus205();
            return $instance;
        }
    }

    //400
    class HttpStatus400 extends HttpStatus {
        protected function __construct() {
            parent::__construct(400, "Bad Request", "The server cannot or will not process the request due to an apparent client error.");
        }

        public static function getInstance() {
            $instance = null;
            if(null === $instance)
                $instance = new HttpStatus400();
            return $instance;
        }
    }

    //401
    class HttpStatus401 extends HttpStatus {
        protected function __construct() {
            parent::__construct(401, "Unauthorized", "The response must include a WWW-Authenticate header field containing a challenge applicable to the requested resource.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus401();
            return $instance;
        }
    }

    //403
    class HttpStatus403 extends HttpStatus {
        protected function __construct() {
            parent::__construct(403, "Forbidden", "The request was valid, but the server is refusing action.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus403();
            return $instance;
        }
    }

    //404
    class HttpStatus404 extends HttpStatus {
        protected function __construct() {
            parent::__construct(404, "Not Found", "The requested resource could not be found but may be available in the future.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus404();
            return $instance;
        }
    }

    //405
    class HttpStatus405 extends HttpStatus {
        protected function __construct() {
            parent::__construct(405, "Method Not Allowed", "A request method is not supported for the requested resource.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus405();
            return $instance;
        }
    }

    //406
    class HttpStatus406 extends HttpStatus {
        protected function __construct() {
            parent::__construct(406, "Not Acceptable", "The requested resource is capable of generating only content not acceptable according to the Accept headers sent in the request.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus406();
            return $instance;
        }
    }

    //407
    class HttpStatus407 extends HttpStatus {
        protected function __construct() {
            parent::__construct(407, "Proxy Authentication Required", "The client must first authenticate itself with the proxy.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus407();
            return $instance;
        }
    }

    //408
    class HttpStatus408 extends HttpStatus {
        protected function __construct() {
            parent::__construct(408, "Request Timeout", "The server timed out waiting for the request.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus408();
            return $instance;
        }
    }

    //409
    class HttpStatus409 extends HttpStatus {
        protected function __construct() {
            parent::__construct(409, "Conflict", "Indicates that the request could not be processed because of conflict in the request, such as an edit conflict between multiple simultaneous updates.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus409();
            return $instance;
        }
    }

    //410
    class HttpStatus410 extends HttpStatus {
        protected function __construct() {
            parent::__construct(410, "Gone", "Indicates that the resource requested is no longer available and will not be available again.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus410();
            return $instance;
        }
    }

    //411
    class HttpStatus411 extends HttpStatus {
        protected function __construct() {
            parent::__construct(411, "Length Required", "The request did not specify the length of its content, which is required by the requested resource.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus411();
            return $instance;
        }
    }

    //413
    class HttpStatus413 extends HttpStatus {
        protected function __construct() {
            parent::__construct(413, "Payload Too Large", "The request is larger than the server is willing or able to process.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus413();
            return $instance;
        }
    }

    //414
    class HttpStatus414 extends HttpStatus {
        protected function __construct() {
            parent::__construct(414, "URI Too Long", "The URI provided was too long for the server to process.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus414();
            return $instance;
        }
    }

    //415
    class HttpStatus415 extends HttpStatus {
        protected function __construct() {
            parent::__construct(415, "Unsupported Media Type", "The request entity has a media type which the server or resource does not support.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus415();
            return $instance;
        }
    }

    //423
    class HttpStatus423 extends HttpStatus {
        protected function __construct() {
            parent::__construct(423, "Locked", "The resource that is being accessed is locked.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus423();
            return $instance;
        }
    }

    //429
    class HttpStatus429 extends HttpStatus {
        protected function __construct() {
            parent::__construct(429, "Too Many Requests", "The user has sent too many requests in a given amount of time.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus429();
            return $instance;
        }
    }

    //500
    class HttpStatus500 extends HttpStatus {
        protected function __construct() {
            parent::__construct(500, "Internal Server Error", "A generic error message, given when an unexpected condition was encountered and no more specific message is suitable.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus500();
            return $instance;
        }
    }

    //501
    class HttpStatus501 extends HttpStatus {
        protected function __construct() {
            parent::__construct(501, "Not Implemented", "The server either does not recognize the request method, or it lacks the ability to fulfil the request.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus501();
            return $instance;
        }
    }

    //502
    class HttpStatus502 extends HttpStatus {
        protected function __construct() {
            parent::__construct(502, "Bad Gateway", "The server was acting as a gateway or proxy and received an invalid response from the upstream server.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus502();
            return $instance;
        }
    }

    //503
    class HttpStatus503 extends HttpStatus {
        protected function __construct() {
            parent::__construct(503, "Service Unavailable", "The server is currently unavailable.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus503();
            return $instance;
        }
    }

    //504
    class HttpStatus504 extends HttpStatus {
        protected function __construct() {
            parent::__construct(504, "Gateway Timeout", "The server was acting as a gateway or proxy and did not receive a timely response from the upstream server.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus504();
            return $instance;
        }
    }

    //505
    class HttpStatus505 extends HttpStatus {
        protected function __construct() {
            parent::__construct(505, "HTTP Version Not Supported", "The server does not support the HTTP protocol version used in the request.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus505();
            return $instance;
        }
    }

    //511
    class HttpStatus511 extends HttpStatus {
        protected function __construct() {
            parent::__construct(511, "Network Authentication Required", "The client needs to authenticate to gain network access.");
        }

        public static function getInstance() {
            $instance = null;
            if(null == $instance)
                $instance = new HttpStatus511();
            return $instance;
        }
    }
?>