#include <Arduino.h>
#include <WiFi.h>
#include "NetworkCommunication.h"
#include "Logger.h"

String NetworkCommunication::IpToString(IPAddress ip){
  return String(ip[0]) + "." + String(ip[1]) + "." + String(ip[2]) + "." + String(ip[3]);
}

String NetworkCommunication::send(char* ip, word port, String message){
  WiFiClient client;
  Logger::logwinfo(String("trying to connect: ") + String(ip) + String(":") + String(port));
  if(! client.connect(ip, port)){
    Logger::logwwarning((String("Connection FAIL to host : ") + String(ip) + String(":") + String(port)));
  }
  Logger::logwinfo((String("Sending: \n") + String("'") + message) + String("'"));
  client.print(message);
  unsigned long lastMillis = millis();
  Serial.print("Waiting");
  while(client.available() == 0){
    if(millis() - lastMillis > NetworkCommunication::TIMEOUT){
      Logger::logwwarning(String("TIMEOUT"));
      break;
    }
    if(millis() % 1500 > 0){
      Serial.print(".");
    }
  }
  Serial.println("");
  while(client.available()){
    message = client.readString();
    Logger::logwinfo(String("Recieved: \n") + String("'") + message + String("'"));
  }
  client.stop();
  return message;
}
