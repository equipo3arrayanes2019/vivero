#pragma once

#include <Arduino.h>
#include "DHTReader.h"
#include "HumiditySoilReader.h"
#include "TemperatureSoilReader.h"
#include "HTTPSender.h"


class SensorWrapper {
  public:
    SensorWrapper(const int SensorCount, String** humidityIds, String** temperatureIds, DHTReader** dhts, word* waterPins, word pumpPin,
                  String** humiditySoilIds, String** temperatureSoilIds, HumiditySoilReader** hr, TemperatureSoilReader** tr, char* server, String folder):
      SensorCount(SensorCount), humidityIds(humidityIds), temperatureIds(temperatureIds), dhts(dhts), waterPins(waterPins),
                  humiditySoilIds(humiditySoilIds), temperatureSoilIds(temperatureSoilIds), hr(hr), tr(tr), server(server), folder(folder)
    {
      
    }
    
    void summitData();
    
  private:
    int SensorCount;
    String** humidityIds;
    String** temperatureIds;
    DHTReader** dhts;
    word* waterPins;
    String** humiditySoilIds;
    String** temperatureSoilIds;
    HumiditySoilReader** hr;
    TemperatureSoilReader** tr;
    char* server;
    String folder;
};
