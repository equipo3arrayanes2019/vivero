#include "HTTPSender.h"


String HTTPSender::send(String url, char* host){
  url.replace(" ", "%20");
  String message = String("GET ") + url + String(" HTTP/1.1\r\nHost: ") + String(host) + String("\r\n") + String("Connection: close\r\n\r\n");
  return NetworkCommunication::send(host, HTTPSender::PORT, message);
}
