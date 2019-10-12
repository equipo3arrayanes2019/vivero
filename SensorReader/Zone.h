#pragma once
#include <Arduino.h>
#include "HTGeneric.h"
#include "Logger.h"
#include "HTTPSender.h"

class Zone{
   public:
    Zone(HTGeneric* soil, HTGeneric* air, word waterPin, HTTPSender* sender):
      soil(soil), air(air), waterPin(waterPin), waterState_(0), sender(sender)
    {
      pinMode(waterPin, OUTPUT);
      waterOff();
      Logger::logginfo(String("Zone Loaded; water pin: ") + String(waterPin));
    }

    void waterOnTimer(unsigned long);
    void waterOn();
    void waterOff();
    void waterOffIfNotTimer();
    bool waterState();
    void handleTimer();

    
    HTGeneric* soil;
    HTGeneric* air;
    
  private:
    void registerWaterStart();
    void registerWaterStop();

    word waterPin;
    bool waterState_;
    HTTPSender* sender;
    unsigned long start;
    unsigned long duration;
    bool timerPending;
};
