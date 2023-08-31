using System;

class Program
{
    static void Main(string[] args)
    {   
        string[] myStrings = new string[2] { "I Like Drink Coffe. I Drink with Ice", "I Like Drink Tea" };
        int stringCount = myStrings.Length;

        string myString = "";
        int periodLocation = 0;

        for (int i = 0; i < stringCount; i++)
        {
            myString = myStrings[i];
            periodLocation = myString.IndexOf(".");

            string mySentence;

            while (periodLocation != -1)
            {
                // first sentence is the string value to the left of the period location
                mySentence = myString.Remove(periodLocation);

                // the remainder of myString is the string value to the right of the location
                myString = myString.Substring(periodLocation + 1);

                // remove any leading white-space from myString
                myString = myString.TrimStart();

                // update the comma location and increment the counter
                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }

             mySentence = myString.Trim();
            Console.WriteLine(mySentence);

        }
    }
}