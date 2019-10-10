<?php

//humiditycheck.php?sensor=ARD01 HUMIDITYAIR01&value=30&state=1

$UPPER_LIMIT=3;
$LOWER_LIMIT=6;

include "MySQL.php";

if(isset($_GET["sensor"])){
    // get the plants on the arduino's location
    $conn = new MySQL();
    $sensorId = $conn->real_escape_string($_GET["sensor"]);
    $state = $_GET["state"];
    $value = $_GET["value"];
    $result = $conn->query("SELECT `Zona_Nombre` FROM `Sensor` WHERE id='$sensorId';");
    if(! $result->num_rows > 0){
        die("No se tiene registro de la ubicación del sensor $sensorId");
    }else{
        $sensorLocation=$result->fetch_array(MYSQLI_NUM)[0];
    }
    //Get all the plants for a given zone
    $result = $conn->query("SELECT `Especie`.`humedad` FROM `Zona` INNER JOIN `Planta` ON `Zona`.`nombre` = `Planta`.`Zona_nombre` INNER JOIN `Zona_has_Semilla` ON `Zona_has_Semilla`.`Zona_nombre` = `Zona`.`nombre` INNER JOIN `Semilla` ON `Zona_has_Semilla`.`Semilla_id` = `Semilla`.`id` INNER JOIN `Especie` ON `Semilla`.`Especie_nombre` = `Especie`.`nombre` OR `Planta`.`Especie_nombre` = `Especie`.`nombre` WHERE `Zona`.`nombre`= '$sensorLocation';");
    $num_plants=$result->num_rows;
    if(! $num_plants > 0){
        die("No se encontraron plantas en la zona $sensorLocation donde se encuentra el sensor $sensorId");
    }else{
        while($row = $result->fetch_array(MYSQLI_NUM)){
            $totalHumidity+=$row[0];
        }
    }
    $AveregeRequiredHumidity=$totalHumidity/$num_plants;

    //echo "La humedad promedio es: $AveregeRequiredHumidity";
    if($state){
        if($AveregeRequiredHumidity + $UPPER_LIMIT < $value){
            $out=0;
        }else{
            $out=1;
        }
    }else{
        if($AveregeRequiredHumidity - $LOWER_LIMIT > $value){
            $out=1;
        }else{
            $out=0;
        }
    }
    $hour=date("H", time());

    if($out == 1 && !(($hour > 8 && $hour < 11) || ($hour > 17 && $hour < 21))){
        $out=0;
    }
    echo $out;
    $conn->close();
}