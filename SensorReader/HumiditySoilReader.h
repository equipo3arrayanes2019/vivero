#include <Arduino.h>
#include "Logger.h"

#pragma once

class HumiditySoilReader{
  private:
    //static const int UPPER_LIMIT = 3000;
    static const int SAMPLES = 500;
  
  public:
    
    HumiditySoilReader(word pin):
      min_(2340), max_(2740), USABLE(400), pin(pin)
    {
      pinMode(pin, INPUT);
      Logger::logsinfo(String("Soil moisture sensor on pin: ") + String(pin));
    }
  
    float read();
    void adjust(int);
    
  private:
    int min_, max_;
    int LOWER_LIMIT;
    int USABLE;
    word pin;
};
 
