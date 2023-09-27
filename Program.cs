using System;

class Program
{
    static void Main(string[] args)
    {
        double usd = 23.73;
        int idr = UsedToIdr(usd);

        Console.WriteLine($"${usd} USD = Rp.{idr} rupiah");

        int UsedToIdr(double usd)
        {
            int rate = 15000;
            return (int) (rate * usd);
        }

    }
}