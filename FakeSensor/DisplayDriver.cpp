#include <Arduino.h>
#include "DisplayDriver.h"

void DisplayDriver::clearDisplay()
{
  for(byte b = 0; b < 64; b++)
  {
    sendChar(' ');
  }
  cursorToHome();
}

void DisplayDriver::sendPixel(byte vertical, byte horizontal)
{
  horizontal += 128;
  vertical += 128;
  if(extendedMode && vertical < 192 && horizontal < 144)
  {
    sendData(false, horizontal);
    sendData(false, vertical);
  }
}

void DisplayDriver::goToExtendedInstructionSet()
{
  sendData(false, extendedInstructionSet8Bit);
  extendedMode = true;
}

void DisplayDriver::goToReducedInstructionSet()
{
  sendData(false, reducedInstructionSet8Bit);
  extendedMode = false;
}

void DisplayDriver::cursorToHome()
{
  sendData(false, cursorToHomeByte);
}

void DisplayDriver::skipLine()
{
  for(byte b = 0; b < 8; b++)
  {
    shiftCursorToRight();
  }
}

void DisplayDriver::sendString(String s)
{
  for(int i = 0; i < s.length(); i++)
  {
    Serial.println(s);
    if(s.charAt(i) == '\n') continue;
    sendChar(s.charAt(i));
  }
}

void DisplayDriver::sendChar(char* c){
  for(int i = 0; i < sizeof(c); i++){
    sendChar(c[i]);
    Serial.print(c);
  }
  Serial.println("");
}

void DisplayDriver::lineJump(){
  while(charQuantity % 16 != 0){
    sendChar(' ');
  }
}

void DisplayDriver::sendChar(char c)
{
  sendData(true, c);
  charQuantity++;
  if(charQuantity == 16)
  {
    skipLine();
  }
  if(charQuantity == 32)
  {
    cursorToHome();
    skipLine();
  }
  if(charQuantity == 48)
  {
    skipLine();
  }
  if(charQuantity == 64)
  {
    charQuantity = 0;
    cursorToHome();
  }
}

void DisplayDriver::shiftCursorToRight()
{
  sendData(false, shiftCursorByte);
}

void DisplayDriver::init(bool mode)
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
    goToExtendedInstructionSet(); 
    sendData(false, initializeByte);  
  }
  else
  {
    goToReducedInstructionSet();
    sendData(false, initializeByte);
    sendData(false, secondInitializeByte);
    cursorToHome();
  }
  
}

void DisplayDriver::sendData(bool isData, byte data)
{
  digitalWrite(RS, isData);
  for(byte i = 0; i < 8; i++)
  {
    bool toSend = bitRead(data, i);
    digitalWrite(dataPins[i], toSend);
  }
  digitalWrite(EN, HIGH);
  delayMicroseconds(100);
  digitalWrite(EN, LOW);
  digitalWrite(RS, LOW);
}

void DisplayDriver::enBlink(){
  bitSet(initializeByte, 0);
  sendData(false, initializeByte);
}

void DisplayDriver::disBlink(){
  bitClear(initializeByte, 0);
  sendData(false, initializeByte);
}


void DisplayDriver::disCursor(){
  bitClear(initializeByte, 1);
  sendData(false, initializeByte);
}

void DisplayDriver::enCursor(){
  bitSet(initializeByte, 1);
  sendData(false, initializeByte);
}
