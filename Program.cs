using System;

class Program
{
    static void Main(string[] args)
    {
        int examAssignments  = 5;
        string currentStudentLetterGrade = "";

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96 };
        int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
        int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
        int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
        int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

        // student names
        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

        int[] studentScores = new int[10];

        // Write the Report Header to the console
        Console.WriteLine("Student\t\tGrade\n");

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
            else if (currentStudentName == "Becky")
                studentScores = beckyScores;
            else if (currentStudentName == "Chris")
                studentScores = chrisScores;
            else if (currentStudentName == "Eric")
                studentScores = ericScores;
            else if (currentStudentName == "Gregor")
                studentScores = gregorScores;
            else
                continue;
         
            // initialize/reset the sum of scored assignments
            int sumAssignmentScores = 0;

            // initialize/reset the calculated average of exam + extra credit scores
            decimal currentStudentGrade = 0;

            // initialize/reset a counter for the number of assignment 
            int gradedAssignments = 0;

            foreach (int score in studentScores)
            {
                // increment the assignment counter
                gradedAssignments += 1;

                if ( gradedAssignments <= examAssignments )
                    sumAssignmentScores += score;
                else 
                    sumAssignmentScores += score / 10;
            }

            currentStudentGrade = (decimal) sumAssignmentScores / examAssignments ;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else 
                currentStudentLetterGrade = "F";

            Console.WriteLine($"{currentStudentName}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

                
        }

        Console.WriteLine("Press the Enter key to continue");
        Console.ReadLine();
    }
}