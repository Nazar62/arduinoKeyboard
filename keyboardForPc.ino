#define blueBtn 5
#define whiteBtn 4
#define redBtn 7
#define SCK A5
#define SDA A4
#define ButtonDelay 2000
//DONT work
#include <GyverOLED.h>
GyverOLED<SSD1306_128x64, OLED_NO_BUFFER> oled;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  oled.init(SCK, SDA);
  oled.clear();
  oled.home();
  pinMode(redBtn, INPUT_PULLUP);
  pinMode(whiteBtn, INPUT_PULLUP);
  pinMode(blueBtn, INPUT_PULLUP);
}

void loop() {
  // put your main code here, to run repeatedly:
  bool redBtnPress = !digitalRead(redBtn);
  bool whiteBtnPress = !digitalRead(whiteBtn);
  bool blueBtnPress = !digitalRead(blueBtn);

  static int redBtnPressTime = 0;
  static int whiteBtnPressTime = 0;
  static int blueBtnPressTime = 0;

  if (redBtnPress == true && millis() - redBtnPressTime >= ButtonDelay) {
    Serial.println("1");
    oled.clear();
    oled.home();
    oled.print("1");
    redBtnPressTime = millis();
  }
  if (whiteBtnPress == true && millis() - whiteBtnPressTime >= ButtonDelay) {
    Serial.println("2");
    oled.clear();
    oled.home();
    oled.print("2");
    whiteBtnPressTime = millis();
  }
  if (blueBtnPress == true && millis() - blueBtnPressTime >= ButtonDelay) {
    Serial.println("3");
    oled.clear();
    oled.home();
    oled.print("3");
    blueBtnPressTime = millis();
  }
}
