using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "there are snakes at the zoo";
        
        Console.WriteLine(input);
        Console.WriteLine(ReverseSentence(input));

        string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i>= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        string ReverseSentence(string input)
        {
            string result = "";
            // extrac individual word using string.Split
            string[] words = input.Split(" ");

            // store in result to access the word
            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }

            // remove extra space with Trim()
            return result.Trim();
        }
    }
}