#include "HTTPSender.h"


void HTTPSender::send(String url, char* host){
  url.replace(" ", "%20");
  String message = String("GET ") + url + String(" HTTP/1.1\r\nHost: ") + String(host) + String("\r\n") + String("Connection: close\r\n\r\n");
  NetworkCommunication::send(host, HTTPSender::PORT, message);
}
