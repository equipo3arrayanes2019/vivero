#include <Arduino.h>

#pragma once

class LedManager{

  public:
    LedManager(byte* pin){
      this->pin = pin;
      pinMode(*pin, OUTPUT);
      digitalWrite(*pin, 0);
    }
    
    void On();
    void Off();
    bool status();

  private:
    bool lstatus;
    byte* pin;
  
};
