#pragma once
#include <Arduino.h>
#include "HTGeneric.h"


class Zone{
   public:
    Zone(HTGeneric* soil, HTGeneric* air, word waterPin):
      soil(soil), air(air), waterPin(waterPin)
    {
      
    }

    void waterOn();
    void waterOff();

    HTGeneric* soil;
    HTGeneric* air;
    word waterPin;
};
