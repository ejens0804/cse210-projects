using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your current grade percentage?");
        string userGradeInput = Console.ReadLine();
        int grade = int.Parse(userGradeInput);
        string letterGrade = null;

        if (grade >= 90)
        {
            letterGrade = "A";
            Console.WriteLine($"Your grade of {grade} is an {letterGrade}.");
        }

        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
            Console.WriteLine($"Your grade of {grade} is a {letterGrade}.");
        }

        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
            Console.WriteLine($"Your grade of {grade} is a {letterGrade}.");
        }

        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
            Console.WriteLine($"Your grade of {grade} is a {letterGrade}.");
        }

        else if (grade < 60)
        {
            letterGrade = "F";
            Console.WriteLine($"Your grade of {grade} is an {letterGrade}.");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You have a passing grade.");
        }

        else
        {
            Console.WriteLine("You do not have a passing grade.");
        }
        Console.WriteLine($"Your Letter grade is {letterGrade}.");
    }
}