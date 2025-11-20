public abstract class BaseGoal
{
    protected string _goalTitle;
    protected string _goalDescription;
    protected int _completionPointValue;
    protected int _goalType;
    protected bool _completionStatus;

    // Write a function to set the goal type
    public BaseGoal()
    {
        _completionStatus = false; // default status is incomplete
    }

    public void SetGoalType()
    {
        Console.Write("What Goal type would you like to create? ");
        _goalType = int.Parse(Console.ReadLine());
    }

    public abstract void DisplayGoal();

    public void SetTitle()
    {
        Console.Write("What is the title of your goal? ");
        _goalTitle = Console.ReadLine();
    }

    public void SetDescription()
    {
        Console.Write("What is your goal's description? ");
        _goalDescription = Console.ReadLine();
    }

    public void SetCompletionPointValue()
    {
        Console.Write("How many XP points do you want this goal to be worth upon completion? ");
        _completionPointValue = int.Parse(Console.ReadLine());
    }

    public abstract void MarkComplete();
    public abstract void RecordPoints();

    public string GetTitle()
    {
        return _goalTitle;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    public int GetCompletionPointValue()
    {
        return _completionPointValue;
    }

    public bool GetCompletionStatus()
    {
        return _completionStatus;
    }

    public int GetGoalType()
    {
        return _goalType;
    }
}