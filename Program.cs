bool myBoolean;
myBoolean = true;
Console.WriteLine($"{nameof(myBoolean)} : {myBoolean}");
char myChar = '\x0061';
Console.WriteLine($"{nameof(myChar)} : {myChar}");
string myString = "this is a string";
Console.WriteLine($"{nameof(myString)} : {myString}");
int myInteger = 9;
Console.WriteLine($"{nameof(myInteger)} : {myInteger}");
decimal myDecimal = 3.14m;
Console.WriteLine($"{nameof(myDecimal)} : {myDecimal}");

// object

object obj = myString;
Console.WriteLine($"{nameof(obj)} : {obj}");
obj = myDecimal;
Console.WriteLine($"{nameof(obj)} : {obj}");