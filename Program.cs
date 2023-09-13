using System;

class Program
{
    static void Main(string[] args)
    {
        int[] jadwal = { 800, 1200, 1600, 2000 };
        DisplayPengaturanWaktu(jadwal, 6, -6);

        void DisplayPengaturanWaktu(int[] times, int currGMT, int newGMT)
        {
            int diff = 0; // give range value
            if (Math.Abs(newGMT) > 12 || Math.Abs(currGMT) > 12) // absolute value
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currGMT <= 0 || newGMT >= 0 && currGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currGMT));
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currGMT));
            }

            for (int i = 0; i < times.Length; i++)
            {
                int newTime = ((times[i] + diff)) % 2400;
                Console.WriteLine($"{times[i]} -> {newTime}");
            }
        }
    }
}