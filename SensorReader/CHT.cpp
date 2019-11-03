#include "CHT.h"


float CHT::temperature(){
  return ts->read();
}

float CHT::humidity(){
  return hs->read();
}
