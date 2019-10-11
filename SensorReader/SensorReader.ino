#include "SerialAsker.h"
#include "Logger.h"

#include "SimpleLedRoutine.h"
#include "LedManager.h"

#include <WiFi.h>

#include <esp_adc_cal.h>

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
byte PIN_LED = 2;
unsigned long MESSAGE_TIMEOUT = 5000;

SimpleLedRoutine* wifiOn;

//dhts ------------
#define DHT01PIN              4
  #define DHT01TYPE           DHT11
#define DHT02PIN              15
  #define DHT02TYPE           DHT11      

#define HUMIDITYSOIL01PIN     35

#define HUMIDITYSOIL02PIN     34

#define TEMPERATURESOIL01PIN  18
#define TEMPERATURESOIL02PIN  19

#define ZONE01_WATER          20
#define ZONE02_WATER          2

word PUMP_PIN = 11;

const int SENSOR_COUNT = 2;

SensorWrapper* sr;
Zone*      zones[SENSOR_COUNT];

void setup() {
      Serial.begin(115200);
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
      
      WiFi.mode(WIFI_STA);
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

   //sensors setup
  int i = 0;
  CHT* cht = new CHT(new TemperatureSoilReader(TEMPERATURESOIL01PIN), String("ARD01 TEMPERATURESOIL01"), new HumiditySoilReader(HUMIDITYSOIL01PIN), String("ARD01 HUMIDITYSOIL01"));
  DHTReader* dht = new DHTReader(DHT01PIN, DHT01TYPE, String("ARD01 TEMPERATUREAIR01"), String("ARD01 HUMIDITYAIR01"));
  zones[i] = new Zone(cht, dht, ZONE01_WATER);

  i++;
  cht = new CHT(new TemperatureSoilReader(TEMPERATURESOIL01PIN), String("ARD01 TEMPERATURESOIL02"), new HumiditySoilReader(HUMIDITYSOIL02PIN), String("ARD01 HUMIDITYSOIL02"));
  dht = new DHTReader(DHT02PIN, DHT02TYPE, String("ARD01 TEMPERATUREAIR02"), String("ARD01 HUMIDITYAIR02"));
  zones[i] = new Zone(cht, dht, ZONE02_WATER);
      
  sr =  new SensorWrapper(SENSOR_COUNT, zones, PUMP_PIN, "192.168.30.230", "sensores");

  //wifi setup
  wifiOn = new SimpleLedRoutine(new LedManager(&PIN_LED), (word)50, (word)50, (word)40);
  while(wifiOn->run());
}

void loop() {
  sr->summitData();
  delay(9000);
}
