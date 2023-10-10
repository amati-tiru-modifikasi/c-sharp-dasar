// Code samples for compiler-generated exceptions

// ArrayTypeMismatchException
string[] names = { "Haikal", "Ziyad", "Arshaka" };
object[] objj = (object[])names;

object obj = (object)13;
objs[2] = obj; 


// DivideByZeroException
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2);


// FormatException
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue);


// IndexOutOfRangeException
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];
values2[values1.Length - 1] = values1[values1.Length - 1];


// NullReferenceException
int[] values = null;
for (int i=0; i<=9; i++)
    values[i] = i * 2;

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());


// OverflowException
decimal x = 400;
byte i;

i = (byte) x;
Console.WriteLine(i);