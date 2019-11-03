#include <Arduino.h>


#pragma once

class SHT{

  public:
    SHT():
      ta_(0), ha_(0), ts_(0), hs_(0)
    {
      c = new int(0);
    }

    float ta();
    float ha();
    float ts();
    float hs();

  private:
    float ta_, ha_, ts_, hs_;
    int* c;
    void read();
  
};
