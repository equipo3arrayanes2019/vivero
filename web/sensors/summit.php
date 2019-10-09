<?php

//summit.php?sensor=ARD02 HUMIDITYAIR01&value=25.3

include_once "MySQL.php";

if(isset($_GET["sensor"])){
    $conn = new MySQL();
    $sensor = $conn->real_escape_string($_GET["sensor"]);
    $value = $conn->real_escape_string($_GET["value"]);
    //get sensor current location
    $result = $conn->query("SELECT `Zona_nombre` FROM `Sensor` WHERE `id`= '$sensor';");
    if(!$result->num_rows > 0){
        die("Sensor $sensor no registrado");
    }
    $sensorLcoation = $result->fetch_array(MYSQLI_NUM)[0];
    //post data to database
    $date = date("Y-m-d H:i:s", time());
    $query="INSERT INTO `Medicion`(`fecha`, `valor`, `Zona_nombre`, `Sensor_id`) VALUES ('$date', $value, '$sensorLcoation', '$sensor');";
    //echo $query;
    $conn->query($query);
    $conn->close();
}
