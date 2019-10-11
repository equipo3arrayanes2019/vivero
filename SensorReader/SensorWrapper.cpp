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
    String Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->air->hId + String("&value=") + String(zones[i]->air->humidity());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->air->tId + String("&value=") + String(zones[i]->air->temperature());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->soil->hId + String("&value=") + String(zones[i]->soil->humidity());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->soil->tId + String("&value=") + String(zones[i]->soil->temperature());
    HTTPSender::send(Data, server);
  }
  Serial.println("-------------------------------         end       --------------------------------");
  Serial.println("");
}

void SensorWrapper::askIfPump(){
  Serial.println("-------------------------------Sending sensor data--------------------------------");
  for(int i = 0; i < zoneCount; i++){
    String Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->air->hId + String("&value=") + String(zones[i]->air->humidity());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->air->tId + String("&value=") + String(zones[i]->air->temperature());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->soil->hId + String("&value=") + String(zones[i]->soil->humidity());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + zones[i]->soil->tId + String("&value=") + String(zones[i]->soil->temperature());
    HTTPSender::send(Data, server);
  }
  Serial.println("-------------------------------         end       --------------------------------");
  Serial.println("");
}
