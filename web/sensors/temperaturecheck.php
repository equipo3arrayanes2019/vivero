<?php

if(isset($_GET["temperatureAIR"]) && isset($_GET["temperatureSOIL"])){
    $tempAIR = $_GET["temperatureAIR"];
    $tempSOIL = $_GET["temperatureSOIL"];
    if($tempAIR - $tempSOIL >= 5 && $tempSOIL <= 3){
        $out=1;
    }else{
        $out=0;
    }
    echo $out;
}