#include <ESP8266WiFi.h>
#include <ESP8266WiFiMulti.h>
#include<stdio.h>
#include<stdlib.h>
#ifndef STASSID
#define STASSID "Alwayslucky"
#define STAPSK  "y1234567"
#endif
const char* ssid     = STASSID;
const char* password = STAPSK;
const char* host = "192.168.203.112";
const uint16_t port = 3000;
ESP8266WiFiMulti WiFiMulti;
int ledPin = LED_BUILTIN;
int getCommand;
unsigned int sensorValue = 0;

void setup() {
  // put your setup code here, to run once:
  WiFi.mode(WIFI_STA);
  WiFiMulti.addAP(ssid, password);
  Serial.begin(15200);
while (WiFiMulti.run() != WL_CONNECTED) 
  {
  Serial.print(".");
  delay(500);
  }

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  delay(500);
}

void loop() {
  
  unsigned int  h = rand()%21+50;//读湿度
  unsigned int  t = rand()%11+20;//读温度，默认为摄氏度
  sensorValue = rand()%31+100;	
  Serial.print((String)t+"A"+h+"B"+sensorValue+"C"+"\n");
 WiFiClient client;

  if (!client.connect(host, port)) {
    Serial.println("connection failed");
    Serial.println("wait 2 sec...");
    delay(2000);
    return;
  }
 
  client.print((String)t+"A"+h+"B"+sensorValue+"C"+"\n");
  delay(2000);
  
 
}
