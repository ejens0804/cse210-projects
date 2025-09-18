using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");


        // Console.WriteLine("Hello Prep1 World!");
        // string firstName = "Bob";
        // Console.WriteLine($"Hello {firstName}");

        // Console.Write("How old are you?");
        // int age = int.Parse(Console.ReadLine());
        // Console.WriteLine($"{firstName}, you are {age} years old.");

        // int a = 13;
        // int b = 7;

        // int c = a + b;

        // Console.WriteLine($"c is {c}");
        // Console.WriteLine($"a/b is {a / b}");
        // Console.WriteLine($"{(double)a / b}");


        // double x = 1.5;
        // float y = 1.5f;

        // bool isDone = false;
        // if (isDone)
        // {
        //     Console.WriteLine("All done.");

        // }
        // else
        // {
        //     Console.WriteLine("It is not done.");
        // }
    }
}

// void means that you're not returning anything in the function

/*
Console.WriteLine("") is the C# equivalent of print("") in python

*/

// camelCase PascalCase snake_case

/*
declaring variables:
C#: string firstName = "Bob";
Python: firstName = "Bob"
*/


/*
string interpolation: (similar to f strings in python)
Console.WriteLine($"Hello {firstName}")

Console writeline always goes to a new line at the end (you don't need to use \n)

Console.Write("stuff goes here")

The Console.Write command writes stuff all on the same line and doesn't go to a new line

*/

/*
How to get User Input:

Console.Write("What is your favorite color?");
string favoriteColor = Console.ReadLine();

Console.WriteLine($"{firstName}, your favorite color is {favoriteColor}.")
*/

// dotnet run is used to run the current file from the command line (make sure that I'm in the working directory that I need to be in

// ctrl backtick is used to jumb from the editor to the terminal


