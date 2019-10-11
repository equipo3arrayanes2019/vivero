#pragma once
#include <Arduino.h>
#include "HTGeneric.h"
#include "Logger.h"

class Zone{
   public:
    Zone(HTGeneric* soil, HTGeneric* air, word waterPin):
      soil(soil), air(air), waterPin(waterPin), waterState_(0)
    {
      pinMode(waterPin, OUTPUT);
      waterOff();
      Logger::logginfo(String("Zone Loaded; water pin: ") + String(waterPin));
    }

    void waterOnTimer(unsigned long);
    void waterOn();
    void waterOff();
    bool waterState();
    void handleTimer();
    
    HTGeneric* soil;
    HTGeneric* air;
    
  private:
    word waterPin;
    bool waterState_;
    unsigned long start;
    unsigned long duration;
    bool timerPending;
};
