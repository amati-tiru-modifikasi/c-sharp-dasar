using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Generating number numbers: ");
        DisplayRandomNumber();

        void DisplayRandomNumber()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{random.Next(1,100)}");
            }
            Console.WriteLine();
        }

    }


}