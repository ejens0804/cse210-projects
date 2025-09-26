using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static void PromptUserBirthYear(out int birthYear) //accepts out integer and prompts the user for the year they were born
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int numberToSquare)
    {
        int squaredNumber = numberToSquare * numberToSquare;
        return squaredNumber;
    }

    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        Console.WriteLine($"{userName}, you will turn {2025 - birthYear} this year.");
    }

    public static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int birthYear = 0;
        PromptUserBirthYear(out birthYear);
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber, birthYear);

    }
}