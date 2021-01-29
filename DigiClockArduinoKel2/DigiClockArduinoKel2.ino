/* Mini Project Sistem Instrumentasi EL3013 K01
 * Nama : David Fauzi / Feroz Fernando 
 * NIM  : 13218043 / 13218003 
 * Deskripsi : Jam digital menggunakan ISR Overflow Timer ditampilkan pada 7 segment dan LCD serta
 *             HMI menggunakan protokol modbus RS-485 dengan interface yang dibuat menggunakan C#
 */
// Library
#include <SoftwareSerial.h>
#include <TM1637Display.h>
#include <LiquidCrystal_I2C.h>
// Define pin-pin
#define CLK 7              // 7 Seg
#define DIO 6              // 7 Seg
#define modBusPinMode 8    // Enabler modbus transmitter or receiver
#define buttonPin1 2       // button 1, change MODE to DISPLAY or SETTING
#define buttonPin2 3       // button 2, toggle LCD backlight
#define buttonPin3 4       // button 3, toggle 7SEG
#define ledPin LED_BUILTIN // D13
// Inisialisasi
TM1637Display display(CLK, DIO);    // 7SEG
LiquidCrystal_I2C lcd(0x27, 20, 4); // LCD
SoftwareSerial modBus(10, 11);      // MAX485
// Variabel-Variabel
// Waktu
#define defaultHours 11UL
#define defaultMinutes 59UL
#define defaultSeconds 59UL
unsigned long defaultTime = defaultHours * 3600 + defaultMinutes * 60 + defaultSeconds;
unsigned long time = 0;
// MODBUS RS-485
bool mode = 1; // 1 = transmit , 0 = receive
// Button
bool buttonState1 = 0;
bool buttonState2 = 0;
bool buttonState3 = 0;
bool lcdToggle = 1;
bool toggle7Seg = 1;
//Serial
String readSerial;
//Deklarasi fungsi
// Fungsi untuk setup register timer 1 untuk ISR overflow 
void setupInterrupt(void);
// Set up LCD dan tampilan awal LCD pada saat pertama kali dihidupkan
void introLcd(void);
// Mode display : Update waktu ke LCD dan 7 Segment
void updateDisplay(void);
// Mode setting : menunggu data RS-485 dari HMI PC untuk setting waktu, button 2 akan toggle nyala LCD, 
// dan button 3 akan toggle nyala 7 Segment
void settingClock(void);

void setup()
{
  // setup ISR timer
  setupInterrupt();
  // Pinmode
  pinMode(buttonPin1, INPUT);
  pinMode(buttonPin2, INPUT);
  pinMode(buttonPin3, INPUT);
  pinMode(ledPin, OUTPUT);
  pinMode(modBusPinMode, OUTPUT);
  digitalWrite(modBusPinMode, HIGH);
  // Serial
  Serial.begin(9600);
  modBus.begin(9600);
  // Setup LCD
  introLcd();
  // Setup 7seg, max brightness
  display.setBrightness(0x0f);
  Serial.print("Program Mulai");
}
void loop()
{
  buttonState1 = digitalRead(buttonPin1);
  if (mode)
    updateDisplay();
  else
  {
    settingClock();
  }
  if (!buttonState1)
  {
    mode = !mode;
    digitalWrite(modBusPinMode, mode);
    delay(100);
  }
}

void setupInterrupt(void)
{
  noInterrupts();
  TCCR1A = 0;   // set entire TCCR1A register to 0
  TCCR1B = 0;   // same for TCCR1B
  TCNT1 = 3037; // set preload
  // clock = 16M/256 = 62500 , T = 1/clock = 16u
  // dibutuhkan timer 1s, maka timer counter = (1/16u) -1 = 62499
  // register timer 1 16 bit, nilai max adalah 65536
  // sehingga nilai awal = 65536-62499 = 3037
  TCCR1B |= (1 << CS12);  // 256 prescaller
  TIMSK1 |= (1 << TOIE1); // enable timer overflow interrupt
  interrupts();
}
ISR(TIMER1_OVF_vect)
{               // interrupt dengan frekuensi 1Hz
  TCNT1 = 3037; // set preload
  time++;
  time = time % 86400; //prevent overflow
}

void introLcd(void)
{
  lcd.begin(16, 2);
  lcd.init(); // initialize the lcd
  lcd.backlight();
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Jam");
  lcd.setCursor(0, 1);
  lcd.print("Digital");
  delay(1500);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("David Fauzi");
  lcd.setCursor(0, 1);
  lcd.print("Feroz Fernando");
  delay(1500);
  lcd.clear();
}

void updateDisplay(void)
{
  // Konversi waktu ke format jam, menit, dan detik
  unsigned long t = defaultTime + time;
  byte hours = (byte)((t / 3600) % 24);
  byte minutes = (byte)((t / 60) % 60);
  byte seconds = (byte)(t % 60);
  String x = String(hours / 10) + String(hours % 10) + ":" + String(minutes / 10) + String(minutes % 10) +
             ":" + String(seconds / 10) + String(seconds % 10);
  // Update Display LCD
  lcd.setCursor(0, 0);
  lcd.print(x);      // print waktu ke LCD
  modBus.println(x); // kirim data ke RS-485
  Serial.println(x); // Kirim ke Serial Monitor
  lcd.setCursor(0, 1);
  lcd.print("MODE : DISPLAY");
  // Update Display 7SEG
  if (toggle7Seg)
    display.showNumberDecEx(hours * 100 + minutes, 0b11100000, true, 4, 0);
  delay(10);
}

void settingClock(void)
{
  lcd.setCursor(0, 1);
  lcd.print("MODE : SETTING");
  while (modBus.available())
  {
    readSerial = modBus.readString();
    byte h = (readSerial.substring(0, 2)).toInt();
    byte m = (readSerial.substring(3, 5)).toInt();
    byte s = (readSerial.substring(6, 8)).toInt();
    defaultTime = (unsigned long)h * 3600 + (unsigned long)m * 60 + (unsigned long)s; //casting
    time = 0;
    mode = 1;
    digitalWrite(modBusPinMode, mode);
  }
  buttonState2 = digitalRead(buttonPin2);
  buttonState3 = digitalRead(buttonPin3);
  if (!buttonState2)
  {
    if (lcdToggle)
      lcd.noBacklight();
    else
      lcd.backlight();
    lcdToggle = !lcdToggle;
    delay(500);
  }
  if (!buttonState3)
  {
    if (toggle7Seg)
      display.clear();
    else
      display.showNumberDec(8888);
    toggle7Seg = !toggle7Seg;
    delay(500);
  }
}
