#include <Arduino.h>
#include "Logger.h"

#pragma once

class HumiditySoilReader{
  private:
    //static const int UPPER_LIMIT = 3000;
    static const int SAMPLES = 500;
  
  public:
    
    HumiditySoilReader(word pin):
      min_(2300), max_(2400), USABLE(100), pin(pin)
    {
      pinMode(pin, INPUT);
      int reading = analogRead(pin);
      adjust(reading, true);
      Logger::logsinfo(String("Soil moisture sensor on pin: ") + String(pin));
    }
  
    float read();
    void adjust(int);
    void adjust(int, bool);
    
  private:
    int min_, max_;
    int USABLE;
    word pin;
};
 
