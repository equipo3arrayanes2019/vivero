#include <Arduino.h>
#include "PostSender.h"
#include "NetworkCommunication.h"

void PostSender::send(){
  String middle("&");
  String out;
  for(int i = 0; i < MAX_DATA;i++){
    if(i +1 < MAX_DATA){
      out += data[i] + middle;
    }else{
      out += data[i];
    }
  }
  
  PostSender::clear();
}

void PostSender::clear(){
  for(int i = 0; i < MAX_DATA; i++){
    delete data[i];
  }
}


void PostSender::add(String *in){
  if(location != -1){
    data[location] = in;
  }
  location++;
  if(location >= MAX_DATA){
    location = -1;
  }
}
