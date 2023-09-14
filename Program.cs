using System;

class Program
{
    static void Main(string[] args)
    {
        // Global student array
        string[] students = {"Jenna","Alesha","Haikal","Ziyad","Arshaka"};

        DisplayStudents(students);
        DisplayStudents(new string[] {"Putri","Zakiyah"}); // added more students

        // function to view student
        void DisplayStudents(string[] students)
        {
            foreach (string student in students)
            {
                Console.WriteLine($"{student}, ");
            }
            Console.WriteLine();
        }

        
        Console.WriteLine("");
        Console.WriteLine();
    }
}