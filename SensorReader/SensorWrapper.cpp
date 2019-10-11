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
    String Data = buildString() + String("summit.php?sensor=") + zones[i]->air->hId + String("&value=") + String(zones[i]->air->humidity());
    HTTPSender::send(Data, server);
    Data = buildString() + String("summit.php?sensor=") + zones[i]->air->tId + String("&value=") + String(zones[i]->air->temperature());
    HTTPSender::send(Data, server);
    Data = buildString() + String("summit.php?sensor=") + zones[i]->soil->hId + String("&value=") + String(zones[i]->soil->humidity());
    HTTPSender::send(Data, server);
    Data = buildString() + String("summit.php?sensor=") + zones[i]->soil->tId + String("&value=") + String(zones[i]->soil->temperature());
    HTTPSender::send(Data, server);
  }
  Serial.println("-------------------------------         end       --------------------------------");
  Serial.println("");
}

void SensorWrapper::askIfPump(){
  Logger::logginfo(String("asking if it is time to water the plants"));
  String Data = buildString() + String("gethour.php?WATER");
  String result = HTTPSender::send(Data, server);
  if(result.indexOf("WATER=1") != -1){
    for(int i = 0; i < zoneCount; i++){
      Logger::logginfo(String("Asking if watering is needed based on humidity"));
      Data = buildString() + String("humiditycheck.php?sensor=") + zones[i]->soil->hId + String("&value=") + zones[i]->soil->humidity() + String("&state=") + String(zones[i]->waterState());
      result = HTTPSender::send(Data, server);
      if(result.indexOf("WATER=1") != -1){
        zones[i]->waterOn();
      }else{
        zones[i]->waterOff();
      }
    }
  }else{
      for(int i = 0; i < zoneCount; i++){
        Logger::logginfo(String("Asking how much time to turn on water"));
        Data = buildString() + String("watering.php?HOWMUCH");
        result = HTTPSender::send(Data, server);
        int howmuch = result.substring(result.indexOf("HOWMUCH=") + 7).toInt();
        Logger::logginfo(String("Detected time:") + String(howmuch));
        Logger::logginfo(String("Asking if watering is needed based on temperature"));
        Data = buildString() + String("temperaturecheck.php?temperatureAIR=") + String(zones[i]->air->temperature()) + String("&temperatureSOIL=") + String(zones[i]->soil->temperature());
        result = HTTPSender::send(Data, server);
        if(result.indexOf("WATER=1") != -1){
          zones[i]->waterOnTimer(howmuch);
        }
      }
  }
  checkPump();
}

String SensorWrapper::buildString(){
  return String("http://") + String(server) + String("/") + folder + String("/");
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
  digitalWrite(pumpPin, 0);
}

void SensorWrapper::pumpOff(){
  digitalWrite(pumpPin, 1);
}


void SensorWrapper::handleTimers(){
  for(int i = 0; i < zoneCount; i++){
    zones[i]->handleTimer();
  }
}
