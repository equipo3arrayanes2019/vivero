#include <Arduino.h>

#pragma once


class ButtonMatrix{

  public:
    ButtonMatrix(word* pins):
      normal(0), data(0), pins(pins)
    {
      aquireNormal();
    }
    bool available();
    byte get();
    
  private:
    byte read();
    void aquireNormal();
    byte normal;
    byte data;
    word* pins;
};
