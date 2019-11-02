#include <Wire.h>

#include "ButtonMatrix.h"
#include "Menu.h"

#define ITEM_COUNT 4

//ButtonMatrix* bt;
word pins[] = { 53, 52, 51, 50, 49, 48, 47, 46 };
DisplayDriver* p;
Menu* m;

char* itemNames[] = { "Temp. Aire", "Humedad Aire", "Temp. Suelo", "Humedad Suelo" };

char buff[6];

int* c;

void setup() {
  Serial.begin(9600);
  p = new DisplayDriver((byte)22, (byte)23, (byte)24, (byte)25, (byte)26, (byte)27, (byte)28, (byte)29, (byte)30, (byte)31);
  p->disBlink();
  p->disCursor();
  p->init(false);
  m = new Menu(ITEM_COUNT, itemNames, ButtonMatrix(pins), 0.5, p);
  m->refresh();
  c = new int(0);
  Wire.begin(8);
  Wire.onRequest(requestEvent);
}

void loop() {
  m->handle();
}

void requestEvent() {
  if(*c > 3){
    Wire.write("coso");
    *c = 0;
    return;
  }
  dtostrf(m->get(*c), 6, 2, buff);
  *c = *c = *c + 1;
  Wire.write(buff);
  
}
