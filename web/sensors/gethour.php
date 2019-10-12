<?php

if(isset($_GET["HOUR"])){
    $date = date("H:i:s", time());
    echo "hour=$date";
}

if(isset($_GET["WATER"])){
    $hour=(int)date("H", time());
    if(($hour > 8 && $hour < 11) || ($hour > 17 && $hour < 21)){
        $out="WATER=1"; //WATER=1
    }else{
        $out="WATER=0"; //WATER=0
    }
}
echo $out;