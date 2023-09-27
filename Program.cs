using System;

class Program
{
    static void Main(string[] args)
    {
        double usd = 23.73;
        int idr = UsdToIdr(usd);

        Console.WriteLine($"${usd} USD = Rp.{idr} rupiah");
        Console.WriteLine($"Rp.{idr} IDR = ${IdrToUsd(idr)} USD");

        int UsdToIdr(double usd)
        {
            int rate = 15500;
            return (int) (rate * usd);
        }

        double IdrToUsd(int idr)
        {
            int rate = 15500;
            return idr / rate;
        }

    }
}