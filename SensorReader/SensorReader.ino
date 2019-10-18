#include "SerialAsker.h"
#include "Logger.h"

#include "SimpleLedRoutine.h"
#include "LedManager.h"

#include <WiFi.h>

#include "SensorWrapper.h"
#include "CHT.h"
#include "DHTReader.h"
#include "HumiditySoilReader.h"
#include "TemperatureSoilReader.h"

static const byte MAX_CONNECTION_ATTEMPTS = 50;
static const word CONNECTION_ATTEMPT_ESTIMATED_INTERVAL = 700;

const int ssid_size = 30;
const int pass_size = 30;
char SSID[ssid_size] =  "cosopere"; // { '\0' };
char PASS[pass_size] =  "megustaelpan"; //{ '\0' };
unsigned long MESSAGE_TIMEOUT = 5000;

IPAddress local_IP(192, 168, 50, 40);
// Set your Gateway IP address
IPAddress gateway(192, 168, 50, 20);

IPAddress subnet(255, 255, 0, 0);
IPAddress primaryDNS(192, 168, 50, 1);   //optional

#define SERVER "192.168.50.1"
#define FOLDER "sensors"

//dhts ------------
#define DHT01PIN              4
  #define DHT01TYPE           DHT11
#define DHT02PIN              15
  #define DHT02TYPE           DHT11
#define DHT03PIN              27
  #define DHT03TYPE           DHT11

#define HUMIDITYSOIL01PIN     35
#define HUMIDITYSOIL02PIN     34
#define HUMIDITYSOIL03PIN     33

#define TEMPERATURESOIL01PIN  18
#define TEMPERATURESOIL02PIN  19
#define TEMPERATURESOIL03PIN  12

#define ZONE01_WATER          22
#define ZONE02_WATER          23
#define ZONE03_WATER          13

word PUMP_PIN = 5;

const int SENSOR_COUNT = 3;

SensorWrapper* sr;
Zone*      zones[SENSOR_COUNT];
HTTPSender* http;

void setup() {
      Serial.begin(230400);
  /*
   * -------------------------------------------------------------------------------------------------------------------------------------------------
   */
      if(strlen(SSID) == 0){
        SerialAsker::AskForCString("Enter WIFI SSID", SSID, ssid_size);
      }
      
      if(strlen(PASS) == 0){
        SerialAsker::AskForCString("Enter WIFI Password:", PASS, pass_size); 
      }
      int ConnectionAttemptCount = 0;
      
      //WiFi.setHostname("SensorController");
      Logger::logwinfo(String("[SSID]: '") + String(SSID) + String("'"));
      Logger::logwinfo((String("[PASSWORD]: '") + String(PASS)  + String("'")));
      
      //WiFi.mode(WIFI_STA);
      WiFi.config(local_IP, gateway, subnet, primaryDNS);
      WiFi.begin(SSID, PASS);
      unsigned long LastConnectionAttempt = 0;
      while(WiFi.status() != WL_CONNECTED && ConnectionAttemptCount < MAX_CONNECTION_ATTEMPTS){
        if(millis() - LastConnectionAttempt > CONNECTION_ATTEMPT_ESTIMATED_INTERVAL){
          ConnectionAttemptCount++;
          Logger::logwinfo(("[CONNECTION ATTEMPT]: " + String(ConnectionAttemptCount)));
          LastConnectionAttempt = millis();
          delay(CONNECTION_ATTEMPT_ESTIMATED_INTERVAL);
        }
      }
      
      if(ConnectionAttemptCount < MAX_CONNECTION_ATTEMPTS){
        IPAddress ip = WiFi.localIP();
        Logger::logwinfo( (String("IP ADDRESS: ") + NetworkCommunication::IpToString(ip)) );
      }else{
        while(1){
         Logger::logwerror(String("Unable to connect wifi, reset to retry."));
         delay(CONNECTION_ATTEMPT_ESTIMATED_INTERVAL);
        }
      }
  /*
   * -------------------------------------------------------------------------------------------------------------------------------------------------
   */
  http = new HTTPSender(SERVER, FOLDER);
   //sensors setup
  int i = 0;
  CHT* cht = new CHT(new TemperatureSoilReader(TEMPERATURESOIL01PIN), String("ARD01 TEMPERATURESOIL01"), new HumiditySoilReader(HUMIDITYSOIL01PIN), String("ARD01 HUMIDITYSOIL01"));
  DHTReader* dht = new DHTReader(DHT01PIN, DHT01TYPE, String("ARD01 TEMPERATUREAIR01"), String("ARD01 HUMIDITYAIR01"));
  zones[i] = new Zone(cht, dht, ZONE01_WATER, http);

  i++;
  cht = new CHT(new TemperatureSoilReader(TEMPERATURESOIL02PIN), String("ARD01 TEMPERATURESOIL02"), new HumiditySoilReader(HUMIDITYSOIL02PIN), String("ARD01 HUMIDITYSOIL02"));
  dht = new DHTReader(DHT02PIN, DHT02TYPE, String("ARD01 TEMPERATUREAIR02"), String("ARD01 HUMIDITYAIR02"));
  zones[i] = new Zone(cht, dht, ZONE02_WATER, http);

  i++;
  cht = new CHT(new TemperatureSoilReader(TEMPERATURESOIL03PIN), String("ARD01 TEMPERATURESOIL03"), new HumiditySoilReader(HUMIDITYSOIL03PIN), String("ARD01 HUMIDITYSOIL03"));
  dht = new DHTReader(DHT02PIN, DHT02TYPE, String("ARD01 TEMPERATUREAIR03"), String("ARD01 HUMIDITYAIR03"));
  zones[i] = new Zone(cht, dht, ZONE03_WATER, http);
  
  sr =  new SensorWrapper(SENSOR_COUNT, zones, PUMP_PIN, http);
}

unsigned long lu_takemeasurment;
const unsigned long t_takemeasurment = 50000;

void loop() {
  if(millis() - lu_takemeasurment > t_takemeasurment){
    lu_takemeasurment = millis();
    sr->summitData();
  }
  sr->handleTimers();
  sr->askIfPump();
  http->flush();
  //Serial.printf("\n############################# Free: %d Bytes\n\n",ESP.getFreeHeap());
}
