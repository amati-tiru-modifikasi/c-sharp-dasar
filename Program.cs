using System;

class Program
{
    static void Main(string[] args)
    {
        int currentAssignments = 5;
        string currentStudentLetterGrade = "";


        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        int[] studentScores = new int[10];

        foreach (string name in studentNames)
        {
            string currentStudentName = name;

            if (currentStudentName == "Sophia")
                studentScores = sophiaScores;
            else if (currentStudentName == "Andrew")
                studentScores = andrewScores;
            else if (currentStudentName == "Emma")
                studentScores = emmaScores;
            else if (currentStudentName == "Logan")
                studentScores = loganScores;
         
            int sumAssignmentScores = 0;
            decimal currentStudentGrade = 0;

            foreach (int score in studentScores)
            {
                sumAssignmentScores += score;
            }

          

            currentStudentGrade = (decimal) sumAssignmentScores / currentAssignments;

            Console.WriteLine($"{currentStudentName}\t\t{currentStudentGrade}\t?");

                
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}