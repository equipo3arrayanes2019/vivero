#include "HumiditySoilReader.h"
#include <Arduino.h>
#include "Logger.h"
#include "SerialAsker.h"

float HumiditySoilReader::read(){
  int reading = analogRead(pin);
  adjust(reading);
  float curr = float(reading - min);
  Serial.println(USABLE);
  curr = (curr * 100) / float(USABLE);
  curr = 100.0 - curr;
  Logger::logsinfo(String("RAW: ") + String(reading) + String(" -- ") + String("Humidity ") + String(curr) +  String("% Humidity by volume"));
  return curr;
}

void HumiditySoilReader::adjust(int reading){
  if(reading > max)
    max = reading;
  if(reading < min)
    min = reading;
  USABLE =max-min;
  Serial.println(String("Humidity soil sensor calibration happened Lower limit ->") + String(LOWER_LIMIT) + String("    :::::     usable = ") + String(USABLE));
}
