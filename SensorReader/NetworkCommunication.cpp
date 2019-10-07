#include "NetworkCommunication.h"
#include "Logger.h"

void NetworkCommunication::LogInfo(){
  Logger::Log(&LogValue, Logger::LOGTYPE_WIFI, Logger::LOGLEVEL_INFO);
}


void NetworkCommunication::LogError(){
  Logger::Log(&LogValue, Logger::LOGTYPE_WIFI, Logger::LOGLEVEL_CRITICAL);
}

void NetworkCommunication::LogWarning(){
  Logger::Log(&LogValue, Logger::LOGTYPE_WIFI, Logger::LOGLEVEL_WARNING);
}


String NetworkCommunication::IpToString(IPAddress ip){
  return String(ip[0]) + "." + String(ip[1]) + "." + String(ip[2]) + "." + String(ip[3]);
}

bool NetworkCommunication::GetWiFiStatus(){
  return WifiStatus;
}


void NetworkCommunication::send(IPAddress* ip, String* message){
  //WiFiClient c
}
