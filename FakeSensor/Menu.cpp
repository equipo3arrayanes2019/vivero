#include "Menu.h"


void Menu::refresh(){
  p->clearDisplay();
  for(int i = 0; i < itemCount; i++){
    if(i == cursor && editing){
      p->sendChar(itemNames[i]);
      p->lineJump();
      p->sendChar("<= ");
      p->sendString(String(items[i]));
      p->sendChar(" =>");
    }else
    if(i == cursor && !editing){
      p->sendChar("_>");
    }else if(!editing && i != cursor){
      p->sendChar("  ");
    }

    if(!editing){
      bool go = 1;
      String out;
      for(int j = 0; j < strlen(itemNames[i]); j++){
        if(go){
          out += String(itemNames[i][j]) + String(".");
          go=0;
        }
        if(go == 0 && itemNames[i][j] == ' '){
          go = 1;
        }
      }
      out += String(": ") + String(items[i]);
      p->sendString(out);
      p->lineJump();
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

float Menu::get(int idx){
  return items[idx];
}
