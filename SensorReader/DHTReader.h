#pragma once

#include <Arduino.h>
#include <DHT.h>

class DHTReader {
  public:
    DHTReader(word DHTPIN, int DHTTYPE):
      dht(DHTPIN, DHTTYPE)
    {
      dht.begin();
    }
    ~DHTReader(){
      
    }

    float temperature();
    float humidity();
    
    private:
      DHT dht;
};
