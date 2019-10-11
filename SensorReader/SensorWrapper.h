#pragma once

#include <Arduino.h>
#include "DHTReader.h"
#include "HumiditySoilReader.h"
#include "TemperatureSoilReader.h"
#include "HTTPSender.h"
#include "Zone.h"


class SensorWrapper {
  public:
    SensorWrapper(const int zoneCount, Zone** zones, word pumpPin, char* server, String folder):
      zoneCount(zoneCount), zones(zones), pumpPin(pumpPin), server(server), folder(folder)
    {
      
    }
    
    void summitData();
    void askIfPump();
    
  private:
    int zoneCount;
    Zone** zones;
    word pumpPin;
    char* server;
    String folder;
};
