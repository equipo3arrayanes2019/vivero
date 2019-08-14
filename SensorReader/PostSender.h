#pragma once

#include <Arduino.h>
#include "NetworkCommunication.h"
#define MAX_DATA 10

class PostSender{

  private:
    NetworkCommunication* comm;
  
  public:
    PostSender(NetworkCommunication* netconnector):
      comm(netconnector), location(0)
    {
       
    };

    void send();
    void add(String *in);
    void clear();
    
  private:
    String* data[MAX_DATA];
    int location;
};
