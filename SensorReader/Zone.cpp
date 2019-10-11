#include "Zone.h"
#include <Arduino.h>


void Zone::waterOn(){
  digitalWrite(waterPin, HIGH);
}

void Zone::waterOff(){
  digitalWrite(waterPin, LOW);
}
