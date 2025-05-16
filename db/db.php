<?php

class DB {
    public $dbh;

    protected $stmt;

    public function __construct($db = "boekenwinkel", $user = "root", $pwd = "", $host = "localhost") {
        try {
            $this->dbh = new PDO("mysql:host=$host;dbname=$db", $user, $pwd);
        } catch(PDOException $e) {
            echo "Connection failed" . $e ->getMessage();
        }
    }

    public function run($sql, $placeholders) {
        $stmt = $this->dbh->prepare($sql);
        $stmt->execute($placeholders);
        return $stmt;
    }
}

?>'

