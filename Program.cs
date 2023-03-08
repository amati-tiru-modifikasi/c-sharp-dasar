class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(num));
    }
}