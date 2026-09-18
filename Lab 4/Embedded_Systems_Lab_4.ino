const int LED = 3;
const int LDR = A0;  // analog sensor
const int PIR = 2;   // digital sensor
const int anotherStuff = A2;

const int sendDataDuration = 200;
long unsigned int currTime = 0;
void setup() {
  Serial.begin(9600);
  pinMode(PIR, INPUT);
  pinMode(LED, OUTPUT);
}

void loop() {
  if (Serial.available()) {  // handle any incoming command first
    char c = Serial.read();
    if (c == '1') digitalWrite(LED, HIGH);
    if (c == '0') digitalWrite(LED, LOW);
    if (c == '1' || c == '0') Serial.println("ACK");  // acknowledgement
  }

  if (millis() - currTime > sendDataDuration) {
    currTime = millis();
    int light = analogRead(LDR);
    int motion = digitalRead(PIR);
    Serial.print("D,");
    Serial.print(light);
    Serial.print(",");
    Serial.println(motion);  // tag data records with 'D'
  }
}