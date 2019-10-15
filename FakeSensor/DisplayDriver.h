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
  };
  void SendData(bool isData, byte data);
  void Initialize(bool mode);
  void ShiftCursorToRight();
  void SendChar(char c);
  void SendString(String s);
  void SkipLine();
  void CursorToHome();
  void GoToExtendedInstructionSet();
  void GoToReducedInstructionSet();
  void SendPixel(byte x, byte y);
  void ClearDisplay();
  
  private:
  bool extendedMode;
  byte lineIDX;
  byte charQuantity;
  byte RS;
  byte EN;
  byte dataPins[8];
  const byte initializeByte = 12;
  const byte secondInitializeByte = 48;
  const byte shiftCursorByte = 22;
  const byte cursorToHomeByte = 3;
  const byte reducedInstructionSet8Bit = 48;
  const byte extendedInstructionSet8Bit = 52;
};

#endif
