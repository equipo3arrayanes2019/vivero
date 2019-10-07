#pragma once

#include <Arduino.h>
#include "DHTReader.h"
#include "HumiditySoilReader"
#include "TemperatureSoilReader"


class SensorWrapper {
  public:
    SensorWrapper(word SensorCount, String** humidityIds, String** temperatureIds, dhts**, word* waterPins, word pumpPin,
                  String** humiditySoilIds, String** temperatureSoilIds, HumiditySoilReader** hr, TemperatureSoilReader** tr):
      DHTCount(DHTCount), himidityIds(humidityIds), temperatureIds(temperatureIds), dhts(dhts), waterPins(waterPins),
                  humiditySoilIds(humiditySoilIds), temperatureSoilIds(temperatureSoilIds), hr(hr), tr(tr)
    {
      
    }
    
    void SummitData();
    
  private:
    word SensorCount;
    String** humidityIds;
    String** temperatureIds;
    DHTReader** dhts;
    word* waterPins;
    String** humiditySoilIds;
    String** temperatureSoilIds;
    HumiditySoilReader** hr;
    TemperatureSoilReader** tr;
};
