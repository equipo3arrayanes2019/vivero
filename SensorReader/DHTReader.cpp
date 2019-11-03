#include "DHTReader.h"
#include "Logger.h"

float DHTReader::temperature(){
  float t;
  do{
    t = dht.readTemperature();
    Logger::logsinfo(String("Temperature: ") + String(t) + String("°C"));
    delay(100);
  }while(String(t).equals(String("nan")));
  return t;
}

float DHTReader::humidity(){
  float h;
  do{
    h = dht.readHumidity();
    Logger::logsinfo(String("Humidity: ") + String(h) + String("%"));
    delay(100);
  }while(String(h).equals(String("nan")));
  return h;
}
