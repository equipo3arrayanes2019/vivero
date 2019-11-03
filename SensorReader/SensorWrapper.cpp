#include "SensorWrapper.h"
#include "Logger.h"

/*
 *  word DHTCount;
    String** humidityIds;
    String** temperatureIds;
    DHTReader** dhts;
    word* waterPins;
    String** humiditySoilIds;
    String** temperatureSoilIds;
    HumiditySoilReader** hr;
    TemperatureSoilReader** tr;
 */

void SensorWrapper::summitData(){
  Serial.println("-------------------------------Sending sensor data--------------------------------");
  for(int i = 0; i < zoneCount; i++){
    String Data = String("summit.php?sensor=") + zones[i]->air->hId + String("&value=") + String(zones[i]->air->humidity());
    sender->addQueue(Data);
    Data = String("summit.php?sensor=") + zones[i]->air->tId + String("&value=") + String(zones[i]->air->temperature());
    sender->addQueue(Data);
    Data = String("summit.php?sensor=") + zones[i]->soil->hId + String("&value=") + String(zones[i]->soil->humidity());
    sender->addQueue(Data);
    Data = String("summit.php?sensor=") + zones[i]->soil->tId + String("&value=") + String(zones[i]->soil->temperature());
    sender->addQueue(Data);
  }
  Serial.println("-------------------------------         end       --------------------------------");
  Serial.println("");
}

void SensorWrapper::askIfPump(){
  Serial.println("-------------------------------   Taking care ;)  --------------------------------");
  Logger::logginfo(String("asking if it is time to water the plants"));
  String Data = String("gethour.php?WATER");
  String result = sender->send(Data);
  if(result.indexOf("WATER=1") != -1){
    for(int i = 0; i < zoneCount; i++){
      Logger::logginfo(String("Asking if watering is needed based on humidity"));
      Data = String("humiditycheck.php?sensor=") + zones[i]->soil->hId + String("&value=") + zones[i]->soil->humidity() + String("&state=") + String(zones[i]->waterState());
      result = sender->send(Data);
      if(result.indexOf("WATER=1") != -1){
        zones[i]->waterOn();
        checkPump();
      }else{
        zones[i]->waterOff();
        checkPump();
      }
    }
  }else{
      for(int i = 0; i < zoneCount; i++){
        Logger::logginfo(String("Asking how much time to turn on water"));
        Data = String("watering.php?HOWMUCH");
        result = sender->send(Data);
        String time = result.substring(result.indexOf("HOWMUCH=") + 8); // 8 is the number of characters on the string so we offset by that ammount to skip it and take the value
        int howmuch = time.toInt();
        Logger::logginfo(String("Detected time:") + String(howmuch));
        Logger::logginfo(String("Asking if watering is needed based on temperature"));
        Data = String("temperaturecheck.php?temperatureAIR=") + String(zones[i]->air->temperature()) + String("&temperatureSOIL=") + String(zones[i]->soil->temperature());
        result = sender->send(Data);
        if(result.indexOf("WATER=1") != -1){
          zones[i]->waterOnTimer(howmuch * 1000);
          checkPump();
        }else{
          zones[i]->waterOffIfNotTimer();
          checkPump();
        }
      }
  }
  Serial.println("-------------------------------         end       --------------------------------");
  Serial.println("");
}

void SensorWrapper::checkPump(){
  for(int i = 0; i < zoneCount; i++){
    if(zones[i]->waterState()){
      pumpOn();
      return;
    }
  }
  pumpOff();
}

void SensorWrapper::pumpOn(){
  Logger::logginfo(String("Pump turned on"));
  digitalWrite(pumpPin, 0);
}

void SensorWrapper::pumpOff(){
  Logger::logginfo(String("Pump turned off"));
  digitalWrite(pumpPin, 1);
}


void SensorWrapper::handleTimers(){
  for(int i = 0; i < zoneCount; i++){
    zones[i]->handleTimer();
    checkPump();
  }
}
