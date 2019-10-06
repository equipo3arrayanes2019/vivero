<?php

class MySQL extends mysqli{

function __construct(){
    parent::__construct("localhost", "sensor", "123", "MeGusta", 3306);
}

}