// TODO: Exercise - Implement try-catch exception handling

double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;

try
{
    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);  
}
catch (System.Exception)
{
    Console.WriteLine("Exit program");
}

// Catch exceptions thrown in called methods

try
{
    Process1();
}
catch (System.Exception)
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}