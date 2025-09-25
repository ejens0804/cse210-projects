using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your current grade percentage?");
        string userGradeInput = Console.ReadLine                   ();
        int grade = int.Parse(userGradeInput);
        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else if (grade < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (grade >= 70)
        {
            Console.WriteLine("You have a passing grade.");
        }

        else
        {
            Console.WriteLine("You do not have a passing grade.");
        }



        // Sample Solution
        // Console.Write("What is your grade percentage? ");
        // string answer = Console.ReadLine();
        // int percent = int.Parse(answer);

        // string letter = "";

        // if (percent >= 90)
        // {
        //     letter = "A";
        // }
        // else if (percent >= 80)
        // {
        //     letter = "B";
        // }
        // else if (percent >= 70)
        // {
        //     letter = "C";
        // }
        // else if (percent >= 60)
        // {
        //     letter = "D";
        // }
        // else
        // {
        //     letter = "F";
        // }

        // Console.WriteLine($"Your grade is: {letter}");
        
        // if (percent >= 70)
        // {
        //     Console.WriteLine("You passed!");
        // }
        // else
        // {
        //     Console.WriteLine("Better luck next time!");
        // }
    }
}