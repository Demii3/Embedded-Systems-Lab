const int LED = 13;
const int LDR = A0; // analog sensor
const int PIR = 2; // digital sensor
const int anotherStuff = A2;

void setup() {
  Serial.begin(9600);
  pinMode(PIR, INPUT);
  pinMode(LED, OUTPUT);
}

void loop(){
  int light = analogRead(LDR);
  int motion = digitalRead(PIR);
  Serial.print(light); Serial.print(","); Serial.println(motion); // tag data records with 'D'
  delay(200);
}