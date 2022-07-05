// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operators");
// Atama ve İşlemli Atama Operatörleri (=, +=, -=, *=, /=)
    int x=6;
    Console.WriteLine(x.ToString()); // 6
    x+=3; // x = x + 3;
    Console.WriteLine(x.ToString()); // 9
    x -= 4; // x = x - 4;
    Console.WriteLine(x.ToString()); // 5
    x *= 6; // x = x * 6;
    Console.WriteLine(x.ToString()); // 25
    x /= 10; // x = x / 10;
    Console.WriteLine(x.ToString()); // 5

// Mantıksal Operatörler (||, &&, !)
    bool isSuccess = true;
    bool isCompleted = false;
    Console.WriteLine(isSuccess && isCompleted); // isSuccess ve isCompleted True mu ?
    Console.WriteLine(isSuccess || isCompleted); // isSuccess veya isCompleted True mu ?
    Console.WriteLine(!isSuccess); // Değilse

// İlişkisel Operatörler (==,!=, <, >, >=,<=)

// Aritmetik (+, -, *, /, %, ++, --)
