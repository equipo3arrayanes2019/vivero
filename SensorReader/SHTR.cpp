#include "SHTR.h"


float SHTR::humidity(){
  if(soil){
    return s->hs();
  }else{
    return s->ha();
  }
}

float SHTR::temperature(){
  if(soil){
    return s->ts();
  }else{
    return s->ta();
  }
}
