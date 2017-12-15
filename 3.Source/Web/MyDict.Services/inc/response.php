<?php
namespace MyDict\Services\Http;

abstract class HttpStatusCode
{
    const Continue_ = 100;
    const SwitchingProtocols = 101;
    const OK = 200;
    const Created = 201;
    const Accepted = 202;
    const NonAuthoritativeInformation = 203;
    const NoContent = 204;
    const ResetContent = 205;
    const PartialContent = 206;
    const MultipleChoices = 300;
    const Ambiguous = 300;
    const MovedPermanently = 301;
    const Moved = 301;
    const Found = 302;
    const Redirect = 302;
    const SeeOther = 303;
    const RedirectMethod = 303;
    const NotModified = 304;
    const UseProxy = 305;
    const Unused = 306;
    const TemporaryRedirect = 307;
    const RedirectKeepVerb = 307;
    const BadRequest = 400;
    const Unauthorized = 401;
    const PaymentRequired = 402;
    const Forbidden = 403;
    const NotFound = 404;
    const MethodNotAllowed = 405;
    const NotAcceptable = 406;
    const ProxyAuthenticationRequired = 407;
    const RequestTimeout = 408;
    const Conflict = 409;
    const Gone = 410;
    const LengthRequired = 411;
    const PreconditionFailed = 412;
    const RequestEntityTooLarge = 413;
    const RequestUriTooLong = 414;
    const UnsupportedMediaType = 415;
    const RequestedRangeNotSatisfiable = 416;
    const ExpectationFailed = 417;
    const UpgradeRequired = 426;
    const InternalServerError = 500;
    const NotImplemented = 501;
    const BadGateway = 502;
    const ServiceUnavailable = 503;
    const GatewayTimeout = 504;
    const HttpVersionNotSupported = 505;
};


 class Response{
     public $status = 0;
     public $data = array();

     public function __construct($code) {
         $this->status = $code;
     }

     public function write() {
         header('Content-Type: application/json');
         echo json_encode($this);
     }

     public function OK() {
         $this->status = HttpStatusCode::OK;
         header('Content-Type: application/json');
         die(json_encode($this));
     }

     public function error($code) {
         $this->status = $code;
         unset($this->data);
         header('Content-Type: application/json');
         die(json_encode($this));
     }
 }

?>