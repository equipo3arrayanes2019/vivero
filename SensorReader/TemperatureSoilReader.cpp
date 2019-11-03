#include "TemperatureSoilReader.h"


float TemperatureSoilReader::read(){
   sensor.requestTemperatures();
   float r = sensor.getTempCByIndex(0);
   Logger::logsinfo(String("Reading temperature: ") + String(r) + String("°C"));
   return r;
}
