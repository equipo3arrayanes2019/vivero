#include "HTTPSender.h"

void HTTPSender::flush(){
  if(sendCount > -1){
    Serial.println("--------------------------------  FLUSHING HTTP CACHE ----------------------------------");
    retainingFrom = millis();
    for(sendCount; sendCount >= 0; sendCount--){
      Logger::logginfo(String("CACHE +++++++++++++++++++++++++++++++     ") + String(sendCount) + String("     ++++++++++++++++++++++++++++++++"));
      send(queue[sendCount]);
      if(millis() - retainingFrom > MAX_RETAIN_ON_FLUSH){
        Logger::logginfo(String("Maximum time reached"));
        Serial.println("--------------------------------        END           ----------------------------------");
        return;
      }
    }
    sendCount = -1;
    Serial.println("--------------------------------        END           ----------------------------------");
  }else{
    Logger::logginfo(String("No cache to flush"));
  }
}

void HTTPSender::addQueue(String url){
  sendCount++;
  if(sendCount < HTTPSENDER_H_BUFFERSIEZE){
    queue[sendCount] = url;
    Logger::logginfo(String("Cached") + String(sendCount) + String(": ")  + queue[sendCount]);
    //Serial.printf("\n############################# Free: %d Bytes\n\n",ESP.getFreeHeap());
  }else{
    sendCount--;
    Logger::loggwarning(String("SENDER CACHE OVERFLOW SCRAPPING NEW QUEUES UNTIL FLUSH"));
  }
}

String HTTPSender::send(String url) {
  url = String("http://") + String(host) + String("/") + folder + String("/") + url;
  url.replace(" ", "%20");
  String message = String("GET ") + url + String(" HTTP/1.1\r\nHost: ") + String(host) + String("\r\n") + String("Connection: close\r\n\r\n");
  return NetworkCommunication::send(host, HTTPSender::PORT, message);
}
