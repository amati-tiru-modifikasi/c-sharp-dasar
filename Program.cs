using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        int j = i; 
        Console.WriteLine($"Before, {nameof(i)}: {j}, {nameof(j)}: {j}");
        i = 1;
        Console.WriteLine($"After, {nameof(i)}: {i}, {nameof(j)}: {j}");

        // var randomString = GetCodeString();
        // switch (randomString)
        // {
        //     case "code1":
        //         Console.WriteLine($"{randomString}, case 1");
        //         break;
        //     case "code2":
        //         Console.WriteLine($"{randomString}, case 2");
        //         break;
        //     case "code3":
        //         Console.WriteLine($"{randomString}, case 3");
        //         break;
        //     default:
        //         Console.WriteLine($"{randomString}, invalid");
        //         break;
        // }
    }

    static string GetCodeString()
    {
        return new string[4] { "code1","code2","code3","code4" }[new Random().Next(0,4)];
    }

    static bool GenerateRandomBoolean()
    {
        return Convert.ToBoolean(new Random().Next(0, 2));
    }

    static int GenerateRandomToInt()
    {
        return new Random().Next(1, 6);
    }
}