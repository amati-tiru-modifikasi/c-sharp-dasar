using System;

class Program
{
    static void Main(string[] args)
    {
        var randomBool = GenerateRandomBoolean();
        switch (randomBool)
        {
            case true:
                Console.WriteLine("Generated has been true");
                break;
            default:
                Console.WriteLine("Generated has been false");
                break;
        }

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