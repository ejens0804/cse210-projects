using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>(); //create a list
        int keepRunning = 1;
        int sumOfNumberList = 0;

        while (keepRunning != 0) //ask for user input to input numbers until they enter 0
        {
            Console.Write("Enter number: ");
            
            
            keepRunning = numberToAdd;
            if (numberToAdd != 0) //only add the number if it isn't 0 to avoid adding 0 and messing up the average
            {
                numberList.Add(numberToAdd);
            }
        }

        //iterate through the list and add all of the numbers together
        foreach (int number in numberList)
        {
            sumOfNumberList += number; //compute the sum of the numbers in the list
        }

        Console.WriteLine($"The sum is: {sumOfNumberList}");

        float averageOfNumberList = (float)sumOfNumberList / numberList.Count; //compute the average of the numbers in the list
        Console.WriteLine($"The average is: {averageOfNumberList}");

        int maxNumber = numberList.Max(); //find the maximum/largest number in the list
        Console.WriteLine($"The largest number is: {maxNumber}");

        int minPositiveNumber = maxNumber;
        foreach (int number in numberList)
        {
            if (number > 0 && number < minPositiveNumber)
            {
                minPositiveNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {minPositiveNumber}");

        Console.WriteLine("The sorted list is: ");
        //sort list by numerical value
        List<int> sortedNumberList = numberList.OrderBy(number => number).ToList();
        foreach (int number in sortedNumberList)
        {
            Console.WriteLine(number);
        }
    }
}