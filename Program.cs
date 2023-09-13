using System;

class Program
{
    static void Main(string[] args)
    {   
        string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRanges = false;

        foreach (string ip in ipv4Input)
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            ValidateLength();
            ValidateZeroes();
            ValidateRanges();

            if (validLength && validZeroes && validRanges)
            {
                Console.WriteLine($"{ip} Is valid IPv4 address");
            }else{
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        void ValidateLength() {
            validLength = address.Length == 4;
        }

        void ValidateZeroes() {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    validZeroes = false;
                    return;
                }
            }
            validZeroes = true;
        }

        void ValidateRanges() {
            foreach (string number in address)
            {
                if (int.Parse(number) > 255)
                {
                    validRanges = false;
                    return;
                }
            }
            validRanges = true;
        }

    }
}