#include "DHTReader.h"
#include "Logger.h"

float DHTReader::temperature(){
  float t = dht.readTemperature();
  Logger::logsinfo(String("Temperature: ") + String(t) + String("°C"));
  return t;
}

float DHTReader::humidity(){
  float h = dht.readHumidity();
  Logger::logsinfo(String("Humidity: ") + String(h) + String("%"));
  return h;
}
