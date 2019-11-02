#include "SHT.h"
#include "HTGeneric.h"

#pragma once


class SHTR : public HTGeneric {
  public:
    SHTR(SHT* s, bool soil, String tId, String hId):
      s(s), soil(soil), HTGeneric(tId, hId)
    {
      
    }

    float humidity();
    float temperature();
    
  private:
    SHT* s;
    bool soil;
};
