<?php

//humiditycheck.php?sensor=ARD01 HUMIDITYAIR01&value=30&state=1

$UPPER_LIMIT=1;
$LOWER_LIMIT=2;

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
    $query="SELECT Especie.humedad, Especie.nombre FROM Especie RIGHT JOIN Planta on Planta.Especie_nombre = Especie.nombre INNER JOIN PlantaMaceta ON PlantaMaceta.Planta_id = Planta.id WHERE PlantaMaceta.Zona_nombre= '$sensorLocation';";
    //echo $query;
    $result = $conn->query($query);
    $num_plants=$result->num_rows;
    if(! $num_plants > 0){
        $plants=false;
    }else{
        while($row = $result->fetch_array(MYSQLI_NUM)){
            $totalHumidity+=$row[0];
        }
        $plants=true;
    }

    if(!$plants) die("No hay plantas en zona: $sensorLocation, Sensor: $sensorId");
    
    $AveregeRequiredHumidity=$totalHumidity/$num_plants;
    echo "AVRG: $AveregeRequiredHumidity<br/>\n";
    //echo "La humedad promedio es: $AveregeRequiredHumidity";
    if($state){
        //36
        if($AveregeRequiredHumidity + $UPPER_LIMIT < $value){
            $out="WATER=0";
        }else{
            $out="WATER=1";
        }
    }else{
        //27
        if($AveregeRequiredHumidity - $LOWER_LIMIT > $value){
            $out="WATER=1";
        }else{
            $out="WATER=0";
        }
    }
    $hour=date("H", time());

    if($out == 1 && !(($hour > 8 && $hour < 11) || ($hour > 17 && $hour < 21))){
        $out="WATER=0";
    }
    echo $out;
    $conn->close();
}