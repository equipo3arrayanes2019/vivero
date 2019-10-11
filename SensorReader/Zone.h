#pragma once
#include <Arduino.h>
#include "HTGeneric.h"
#include "Logger.h"

class Zone{
   public:
    Zone(HTGeneric* soil, HTGeneric* air, word waterPin):
      soil(soil), air(air), waterPin(waterPin)
    {
      pinMode(waterPin, OUTPUT);
      waterOff();
      Logger::logginfo(String("Zone Loaded; water pin: ") + String(waterPin));
    }

    void waterOn();
    void waterOff();

    HTGeneric* soil;
    HTGeneric* air;
    word waterPin;
};
