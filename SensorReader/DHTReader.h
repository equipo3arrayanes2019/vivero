#include <Arduino.h>
#include <DHT.h>
#include "HTGeneric.h"


#pragma once

class DHTReader : public HTGeneric {
  public:
    
    DHTReader(word DHTPIN, int DHTTYPE, String tId, String hId):
      dht(DHTPIN, DHTTYPE), HTGeneric(tId, hId)
    {
      dht.begin();
      
    }
    ~DHTReader(){
      
    }

    float humidity();
    float temperature();
    
    private:
      DHT dht;
};
