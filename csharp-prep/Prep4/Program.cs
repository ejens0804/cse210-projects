using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numberList = new List<int>(); //create a list
        int keepRunning = 1;
        int sumOfNumberList = 0;

        while (keepRunning !=  0) //ask for user input to input numbers until they enter 0
        {
            Console.Write("Enter number: ");
            int numberToAdd = int.Parse(Console.ReadLine());
            keepRunning =  numberToAdd;
            if (numberToAdd != 0)
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
    }
}