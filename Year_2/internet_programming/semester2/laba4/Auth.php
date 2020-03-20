<?php


class Auth {
    function register($login, $email, $pwrd) {
        $db_conn = pg_connect('host=localhost dbname=tents user=postgres password=MOORMOOR port=5432');
        $query = "INSERT INTO users VALUES ('$login', '$email', '$pwrd')";
        $resource = pg_query($db_conn, $query);
        if($resource) {
            return "good";
        }
        else {
            return "bad";
        }
    }

    function login($name, $password) {
        $db_conn = pg_connect('host=localhost dbname=tents user=postgres password=MOORMOOR port=5432');
        $query = "SELECT * FROM users WHERE login = '$name'";
        $resource = pg_query($db_conn, $query);
        $result = pg_fetch_all($resource);
        if(!$result) {
            return 'bad';
        }
        if($password == $result[0]['pwrd']) {
            return 'good';
        }
        return 'bad';
    }

    function isAuth($name) {

    }
}
