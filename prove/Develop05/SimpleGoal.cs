public class SimpleGoal : BaseGoal
{
    public SimpleGoal()
    {
        
    }

    public void CreateSimpleGoal()
    {
        base.SetTitle();
        base.SetDescription();
        base.SetCompletionPointValue();
    }

    public override void DisplayGoal()
    {
        if (_completionStatus == true)
        {
            Console.WriteLine($"[x] {_goalTitle} ({_goalDescription})");
        }
        else
        {
            Console.WriteLine($"[ ] {_goalTitle} ({_goalDescription})");
        }
    }

    public override void MarkComplete()
    {
        _completionStatus = true;
    }

    public void LoadPreviousGoalData(int goalType, string title, string description, int completionPointValue, bool completionStatus)
    {
        _goalType = goalType;
        _goalTitle = title;
        _goalDescription = description;
        _completionPointValue = completionPointValue;
        _completionStatus = completionStatus;
    }
}