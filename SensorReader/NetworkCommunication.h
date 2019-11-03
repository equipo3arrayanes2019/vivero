#include <Arduino.h>
#include <WiFi.h>
#include "Logger.h"

#pragma once

class NetworkCommunication{  
  public:
    NetworkCommunication()
    {
      
    }

    static const unsigned long TIMEOUT = 15000;
    static String IpToString(IPAddress);
    static String send(char* ip, word port, String message);

  private:
};
