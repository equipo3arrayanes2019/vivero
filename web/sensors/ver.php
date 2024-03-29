<html>

<head>
<script>
setTimeout(function() { location.reload(); }, 5000);
</script>
<title>
    Sensores del vivero
</title>
</head>

<style>

    body{
        background-color: #b3c3c7;
    }
     table {
        border-collapse: collapse;
        width: 1fr;
        font-size: 30px;
    }
    th, td{
        border: 1px solid black;
        margin: 0px;
        font-family: console;
    }

    .TemperaturaSuelo{
        color: white;
        background-color: #c94a00;
    }

    .TemperaturaAire{
        color: white;
        background-color: #fc392b;
    }

    .HumedadSuelo{
        color: white;
        background-color: #02007a;
    }

    .HumedadAire{
        color: white;
        background-color: #3bb9db;
    }

</style>

<body>
<center>
<table>
    <tr>
        <td>
            Hora
        </td>
        <td>
            ID del sensor
        </td>
        <td>    
            Tipo del sensor
        </td>
        <td>    
            Valor
        </td>
    </tr>
<?php
    include 'MySQL.php';
    $conn = new MySQL();
    $today = date("Y-m-d", time());
    $hour = date("H", time());
    $minute = date("i", time());
    $lastminute = date("i", time() - 120);
    $query = "SELECT * FROM Medicion INNER JOIN Sensor ON Sensor.id= Medicion.Sensor_id ORDER BY fecha DESC LIMIT 20;";
    //$query = "SELECT Sensor.id, Medicion.* FROM Medicion INNER JOIN Sensor ON Sensor.id = Medicion.Sensor_id;";
    //echo $query;
    $result = $conn->query($query);
    $coso[$result->num_rows];
    $c=0;
    $isthere=false;
    if($result->num_rows > 0 ){
        while($row = $result->fetch_array(MYSQLI_ASSOC)){
            for($i = 0; $i < $result->num_rows; $i++){

                if($row["Sensor_id"] == $coso[$i]){
                    $isthere=true;
                }
            }
            if(!$isthere){
            echo "<tr class ='" . str_replace(" ", "", $row["tipo"]) . "'>";
            echo "<td>";
            echo date("H:i:s", strtotime($row["fecha"]));
            echo "</td>";
            echo "<td>";
            echo $row["Sensor_id"];
            echo "</td>";
            echo "<td>";
            echo $row["tipo"];
            echo "</td>";
            echo "<td style='font-weight: bold;'>";
            echo $row["valor"];
            if(strpos($row["tipo"], 'Humedad') !== false){
                echo "%";
            }
            if(strpos($row["tipo"], 'Temperatura') !== false){
                echo "°C";
            }
            echo "</td>";
            echo "</tr>";
            $coso[$c] = $row["Sensor_id"];
            $c++;
        }
        $isthere = false;
            
        }
    }
    $conn->close();
?>
</table>
</center>
</body>
