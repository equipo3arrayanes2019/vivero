#include <Arduino.h>
#include "LedManager.h"

#pragma once

class SimpleLedRoutine{
  public:
    SimpleLedRoutine(LedManager* Led, word onTime, word offTime, word maxIterations){
      this->led = Led;
      led->Off();
      this->OffTime = offTime;
      this->OnTime = onTime;
      setMaxIterations(maxIterations);
    }
    bool run();
    void setMaxIterations(word maxIterations);

  private:
    LedManager* led;
    word OffTime;
    word OnTime;
    unsigned long lu;
    word maxIterations;
    word i;
};
