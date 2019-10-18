#ifndef DisplayDriver_h
#define DisplayDriver_h

#include <Arduino.h>

class DisplayDriver
{
  public:
  DisplayDriver(byte RegisterSelect, byte Enable, byte DB0, byte DB1, byte DB2, byte DB3, byte DB4, byte DB5, byte DB6, byte DB7)
  {
    RS = RegisterSelect;
    EN = Enable;
    dataPins[0] = DB0;
    dataPins[1] = DB1;
    dataPins[2] = DB2;
    dataPins[3] = DB3;
    dataPins[4] = DB4;
    dataPins[5] = DB5;
    dataPins[6] = DB6;
    dataPins[7] = DB7;
    charQuantity = 0;
    pinMode(RegisterSelect, OUTPUT);
    pinMode(Enable, OUTPUT);
    for(int i = 0; i < 8; i++){
      pinMode(dataPins[i], OUTPUT);
    }
  };
  void sendData(bool isData, byte data);
  void init(bool mode);
  void shiftCursorToRight();
  void sendChar(char c);
  void sendChar(char* c);
  void sendString(String s);
  void skipLine();
  void cursorToHome();
  void goToExtendedInstructionSet();
  void goToReducedInstructionSet();
  void sendPixel(byte x, byte y);
  void clearDisplay();
  void enBlink();  
  void disBlink();
  void lineJump();
  void disCursor();
  void enCursor();
  
  private:
  bool extendedMode;
  byte lineIDX;
  byte charQuantity;
  byte RS;
  byte EN;
  byte dataPins[8];
  byte initializeByte = 15;
  const byte secondInitializeByte = 48;
  const byte shiftCursorByte = 22;
  const byte cursorToHomeByte = 3;
  const byte reducedInstructionSet8Bit = 48;
  const byte extendedInstructionSet8Bit = 52;
};

#endif
