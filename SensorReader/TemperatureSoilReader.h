#include <Arduino.h>
#include <OneWire.h>           //must install OneWire library from library manager
#include <DallasTemperature.h> //must install DallasTemperature from library manager
#include "Logger.h"

#pragma once

class TemperatureSoilReader{
  public:
    TemperatureSoilReader(word pin):
      pin(pin), onewire(pin), sensor(&onewire)
    {
      sensor.begin();
    }

    float read();
  private:
    word pin;
    OneWire onewire;
    DallasTemperature sensor;
};
