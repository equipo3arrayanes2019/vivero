#include "HTGeneric.h"
#include "TemperatureSoilReader.h"
#include "HumiditySoilReader.h"
#include <Arduino.h>

#pragma once

class CHT : public HTGeneric {

  public:
    CHT(TemperatureSoilReader* ts, String tsId, HumiditySoilReader* hs, String hsId):
      ts(ts), hs(hs), HTGeneric(tsId, hsId)
    {
      
    }

    TemperatureSoilReader* ts;
    HumiditySoilReader* hs;

    float humidity();
    float temperature();

};
