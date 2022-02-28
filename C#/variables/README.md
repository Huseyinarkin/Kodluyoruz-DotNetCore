# Variables
C# da tanımlı olan değişkenleri yazdığım, hangi veri tipi için hangi değişkenleri kullanmamanın gerektiğini ve kullanımda ihtiyaca göre bellekte daha az yer kaplayan değişkenleri kullanmanın bellek kullanımı açısından daha performanslı olacağını öğrendim ve alıştırma yaptım.

Çalışmanın bit kısmı aşağıda gösterilmiştir.
```c#
byte b = 5;             //1 byte
sbyte c = 5;            //1 byte

short s = 5;            //2 byte
ushort us = 5;          //2 byte

int i = 2;              //4 byte
long l = 4;             //8 byte

//Reel sayılar
float f = 5;            //4 byte
double d = 5;           //8 byte
decimal de = 5;         //16 byte

char ch = '2';          //2 byte
string str = "Hüseyin"; //sınırsız

//boolean
bool bool1 = 10 < 2;

//Datetime
string datetime = DateTime.Now.ToString("dd.MM.yyyy"); //28.02.2022
string hour = DateTime.Now.ToString("HH:mm"); //23:43
```