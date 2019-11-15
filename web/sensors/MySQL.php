<?php

class MySQL extends mysqli{

    function __construct(){
        parent::__construct("localhost", "sensor", "123", "MeGusta", 3306);
        if ($this->connect_error) {
            die("Connection failed: " . $this->connect_error);
        }
    }

}
