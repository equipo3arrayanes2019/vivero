#include "ButtonMatrix.h"


byte ButtonMatrix::get(){
  return data;
}

bool ButtonMatrix::available(){
  byte d = read();
  if(d !=  normal){
    data = d;
    return 1;
  }
  return 0;
}

void ButtonMatrix::aquireNormal(){
  normal = read();
}

byte ButtonMatrix::read(){
  byte out = 0;
  for(int i = 0; i < 8; i++){
    pinMode(pins[i], OUTPUT);
    digitalWrite(pins[i], 1);
    for(int j = 0; j < 8; j++){
      if(j == i) continue;
      pinMode(pins[j], INPUT);
      bool r = digitalRead(pins[j]);
      if(r){
        bitSet(out, j);
        bitSet(out, i);
      }
    }
    digitalWrite(pins[i], 0);
  }
  return out;
}
