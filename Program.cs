using System;

class Program
{
    static void Main(string[] args)
    {
        string ReverseWord(string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {
                result += word[i];
            }
            return result;
        }
    }
}