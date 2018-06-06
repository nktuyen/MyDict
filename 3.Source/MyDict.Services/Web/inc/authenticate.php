<?php
defined('__SIGNAL__') or die('Access restricted.');
?>

<?php
abstract class AuthenticationResult {
    const authSuccess = 0;
    const authUserInvalid = 1;
    const authUserNotFound = 2;
    const authPasswordDoesNotMatch = 3;
    const authUserRestricted = 4;
}
?>

<?php
class Authenticator {
    protected function __construct() {

    }
    private function __clone() {

    }

    private function __wakeup() {

    }

    public static function authen($config, $service, $remote_user, $remote_pwd) {
        if( (!isset($config)) || (null == $config) ) {
            return AuthenticationResult::authSuccess;
        }

        $authen = $config->AUTH;
        if(null == $authen) {
            return AuthenticationResult::authSuccess;
        }

        $user = $authen->USER;
        if(null == $user) {
            return AuthenticationResult::authSuccess;
        }

        if( (!isset($service)) || (null == $service) ) {
            return AuthenticationResult::authSuccess;
        }

        if((!isset($remote_user)) || ("" == $remote_user)) {
            return AuthenticationResult::authUserInvalid;
        }

        $username = $user->getValue();
        if($username != $remote_user) {
            return AuthenticationResult::authUserNotFound;
        }

        $pwd = $authen->PASSWORD;
        if(null == $pwd) {
            return AuthenticationResult::authSuccess;
        }

        if( (!isset($remote_pwd)) || (null == $remote_pwd) ) {
            return AuthenticationResult::authPasswordDoesNotMatch;
        }

        $password = $pwd->getValue();
        if($password != $remote_pwd) {
            return AuthenticationResult::authPasswordDoesNotMatch;
        }

        return AuthenticationResult::authSuccess;
    }
}
?>