#include <Arduino.h>

#pragma once

class HTGeneric{

  public:
    HTGeneric(String tId, String hId):
      tId(tId), hId(hId)
    {
      
    }

    virtual float humidity()=0;
    virtual float temperature()=0;
    
    String tId;
    String hId;
  
};
