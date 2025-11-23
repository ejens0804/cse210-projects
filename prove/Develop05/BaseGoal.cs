public abstract class BaseGoal
{
    public int _goalType { get; set; }
    public string _goalTitle { get; set; }
    public string _goalDescription { get; set; }
    public int _completionPointValue { get; set; }
    public bool _completionStatus { get; set; } 

    public BaseGoal()
    {
        _completionStatus = false; // default status is incomplete
    }

    public void SetGoalType(int goalType)
    {
        // Console.Write("What Goal type would you like to create? ");
        // _goalType = int.Parse(Console.ReadLine());
        _goalType = goalType;
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

    public virtual void SetCompletionPointValue()
    {
        Console.Write("How many XP points do you want this goal to be worth upon completion? ");
        _completionPointValue = int.Parse(Console.ReadLine());
    }

    public abstract void MarkComplete();
    public virtual int RecordPoints()
    {
        return _completionPointValue;
    }

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