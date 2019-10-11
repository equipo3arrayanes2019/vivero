#include "HumiditySoilReader.h"
#include <Arduino.h>
#include "Logger.h"
#include "SerialAsker.h"

float HumiditySoilReader::read(){
  int reading = analogRead(pin);
  adjust(reading);
  float curr = float(reading - min_);
  curr = (curr * 100) / float(USABLE);
  curr = 100.0 - curr;
  Logger::logsinfo(String("RAW: ") + String(reading) + String(" -- ") + String("Humidity ") + String(curr) +  String("% Humidity by volume"));
  return curr;
}

void HumiditySoilReader::adjust(int reading){
  if(reading > max_)
    max_ = reading;
  if(reading < min_)
    min_ = reading;
  USABLE =max_-min_;
  Logger::logsinfo(String("Humidity soil sensor calibration happened Lower limit ->") + String(LOWER_LIMIT) + String("    :::::     usable = ") + String(USABLE));
}
