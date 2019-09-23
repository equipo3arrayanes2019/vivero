#include <Arduino.h>
#include "SimpleLedRoutine.h"
#include "LedManager.h"

bool SimpleLedRoutine::run(){
  unsigned long now = millis();
  if((i < maxIterations && i != 0) || i == 1)
  {
    if(led->status()){
      if(now - lu >= OnTime){
        led->Off();
        lu = now;
        i++;
      }
    }else{
      if(now - lu >= OffTime){
        led->On();
        lu = now;
        i++;
      }
    }
  }else{
    return false;
  }
  return true;
}


void SimpleLedRoutine::setMaxIterations(word maxIterations){
  if(maxIterations != 0 && maxIterations != 1){
        this->maxIterations = maxIterations +2;
        i = 2;
  }else{
    this->maxIterations = maxIterations;
  }
}
