#include "Zone.h"
#include <Arduino.h>


void Zone::waterOn(){
  digitalWrite(waterPin, 1);
}

void Zone::waterOff(){
  digitalWrite(waterPin, 0);
}
