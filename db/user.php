<?php

require "db.php";

class User {
    public $dbh;

    public function __construct() {
        $this->dbh = new DB();
    }  
    
    public function register($email, $name, $password) {
        $hash = password_hash($password, PASSWORD_DEFAULT);
        $this->dbh->run("INSERT INTO register (email, name, password)
        VALUES (:email, :name, :password)", ["name"=>$name, "email"=>$email, "password"=>$hash]);
    }

    public function login($email) {
        return $this->dbh->run("SELECT * FROM register WHERE email = :email", ["email"=>$email])->fetch();
    }
}