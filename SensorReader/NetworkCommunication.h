#include <Arduino.h>
#include <WiFi.h>
#include "Logger.h"
#include "SerialAsker.h"

#pragma once

/*
 * 
 * This class serves as network communication basics, like listenning to a socket, 
 * initialization of the network connection, it does low level stuff
 * 
*/
class NetworkCommunication{

  public:
  
    static const byte MAX_CONNECTION_ATTEMPTS = 50;
    static const word CONNECTION_ATTEMPT_ESTIMATED_INTERVAL = 700;
  
  public:
    
    NetworkCommunication(char* WIFI_SSID, int ssid_size, char* WIFI_PASSWD, int pass_size){   

      if(strlen(WIFI_SSID) == 0){
        SerialAsker::AskForCString("Enter WIFI SSID", WIFI_SSID, ssid_size);
      }
      
      if(strlen(WIFI_PASSWD) == 0){
        SerialAsker::AskForCString("Enter WIFI Password:", WIFI_PASSWD, pass_size); 
      }
      ConnectionAttemptCount = 0;
      
      WiFi.setHostname("SensorController");
      LogValue = "[SSID]: '" + String(WIFI_SSID) + "'";
      LogInfo();
      LogValue = "[PASSWORD]: '" + String(WIFI_PASSWD)  + "'";
      LogInfo();
      WiFi.begin(WIFI_SSID, WIFI_PASSWD);
      
      while(WiFi.status() != WL_CONNECTED && ConnectionAttemptCount < MAX_CONNECTION_ATTEMPTS){
        if(millis() - LastConnectionAttempt > CONNECTION_ATTEMPT_ESTIMATED_INTERVAL){
          ConnectionAttemptCount++;
          LogValue = "[CONNECTION ATTEMPT]: " + String(ConnectionAttemptCount);
          LogInfo();
          LastConnectionAttempt = millis();
          delay(CONNECTION_ATTEMPT_ESTIMATED_INTERVAL);
        }
      }
      
      if(ConnectionAttemptCount < MAX_CONNECTION_ATTEMPTS){
        WifiStatus = 1;
        IPAddress ip = WiFi.localIP();
        LocalIp = IpToString(ip);
        LogValue = "IP ADDRESS: " + LocalIp;
        LogInfo();
      }else{
        WifiStatus = 0;
        while(!WifiStatus){
         LogValue = "Unable to connect wifi, reset to retry.";
         LogError();
         delay(CONNECTION_ATTEMPT_ESTIMATED_INTERVAL);
        }
      }
    }

    String IpToString(IPAddress);
    String GetLastRecvMessage();
    unsigned long GetSecondSinceLastRecv();
    bool GetWiFiStatus();
    void send(IPAddress* ip, String* message);

  private:
    String LocalIp;
    String RemoteIp;
    String LogValue;
    bool WifiStatus;
    byte ConnectionAttemptCount;
    unsigned long LastConnectionAttempt;

  private:
    void LogError();
    void LogInfo();
    void LogWarning();
};
