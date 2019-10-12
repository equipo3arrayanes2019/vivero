#pragma once

#include <Arduino.h>
#include "NetworkCommunication.h"
#define HTTPSENDER_H_BUFFERSIEZE  22

class HTTPSender{

  public:

    static const word PORT = 80;
    static const unsigned long MAX_RETAIN_ON_FLUSH = 3000;
  
    HTTPSender(char* host, char* folder):
      host(host), folder(folder), sendCount(-1)
    {
      
    }

    String send(String url);
    void addQueue(String url);
    void flush();

  private:
    char* host;
    String folder;
    int sendCount;
    String queue[HTTPSENDER_H_BUFFERSIEZE];
    unsigned long retainingFrom;
  
};
