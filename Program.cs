// basic operator

// int i = 0;
// int j = 0;
// Console.WriteLine(i);
// Console.WriteLine(j);
// j = ++i;
// Console.WriteLine(i);
// Console.WriteLine(j);

// arimatic operator

// int sum = 10 + 5;
// int difference = 7 - 2;
// int product = 5 * 3;
// int division = 15 / 3;
// Console.WriteLine($"{nameof(sum)}: {sum}");
// Console.WriteLine($"{nameof(difference)}: {difference}");
// Console.WriteLine($"{nameof(product)}: {product}");
// Console.WriteLine($"{nameof(division)}: {division}");

// int modulo = 10 % 3;
// Console.WriteLine($"{nameof(modulo)}: {modulo}");

// comparision operators
// int int1 = 10;
// int int2 = 20;

// Console.WriteLine($"{nameof(int1)} > {nameof(int2)} ? : {int1 > int2}");


// equality operators
// string str1 = "I love C#";
// string str2  = "I Love Javascript";

// Console.WriteLine($"{nameof(str1)} == {nameof(str2)} ({nameof(str1.ToLower)}) ? : {str1.ToLower() == str2.ToLower()}");

// Logical Operators
// bool bool1 = true;
// bool bool2 = false;
// bool bool3 = true;

// Console.WriteLine($"{nameof(bool1)}: {bool1}");
// Console.WriteLine($"{nameof(bool2)}: {bool2}");
// Console.WriteLine($"{nameof(bool3)}: {bool3}");


// Console.WriteLine($"!{nameof(bool3)}: {!bool3}");
// Console.WriteLine($"{nameof(bool1)} || {nameof(bool2)}:|| {nameof(bool3)}:: {bool1 || bool2 || bool3}");

// string concatentation + operator

// string string1 = string.Empty;
// string1 = "Hello " + "Boy";
// string string2 = string1 + "!";
// Console.WriteLine($"{nameof(string1)} : {string1}");
// Console.WriteLine($"{nameof(string2)} : {string2}");

// += operator
string str = "Hello boy";
str += " again !";
Console.WriteLine($"{nameof(str)} : {str}");

int integer = 10;
integer += 2;
Console.WriteLine($"{nameof(integer)} : {integer}");
