#include "ButtonMatrix.h"
#include "Menu.h"


#define ITEM_COUNT 4

//ButtonMatrix* bt;
word pins[] = { 53, 52, 51, 50, 49, 48, 47, 46 };
Menu* m;

char* itemNames[] = { "TempAir: ", "HumAir: ", "TempSuel: ", "HumSuel: " };

void setup() {
  Serial.begin(9600);
  m = new Menu(ITEM_COUNT, itemNames, ButtonMatrix(pins), 0.5);
}

void loop() {
  m->handle();
}
