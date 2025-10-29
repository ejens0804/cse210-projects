using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        math1.GetSummary();
        math1.GetHomeworkList();

        WritingAssignment wa = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        wa.GetSummary();
        wa.GetWritingInformation();
    }
}