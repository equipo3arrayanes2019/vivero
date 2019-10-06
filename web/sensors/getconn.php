<?php

include_once "MySQL.php";

$conn = new MySQL();

if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
//echo "Connected successfully";