#include "Zone.h"
#include <Arduino.h>

void Zone::waterOnTimer(unsigned long time_){
  duration = time_;
  start = millis();
  timerPending = 1;
  waterOn();
}

void Zone::handleTimer(){
  if(timerPending)
    if(millis() - start >= duration){
      waterOff();
      timerPending=0;
    }
}

void Zone::waterOn(){
  digitalWrite(waterPin, LOW);
  waterState_=1;
}

void Zone::waterOff(){
  digitalWrite(waterPin, HIGH);
  waterState_=0;
}

bool Zone::waterState(){
  return waterState_;
}
