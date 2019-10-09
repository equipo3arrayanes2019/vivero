#include "LedManager.h"
#include "SimpleLedRoutine.h"
#include "NetworkCommunication.h"
#include "Logger.h"

#include "DHTReader.h"
#include "HumiditySoilReader.h"
#include "TemperatureSoilReader.h"
#include "SensorWrapper.h"
#include "SerialAsker.h"

static const byte MAX_CONNECTION_ATTEMPTS = 50;
static const word CONNECTION_ATTEMPT_ESTIMATED_INTERVAL = 700;

const int ssid_size = 30;
const int pass_size = 30;
char SSID[ssid_size] =  "cosopere"; // { '\0' };
char PASS[pass_size] =  "megustaelpan"; //{ '\0' };
byte PIN_LED = 2;
unsigned long MESSAGE_TIMEOUT = 5000;

SimpleLedRoutine* wifiOn;
HTTPSender* sender;

//dhts ------------
#define DHT01PIN              0
  #define DHT01TYPE           DHT11
#define DHT02PIN              15
#define DHT02TYPE             DHT11      

#define HUMIDITYSOIL01PIN     6
#define HUMIDITYSOIL02PIN     7

#define TEMPERATURESOIL01PIN  7
#define TEMPERATURESOIL02PIN  8

word WATER_PINS[] = { 9, 10 };
word PUMP_PIN = 11;

const int SENSOR_COUNT = 2;

SensorWrapper* sr;
DHTReader* dhts[SENSOR_COUNT];
String* DHTTemperatureIds[SENSOR_COUNT];
String* DHTHumidityIds[SENSOR_COUNT];

HumiditySoilReader* hsr[SENSOR_COUNT];
String* hsrIds[SENSOR_COUNT];

TemperatureSoilReader* tsr[SENSOR_COUNT];
String* tsrIds[SENSOR_COUNT];

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
  
  dhts[i] = new DHTReader(DHT01PIN, DHT01TYPE);
    DHTHumidityIds[i] = new String("ARD01 HUMIDITYAIR01");
    DHTTemperatureIds[i] = new String("ARD01 TEMPERATUREAIR01");
    
  tsr[i] = new TemperatureSoilReader(TEMPERATURESOIL01PIN);
    tsrIds[i] =  new String("ARD01 TEMPERATURESOIL01");
  
  hsr[i] = new HumiditySoilReader(HUMIDITYSOIL01PIN);
    hsrIds[i] = new String("ARD01 HUMIDITYSOIL01");

  i++;
  dhts[i] = new DHTReader(DHT02PIN, DHT02TYPE);
    DHTHumidityIds[i] = new String("ARD01 HUMIDITYAIR02");
    DHTTemperatureIds[i] = new String("ARD01 TEMPERATUREAIR02");

  tsr[i] = new TemperatureSoilReader(TEMPERATURESOIL02PIN);
    tsrIds[i] = new String("ARD01 TEMPERATURESOIL02");

  hsr[i] = new HumiditySoilReader(HUMIDITYSOIL02PIN);
    hsrIds[i] = new String("ARD01 HUMIDITYSOIL02");
      
  sr =  new SensorWrapper(SENSOR_COUNT, DHTHumidityIds, DHTTemperatureIds, dhts, WATER_PINS, PUMP_PIN, hsrIds, tsrIds, hsr, tsr, "192.168.30.230", "sensores");

  //wifi setup
  wifiOn = new SimpleLedRoutine(new LedManager(&PIN_LED), (word)50, (word)50, (word)40);
  while(wifiOn->run());
}

void loop() {
  sr->summitData();
  delay(10000);
}
