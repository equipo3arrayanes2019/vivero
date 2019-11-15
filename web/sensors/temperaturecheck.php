<?php

//temperaturecheck.php?temperatureAIR=8&temperatureSOIL=0

if(isset($_GET["temperatureAIR"]) && isset($_GET["temperatureSOIL"])){
    $tempAIR = $_GET["temperatureAIR"];
    $tempSOIL = $_GET["temperatureSOIL"];
    if($tempAIR - $tempSOIL >= 5 && $tempSOIL <= 3 && $tempSOIL > 0){
        $out="WATER=1"; //WATER=1
    }else{
        $out="WATER=0"; //WATER=0
    }
    echo $out;
}