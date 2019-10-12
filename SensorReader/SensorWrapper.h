#pragma once

#include <Arduino.h>
#include "DHTReader.h"
#include "HumiditySoilReader.h"
#include "TemperatureSoilReader.h"
#include "HTTPSender.h"
#include "Zone.h"


class SensorWrapper {
  public:
    SensorWrapper(const int zoneCount, Zone** zones, word pumpPin, HTTPSender* sender):
      zoneCount(zoneCount), zones(zones), pumpPin(pumpPin), sender(sender)
    {
      Logger::logginfo(String("Pump on pin: ") + String(pumpPin));
      pinMode(pumpPin, OUTPUT);
      pumpOff();
    }
    
    void summitData();
    void askIfPump();
    void checkPump();
    void pumpOn();
    void pumpOff();
    void handleTimers();
    
  private:
    int zoneCount;
    Zone** zones;
    word pumpPin;
    HTTPSender* sender;
};
