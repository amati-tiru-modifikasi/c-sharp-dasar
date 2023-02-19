using System.Globalization;

string myString = "I Love C#";
Console.WriteLine($"{myString.StartsWith("\x0049", false, CultureInfo.CurrentCulture)} : {myString.StartsWith("\x0049")}");
Console.WriteLine($"{myString.Length}");
Console.SetWindowSize(250,250);