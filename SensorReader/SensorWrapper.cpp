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
  for(int i = 0; i < SensorCount; i++){
    Serial.println("-------------------------------Sending sensor data--------------------------------");
    String Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + *humidityIds[i] + String("&value=") + String(dhts[i]->humidity());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + *temperatureIds[i] + String("&value=") + String(dhts[i]->temperature());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + *humiditySoilIds[i] + String("&value=") + String(hr[i]->read());
    HTTPSender::send(Data, server);
    Data = String("http://") + String(server) + String("/") + folder + String("/") + String("summit.php?sensor=") + *temperatureSoilIds[i] + String("&value=") + String(tr[i]->read());
    HTTPSender::send(Data, server);
    Serial.println("-------------------------------         end       --------------------------------");
    Serial.println("");
  }
}
