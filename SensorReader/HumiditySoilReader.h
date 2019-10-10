#include <Arduino.h>


#pragma once

class HumiditySoilReader{
  private:
    //static const int UPPER_LIMIT = 3000;
    static const int SAMPLES = 500;
  
  public:
    
    HumiditySoilReader(word pin):
      min(2340), max(2740), USABLE(400), pin(pin)
    {
      pinMode(pin, INPUT);
    }
  
    float read();
    void adjust(int);
  private:
    int min, max;
    int LOWER_LIMIT;
    int USABLE;
    word pin;
};
 
