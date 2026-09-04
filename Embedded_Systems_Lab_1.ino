#include <LiquidCrystal_I2C.h>

LiquidCrystal_I2C lcd(32, 16, 2);

const int updateInterval = 1000;
const int force_pin = A0;
const int moisture_pin = A1;
const int relay_pin_1 = 8;
const int relay_pin_2 = 7;
int f_raw = 0;
int m_raw = 0;
bool turnPump = false;
bool refillWater = false;
int currTime = 0;

void updateSensorVal(int force, int moisture){
  lcd.setCursor(11, 0);
  lcd.print(force);
  lcd.print(" ");
  
  lcd.setCursor(11, 1);
  lcd.print(moisture);
  lcd.print(" ");
}

void setup()
{
  Serial.begin(9600);
  
  pinMode(force_pin, INPUT);
  pinMode(moisture_pin, INPUT);
  pinMode(relay_pin_1, OUTPUT);
  pinMode(relay_pin_2, OUTPUT);
  
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("Force    : ");
  lcd.setCursor(0, 1);
  lcd.print("Moisture : ");
}

void loop()
{
  if (millis() - currTime > updateInterval) {
  	f_raw = analogRead(force_pin);
  	m_raw = analogRead(moisture_pin);
  	updateSensorVal(f_raw, m_raw);
  }
  
  if (f_raw < 200) {
    refillWater = true;
  }
  
  if (m_raw < 200) {
  	turnPump = true;
  }
  
  if (turnPump) {
  	digitalWrite(relay_pin_2, HIGH);
    delay(2000);
    digitalWrite(relay_pin_2, LOW);
    turnPump = false;
  }
  
  if (refillWater) {
  	digitalWrite(relay_pin_1, HIGH);
    if (f_raw >= 400) {
      refillWater = false;
    }
  } else {
  	digitalWrite(relay_pin_1, LOW);
  }
}