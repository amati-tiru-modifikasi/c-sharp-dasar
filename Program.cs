using System;

class Program
{
    static void Main(string[] args)
    {
        ```c#
        CountTo(5);

        void CountTo(int max) 
        {
            for (int i = 0; i < max; i++)
            {
                Console.Write($"${i}, ");
            }
        }
        ```
    }
}