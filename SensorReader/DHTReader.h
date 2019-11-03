#include <Arduino.h>
#include <DHT.h>
#include "HTGeneric.h"
#include "Logger.h"

#pragma once

class DHTReader : public HTGeneric {
  public:
    
    DHTReader(word DHTPIN, int DHTTYPE, String tId, String hId):
      dht(DHTPIN, DHTTYPE), HTGeneric(tId, hId)
    {
      dht.begin();
      Logger::logsinfo(String("DHT") + String(DHTTYPE) +  String(" on pin: ") + String(DHTPIN));
      Logger::logsinfo(String("T Id: ") + tId + String("    :H Id:    ") + hId);
    }
    ~DHTReader(){
      
    }

    float humidity();
    float temperature();
    
    private:
      DHT dht;
};
