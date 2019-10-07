#include "NetworkCommunication.h"
#include "LedManager.h"
#include "SimpleLedRoutine.h"

//#include "DHT.h"
#include "DHTReader.h"
DHTReader* dht;

/*char SSID[50] =  { '\0' };
char PASS[50] =  { '\0' };
byte PIN_LED = 2;

NetworkCommunication* talker;
SimpleLedRoutine* wifiOn;
*/
void setup() {
  Serial.begin(115200);
  dht = new DHTReader((word)23, DHT11);
  
  /*talker = new NetworkCommunication(SSID, sizeof(SSID), PASS, sizeof(PASS));
  wifiOn = new SimpleLedRoutine(new LedManager(&PIN_LED), (word)50, (word)50, (word)40);
  while(wifiOn->run());*/
}

void loop() {
  Serial.println(dht->temperature());
}
