using System;

class Program
{
    static void Main(string[] args)
    {
        double pi = 3.14159;

        PrintCicleInfo(12);
        PrintCicleInfo(33);

        void PrintCicleArea(int radius) 
        {
            double area = pi * (radius * radius);
            Console.WriteLine($"Area = {area}");
        }

        void PrintCirclCircumference(int radius)
        {
            double circumeference = 2 * pi * radius;
            Console.WriteLine($"Circumference = {circumeference}");
        }

        void PrintCicleInfo(int radius)
        {
            Console.WriteLine($"Circle with radius {radius}");
            PrintCicleArea(radius);
            PrintCirclCircumference(radius);
        }
    }
}