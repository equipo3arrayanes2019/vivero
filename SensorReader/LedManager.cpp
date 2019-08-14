#include <Arduino.h>
#include "LedManager.h"

void LedManager::On(){
  lstatus = 1;
  digitalWrite(*pin, lstatus);
}

void LedManager::Off(){
  lstatus = 0;
  digitalWrite(*pin, lstatus);
}

bool LedManager::status(){
  return lstatus;
}
