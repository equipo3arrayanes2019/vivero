#include "HTGeneric.h"
#include "TemperatureSoilReader.h"
#include "HumiditySoilReader.h"
#include "Logger.h"
#include <Arduino.h>

#pragma once

class CHT : public HTGeneric {

  public:
    CHT(TemperatureSoilReader* ts, String tsId, HumiditySoilReader* hs, String hsId):
      ts(ts), hs(hs), HTGeneric(tsId, hsId)
    {
      Logger::logsinfo(String("CHT: T Id: ") + tsId + String(" H Id: ") + hsId);
    }

    TemperatureSoilReader* ts;
    HumiditySoilReader* hs;

    float humidity();
    float temperature();

};
