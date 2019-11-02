#include <Arduino.h>
#include "ButtonMatrix.h"
#include "DisplayDriver.h"

#pragma once


class Menu{

  #define BUTTON_DOWN    40
  #define BUTTON_UP  136
  #define BUTTON_RIGHT  33
  #define BUTTON_LEFT 17
  #define BUTTON_ENTER 18
  #define BUTTON_RESET 130
  #define BUTTON_INTERVAL 200
  
  public:
    Menu(int itemCount, char** itemNames, ButtonMatrix bt, float step, DisplayDriver* p):
      cursor(0), itemCount(itemCount), itemNames(itemNames), step(step), bt(bt), editing(false), p(p)
    {
      items = (float*)calloc(itemCount,sizeof(float)); //new float[itemCount];
    }

    void handle();
    void refresh();
    float get(int idx);
    
    float step;
  private:
    int cursor;
    int itemCount;
    char** itemNames;
    float *items;
    ButtonMatrix bt;
    DisplayDriver* p;
    bool editing;
    unsigned long last_press;
};
