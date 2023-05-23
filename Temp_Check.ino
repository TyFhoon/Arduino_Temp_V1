int temp;
int Switch; 

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(12,OUTPUT);
  pinMode(A0,INPUT);

  Switch = 0;
}

void loop() {
  // put your main code here, to run repeatedly:
  int reading = analogRead(A0);

  if (Switch == 0)
  {
    digitalWrite(12, HIGH); 
    Switch = 1; 
  }
  else if (Switch == 1)
  {
    digitalWrite(12, LOW); 
    Switch = 0; 
  }


  // Convert that reading into voltage
  // Replace 5.0 with 3.3, if you are using a 3.3V Arduino
  float voltage = reading * (5.0 / 1024.0);

  // Convert the voltage into the temperature in Celsius
  float temperatureC = (voltage - 0.5) * 100;

  Serial.println(temperatureC);
  delay(1000);
}
