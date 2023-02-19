var myBoolean = true;
Console.WriteLine($"{nameof(myBoolean)} : {myBoolean}");
var myChar = '\x0061';
Console.WriteLine($"{nameof(myChar)} : {myChar}");
var myString = "this is a string";
Console.WriteLine($"{nameof(myString)} : {myString}");
var myInteger = 9;
Console.WriteLine($"{nameof(myInteger)} : {myInteger}");
var myDecimal = 3.14m;
Console.WriteLine($"{nameof(myDecimal)} : {myDecimal}");

// object

object obj = myString;
Console.WriteLine($"{nameof(obj)} : {obj}");
obj = myDecimal;
Console.WriteLine($"{nameof(obj)} : {obj}");