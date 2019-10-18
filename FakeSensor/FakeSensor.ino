#include "ButtonMatrix.h"
#include "Menu.h"


#define ITEM_COUNT 4

//ButtonMatrix* bt;
word pins[] = { 53, 52, 51, 50, 49, 48, 47, 46 };
DisplayDriver* p;
Menu* m;

char* itemNames[] = { "T A: ", "H A: ", "T S: ", "H S: " };

void setup() {
  Serial.begin(9600);
  p = new DisplayDriver((byte)22, (byte)23, (byte)24, (byte)25, (byte)26, (byte)27, (byte)28, (byte)29, (byte)30, (byte)31);
  p->disBlink();
  p->disCursor();
  m = new Menu(ITEM_COUNT, itemNames, ButtonMatrix(pins), 0.5, p);
  m->refresh();
}

void loop() {
  m->handle();
}
