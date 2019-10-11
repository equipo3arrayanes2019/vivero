<?php

if(isset($_GET["HOUR"])){
    $date = date("H:i:s", time());
    echo $date; 
}

if(isset($_GET["WATER"])){
    if($out == 1 && !(($hour > 8 && $hour < 11) || ($hour > 17 && $hour < 21))){
        $out=0;
    }
}
echo $out;