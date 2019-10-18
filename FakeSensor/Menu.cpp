#include "Menu.h"


void Menu::refresh(){
  p->clearDisplay();
  for(int i = 0; i < itemCount; i++){
    if(i == cursor && editing){
      
    }else
    if(i == cursor && !editing)  p->sendChar("_>"){
      p->sendString(itemNames[i]);
      p->sendChar(" ");
      p->sendString(String(items[i]));
      p->sendChar(" ");
    }
  }
}

void Menu::handle(){
  if(bt.available() && millis() - last_press > BUTTON_INTERVAL){
    switch(bt.get()){
      case BUTTON_RIGHT:{
        if(!editing)
        cursor++;
        if(cursor == itemCount) cursor=0;
        break;
      }

      case BUTTON_LEFT:{
        if(!editing)
        cursor--;
        if(cursor < 0) cursor = itemCount-1;
        break;
      }

      case BUTTON_UP:{
        if(editing){
          items[cursor]+=step;
        }
        break;
      }

      case BUTTON_DOWN:{
        if(editing){
          items[cursor]-=step;
        }
        break;
      }

      case BUTTON_ENTER:{
        editing = !editing;
        break;
      }
    }
    refresh();
    last_press = millis();
  }
}
