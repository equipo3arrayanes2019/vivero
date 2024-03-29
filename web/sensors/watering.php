<?php

/*
    if start is 1 adds a new register
    if start is 0 updates the null registers with the recived
    duration value via $_GET 
    if recived "HOWMUCH" via get tells the controller board how much the water should be on
    when trying to avoid burns due to cold
*/
ini_set('display_errors', 1);
ini_set('display_startup_errors', 1);
error_reporting(E_ALL);
include_once "MySQL.php";

if(isset($_GET["start"]) && isset($_GET["sensor"])){
    if($_GET["start"] == 1){
        $conn = new MySQL();
        $sensor = $conn->real_escape_string($_GET["sensor"]);
        $result = $conn->query("SELECT `Zona_nombre` FROM `Sensor` WHERE `id`= '$sensor';");
        if(!$result->num_rows > 0){
            die("Sensor $sensor no registrado");
        }
        $sensorLcoation = $result->fetch_array(MYSQLI_NUM)[0];
        $date = date("Y-m-d H:i:s", time());

        $result = $conn->query("SELECT EXISTS (SELECT * FROM Riego WHERE Zona_nombre = '$sensorLcoation' AND duracion IS NULL);");
        if(!$result->num_rows > 0){
            die("No data");
        }
        if($result->fetch_array(MYSQLI_NUM)[0] == 1){
            die("Already active");
        }
        $query= "INSERT INTO `Riego`(`fecha`, `Zona_nombre`) VALUES ('$date', '$sensorLcoation');";
        $conn->query($query);
        $conn->close();
    }else{
        $conn = new MySQL();
        $sensor = $conn->real_escape_string($_GET["sensor"]);
        //$value = $conn->real_escape_string($_GET["value"]);
        $result = $conn->query("SELECT `Zona_nombre` FROM `Sensor` WHERE `id`= '$sensor';");
        if(!$result->num_rows > 0){
            die("Sensor $sensor no registrado");
        }
        if(!$result->num_rows > 0){
            die("Sensor $sensor no registrado");
        }
        $sensorLcoation = $result->fetch_array(MYSQLI_NUM)[0];
        $result = $conn->query("SELECT fecha FROM Riego WHERE Zona_nombre = '$sensorLcoation' AND duracion IS NULL;");
        if(!$result->num_rows > 0){
            die("No data");
        }
        $value = time() - strtotime($result->fetch_array(MYSQLI_NUM)[0]);
        $query= "UPDATE `Riego` SET `duracion`=$value WHERE `duracion` IS NULL AND `Zona_nombre`='$sensorLcoation';";
        $conn->query($query);
        $conn->close();
        
    }
    exit(0);    
}
if(isset($_GET["HOWMUCH"])){
    echo "HOWMUCH=20";
}