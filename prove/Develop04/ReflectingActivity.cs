public class ReflectingActivity : Activity
{

    private string _activityDescription;
    private List<string> _promptList = new List<string>();
    private List<string> _promptQuestions = new List<string>();

    public ReflectingActivity()
    {
        // set variables here and don't hard code them directly
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _promptList.AddRange(new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." });
        _promptQuestions.AddRange(new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"});
    }

    public void DisplayActivityDescription()
    {
        Console.WriteLine($"\n{_activityDescription}");
    }

    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_promptList.Count);
        string randomPrompt = _promptList[index];
        return randomPrompt;
    }

    public string GetQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_promptQuestions.Count);
        string randomQuestion = _promptQuestions[index];
        return randomQuestion;
    }

    public void RunReflectingActivity()
    {
        Console.Clear();
        base.WelcomeMessage("2");
        DisplayActivityDescription();
        base.SetCountdown();

        int countdown = base.GetCountdown();

        Console.WriteLine("Get ready... ");
        base.Animation();

        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine($"\n--- {GetPrompt()} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Console.Clear();
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        while (countdown != 0)
        {
            Console.WriteLine($"> {GetQuestion()}");
            base.Animation();
            countdown = countdown - 10;
        }

        Console.WriteLine($"> {GetQuestion()}");
        // int sleepTime = countdown * 1000;
        // Thread.Sleep(sleepTime);
        base.Animation();

        base.GoodbyeMessage();
    }



}