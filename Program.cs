class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num));
            Console.ReadKey(); // press any key
        }
        catch (System.Exception ex)
        {
            Console.WriteLine($"There is something wrong in our application, please look at this message: {ex.Message}");
            Console.ReadKey(); // press any key

        }

    }
}