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
  adjust(reading, false);
}

void HumiditySoilReader::adjust(int reading, bool first){
  bool adjust_;
  if(reading > max_ || first){
    max_ = reading;
    adjust_ = 1;
  }
  if(reading < min_ ){
    min_ = reading; 
    adjust_ = 1;
  }
  USABLE =max_-min_;
  if(adjust_) Logger::logsinfo(String("Humidity soil sensor calibration happened Lower limit ->") + String(min_) + String("    :::::     usable = ") + String(USABLE) + String(" MAX: ") + String(max_));
}
