#include "SensorWrapper.h"

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

void SensorWrapper::SummitData(){
  for(int i = 0; i < SensorCount; i++){
    String Data = String("summit.php?sensor=") + *humidityIds[i] + String("&value=") + String(dhts[i]->humidity());
    Serial.println(Data);
    Data = String("summit.php?sensor=") + *temperatureIds[i] + String("&value=") + String(dhts[i]->temperature());
    Serial.println(Data);
  }
}
