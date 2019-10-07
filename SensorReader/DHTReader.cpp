#include "DHTReader.h"

float DHTReader::temperature(){
  return dht.readTemperature();
}

float DHTReader::humidity(){
  return dht.readHumidity();
}
