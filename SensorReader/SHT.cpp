#include "SHT.h"
#include "Logger.h"
#include <Arduino.h>
#include <Wire.h>

float SHT::ta(){
  read();
  return ta_;
}

float SHT::ha(){
  read();
  return ha_;
}

float SHT::ts(){
  read();
  return ts_;
}

float SHT::hs(){
  read();
  return hs_;
}

void SHT::read(){
  for(int i = 0; i < 8; i++){
    Wire.requestFrom(8, 6);    // request 6 bytes from slave device #8
    String r;
    while (Wire.available()) { // slave may send less than requested
      char cc = Wire.read();       // print the character
      r = r + cc;
    }
    if(r.indexOf("coso") != -1){
      *c = 0;
      continue;
    }
    switch(*c){
      case 0:{
        Logger::logsinfo(String("Fake sensor temp air: ") + r);
        ta_ = r.toFloat();
        break;
      }
      case 1:{
        Logger::logsinfo(String("Fake sensor hum air: ") + r);
        ha_ = r.toFloat();
        break;
      }
      case 2:{
        Logger::logsinfo(String("Fake sensor temp soil: ") + r);
        ts_ = r.toFloat();
        break;
      }
      case 3:{
        Logger::logsinfo(String("Fake sensor hum soil: ") + r);
        hs_ = r.toFloat();
        break;
      }
    }
    *c = *c + 1;
  }
}
