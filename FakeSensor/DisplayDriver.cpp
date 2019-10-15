#include <Arduino.h>
#include "DisplayDriver.h"

void DisplayDriver::ClearDisplay()
{
  for(byte b = 0; b < 64; b++)
  {
    SendChar(' ');
  }
  CursorToHome();
}

void DisplayDriver::SendPixel(byte vertical, byte horizontal)
{
  horizontal += 128;
  vertical += 128;
  if(extendedMode && vertical < 192 && horizontal < 144)
  {
    SendData(false, horizontal);
    SendData(false, vertical);
  }
}

void DisplayDriver::GoToExtendedInstructionSet()
{
  SendData(false, extendedInstructionSet8Bit);
  extendedMode = true;
}

void DisplayDriver::GoToReducedInstructionSet()
{
  SendData(false, reducedInstructionSet8Bit);
  extendedMode = false;
}

void DisplayDriver::CursorToHome()
{
  SendData(false, cursorToHomeByte);
}

void DisplayDriver::SkipLine()
{
  for(byte b = 0; b < 8; b++)
  {
    ShiftCursorToRight();
  }
}

void DisplayDriver::SendString(String s)
{
  for(int i = 0; i < s.length(); i++)
  {
    SendChar(s.charAt(i));
  }
}

void DisplayDriver::SendChar(char c)
{
  SendData(true, c);
  charQuantity++;
  if(charQuantity == 16)
  {
    SkipLine();
  }
  if(charQuantity == 32)
  {
    CursorToHome();
    SkipLine();
  }
  if(charQuantity == 48)
  {
    SkipLine();
  }
  if(charQuantity == 64)
  {
    charQuantity = 0;
    CursorToHome();
  }
}

void DisplayDriver::ShiftCursorToRight()
{
  SendData(false, shiftCursorByte);
}

void DisplayDriver::Initialize(bool mode)
{
  for(byte i = 0; i < 8; i++)
  {
    pinMode(dataPins[i], OUTPUT);
  }
  pinMode(EN, OUTPUT);
  pinMode(RS, OUTPUT);
  digitalWrite(EN, LOW);
  extendedMode = mode;
  if(mode)
  {
    GoToExtendedInstructionSet();
    SendData(false, initializeByte);  
  }
  else
  {
    GoToReducedInstructionSet();
    SendData(false, initializeByte);
    SendData(false, secondInitializeByte);
    CursorToHome();
  }
  
}

void DisplayDriver::SendData(bool isData, byte data)
{
  digitalWrite(RS, isData);
  for(byte i = 0; i < 8; i++)
  {
    bool toSend = bitRead(data, i);
    digitalWrite(dataPins[i], toSend);
  }
  digitalWrite(EN, HIGH);
  digitalWrite(EN, LOW);
  digitalWrite(RS, LOW);
}

