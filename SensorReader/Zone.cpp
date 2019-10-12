#include "Zone.h"
#include <Arduino.h>

void Zone::waterOnTimer(unsigned long time_){
  if(!timerPending){
    duration = time_;
    start = millis();
    timerPending = 1;
    Logger::logginfo(String("Turn on water timer: ")  + String(time_ / 1000) + String(" seconds active"));
    waterOn();
  }
}

void Zone::handleTimer(){
  if(timerPending)
    if(millis() - start >= duration){
      waterOff();
      timerPending=0;
    }
}

void Zone::waterOn(){
  Logger::logginfo(String("Turn on water"));
  digitalWrite(waterPin, LOW);
  registerWaterStart();
  waterState_=1;
}

void Zone::waterOff(){
  Logger::logginfo(String("Turn off water"));
  digitalWrite(waterPin, HIGH);
  registerWaterStop();
  waterState_=0;
}

void Zone::waterOffIfNotTimer(){
  if(!timerPending){
    waterOff();
  }
}

void Zone::registerWaterStart(){
  if(!waterState_)
    sender->addQueue(String("watering.php?sensor=") + soil->hId + String("&start=1"));
}

void Zone::registerWaterStop(){
  if(waterState_)
    sender->addQueue(String("watering.php?sensor=") + soil->hId + String("&start=0"));
}

bool Zone::waterState(){
  return waterState_;
}
